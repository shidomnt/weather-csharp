using Newtonsoft.Json;
using System.Diagnostics;
using Weather.Classes;
using Weather.Classes.Serialization;
using Weather.Classes.Serialization.WeatherVisualCrossing;
using Weather.Constants;
using Weather.Helpers;

namespace Weather.Forms
{
    internal partial class FormWeather : Form
    {
        public CurrentWeather? CurrentWeather { get; set; }

        public CurrentLocation? CurrentLocation { get; set; }

        public WeatherVisualCrossingInfo? VisualCrossing { get; set; }

        public event EventHandler? WeatherChange;

        public WeatherController Controller { get; set; }

        public FormWeather(WeatherController controller)
        {
            InitializeComponent();
            Controller = controller;
            WeatherChange += (sender, e) => LoadWeatherToForm();

        }

        private async void FormWeather_Load(object sender, EventArgs e)
        {
            await GetCurrentWeather("hanoi");
        }

        private async void Btn_ChangeLocation_Click(object sender, EventArgs e)
        {
            var formCollectLocation = new FormChangeLocation();
            var dialogResult = formCollectLocation.ShowDialog(this);
            if (dialogResult != DialogResult.OK) return;

            if (formCollectLocation.LocationName == string.Empty)
            {
                MessageBox.Show(
                    "Tên thành phố rỗng",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                return;
            }

            await GetCurrentWeather(formCollectLocation.LocationName);
        }

        private async void Btn_Export_Click(object sender, EventArgs e)
        {
            if (CurrentWeather is null || CurrentLocation is null)
            {
                MessageBox.Show("Chọn vị trí cần xem thời tiết trước", "Thông báo");
                return;
            }

            try
            {
                using var saveFileDiaLog = new SaveFileDialog();
                saveFileDiaLog.Filter = "Excel|*.xls";
                saveFileDiaLog.Title = "Save an Excel File";
                saveFileDiaLog.FileName =
                    $"{CurrentLocation.Name}-{CurrentLocation.LocalTimeEpoch}.xls";
                var diaLogResult = saveFileDiaLog.ShowDialog(this);

                if (diaLogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDiaLog.FileName))
                {
                    var pathSaved = await Controller.ExportToExcelAsync(
                        CurrentWeather,
                        saveFileDiaLog.FileName
                        );
                    diaLogResult = MessageBox.Show(
                        "Xuất file Excel thành công! Bấm Ok để mở file ngay",
                        "Thông báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                        );
                    if (diaLogResult == DialogResult.OK)
                        Process.Start("explorer.exe", pathSaved);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Label_AQI_Click(object sender, EventArgs e)
        {
            if (CurrentLocation is null || CurrentWeather is null) return;
            var formAQI = new FormAQI(CurrentLocation, CurrentWeather);
            formAQI.ShowDialog();

        }

        private async void ApiSettingMenu_Click(object sender, EventArgs e)
        {
            var formGeneralSetting = new FormApiSetting();
            var result = formGeneralSetting.ShowDialog();
            if (result == DialogResult.OK)
            {
                var configuration = formGeneralSetting.Configuration;
                await AppConfiguration.SetAsync(configuration);

                result = MessageBox.Show(
                    "Khởi động lại ứng dụng ngay ?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.Restart();
                }
            }
        }

        public async Task GetCurrentWeather(string locationName)
        {
            try
            {
                var response = await Controller.GetCurrentWeatherAsync(locationName);
                if (response is not null)
                {
                    ExtractResponse(response);
                }
            }
            catch (HttpRequestException ex)
            {
                var message = ex.StatusCode switch
                {
                    System.Net.HttpStatusCode.Forbidden => "API Key hết hạn hoặc đã bị vô hiệu hóa.",
                    System.Net.HttpStatusCode.BadRequest => "Không tìm thây thành phố.",
                    System.Net.HttpStatusCode.Unauthorized => "API Key không được cung cấp.",
                    _ => ex.Message,
                };
                MessageBox.Show(
                    message,
                    ex.GetType().Name,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void LoadWeatherToForm()
        {
            if (CurrentWeather is null || CurrentLocation is null || VisualCrossing is null) return;

            Label_Location.Text = string.Join(',', VisualCrossing.ResolvedAddress.Split(",").Take(2));
            Label_Temperature.Text = VisualCrossing.CurrentCondition.Temp.ToString() + Unit.TempC;

            Label_WeatherCondition.Text = CurrentWeather.Condition.Text.ToString();

            var str = System.Text.Encoding.UTF8.GetString(Properties.Resources.weather_conditions);

            var weatherConditions = JsonConvert
                .DeserializeObject<List<WeatherCondition>>(str);

            if (weatherConditions is not null)
            {
                var iconNumber = weatherConditions
                    .Where(weatherCondition => weatherCondition.Code == CurrentWeather.Condition.Code)
                    .Select(weatherCondition => weatherCondition.Icon)
                    .FirstOrDefault();

                var iconName = $"{CurrentWeather.IsDay}{iconNumber}";

                PicBox_WeatherCondition.Image = (System.Drawing.Bitmap)
                    Properties.Resources.ResourceManager.GetObject(iconName, Properties.Resources.Culture)!;
            }

            var maxAirQualityDesc = AQIHelper.CalculateTotalAQI(CurrentWeather.AirQuality);

            Label_AQI.Text = $"{maxAirQualityDesc.Emoji} AQI {maxAirQualityDesc.Value}";

            var feelsLike = VisualCrossing.CurrentCondition.Feelslike ?? CurrentWeather.FeelslikeC;

            var percip = CurrentWeather.PrecipMm;

            var windSpeed = VisualCrossing.CurrentCondition.Windspeed ?? CurrentWeather.WindKph;

            var humidity = VisualCrossing.CurrentCondition.Humidity ?? CurrentWeather.Humidity;

            var pressure = VisualCrossing.CurrentCondition.Pressure ?? CurrentWeather.PressureMb;

            var uv = VisualCrossing.CurrentCondition.Uvindex ?? CurrentWeather.Uv;

            Label_FeelLike_Value.Text = feelsLike.ToString() + Unit.TempC;

            Label_Precipitation_Amount_Value.Text = percip.ToString() + Unit.Millimeter;

            Label_Wind_Speed_Value.Text = windSpeed.ToString() + Unit.KmPerH;

            Label_Humidity_Value.Text = humidity.ToString() + Unit.Percent;

            Label_Pressure_Value.Text = pressure.ToString() + Unit.MiliBar;

            Label_UV_Value.Text = uv.ToString();

        }

        public void OnWeatherChange()
        {
            WeatherChange?.Invoke(this, new EventArgs());
        }

        private void ExtractResponse(ResponseCurrentWeatherApi response)
        {
            CurrentWeather = response.CurrentWeather;
            CurrentLocation = response.Location;
            VisualCrossing = response.VisualCrossing;
            OnWeatherChange();
        }

    }
}