using Newtonsoft.Json;
using System.Diagnostics;
using Weather.Classes;
using Weather.Constants;

namespace Weather.Forms
{
    internal partial class FormWeather : Form
    {
        public CurrentWeather? CurrentWeather { get; set; }

        public CurrentLocation? CurrentLocation { get; set; }

        public event EventHandler? WeatherChange;

        public WeatherController Controller { get; set; }

        public FormWeather()
        {
            InitializeComponent();
            Controller = new();
            WeatherChange += (sender, e) => LoadWeatherToForm();

        }

        private async void FormWeather_Load(object sender, EventArgs e)
        {
            await GetCurrentWeather("hanoi");
        }

        private async void Btn_ChangeLocation_Click(object sender, EventArgs e)
        {
            var formCollectLocation = new FormCollectLocation();
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
        private void LoadWeatherToForm()
        {
            if (CurrentWeather is null || CurrentLocation is null) return;

            Label_Location.Text = CurrentLocation.Name;
            Label_Temperature.Text = CurrentWeather.TempC.ToString() + DonVi.TempC;

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

            var maxAirQualityDesc = FormAQI.CalculateAQI(CurrentWeather);

            Label_AQI.Text = $"{maxAirQualityDesc.Emoji} AQI {maxAirQualityDesc.Value}";

            Label_FeelLike_Value.Text = CurrentWeather.FeelslikeC.ToString() + DonVi.TempC;

            Label_Precipitation_Amount_Value.Text = CurrentWeather.PrecipMm.ToString() + DonVi.Millimeter;

            Label_Wind_Speed_Value.Text = CurrentWeather.WindKph.ToString() + DonVi.KmPerH;

            Label_Humidity_Value.Text = CurrentWeather.Humidity.ToString() + DonVi.Percent;

            Label_Pressure_Value.Text = CurrentWeather.PressureMb.ToString() + DonVi.MiliBar;

            Label_UV_Value.Text = CurrentWeather.Uv.ToString();

        }
        private void Label_AQI_Click(object sender, EventArgs e)
        {
            if (CurrentLocation is null || CurrentWeather is null) return;
            var formAQI = new FormAQI(CurrentLocation, CurrentWeather);
            formAQI.ShowDialog();

        }

        public void OnWeatherChange()
        {
            WeatherChange?.Invoke(this, new EventArgs());
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
                    var pathSaved = await Controller.ExportToExcel(
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

        private async Task GetCurrentWeather(string locationName)
        {
            try
            {
                var response = await Controller.GetCurrentWeather(locationName);
                if (response is not null)
                {
                    ExtractResponse(response);
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

        public void ExtractResponse(ResponseCurrentWeatherApi response)
        {
            CurrentWeather = response.CurrentWeather;
            CurrentLocation = response.Location;
            OnWeatherChange();
        }

    }
}