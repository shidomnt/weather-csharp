using Newtonsoft.Json;
using System.Diagnostics;
using Weather.Classes;

namespace Weather.Forms
{
    internal partial class FormWeather : Form
    {
        public CurrentWeather? CurrentWeather { get; set; }

        public Location? CurrentLocation { get; set; }

        public event EventHandler? WeatherChange;

        public WeatherController Controller { get; set; }

        public void ExtractResponse(ResponseCurrentWeatherApi response)
        {
            CurrentWeather = response.CurrentWeather;
            CurrentLocation = response.Location;
            OnWeatherChange();
        }

        public void OnWeatherChange()
        {
            WeatherChange?.Invoke(this, new EventArgs());
        }

        public FormWeather()
        {
            InitializeComponent();
            WeatherChange += (sender, e) => LoadWeatherToForm();
            Controller = new();

        }

        private async void FormWeather_Load(object sender, EventArgs e)
        {
            try
            {
                var response = await Controller.GetCurrentWeather("Vietnam");
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


            Label_AQI.Text = "AQI " + CurrentWeather.AirQuality.Pm25.ToString();

            Label_FeelLike_Value.Text = CurrentWeather.FeelslikeC.ToString() + DonVi.TempC;

            Label_Precipitation_Amount_Value.Text = CurrentWeather.PrecipMm.ToString() + DonVi.Millimeter;

            Label_Wind_Speed_Value.Text = CurrentWeather.WindKph.ToString() + DonVi.KmPerH;

            Label_Humidity_Value.Text = CurrentWeather.Humidity.ToString() + DonVi.Percent;

            Label_Pressure_Value.Text = CurrentWeather.PressureMb.ToString() + DonVi.MiliBar;

            Label_UV_Value.Text = CurrentWeather.Uv.ToString();

        }

        private async void Btn_ChangeLocation_Click(object sender, EventArgs e)
        {
            var formCollectLocation = new FormCollectLocation();
            var dialogResult = formCollectLocation.ShowDialog(this);
            if (dialogResult != DialogResult.OK) return;

            try
            {
                if (formCollectLocation.LocationName == string.Empty)
                    throw new Exception("Tên thành phố rỗng");
                var response = await Controller.GetCurrentWeather(formCollectLocation.LocationName);
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

        private async void Btn_Export_Click(object sender, EventArgs e)
        {
            if (CurrentWeather is null || CurrentLocation is null)
            {
                MessageBox.Show("Chọn vị trí cần xem thời tiết trước", "Thông báo");
                return;
            }

            try
            {
                using var folderBrowser = new FolderBrowserDialog();
                var diaLogResult = folderBrowser.ShowDialog(this);
                if (diaLogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    var pathSaved = await Controller.ExportToExcel(
                        CurrentWeather,
                        CurrentLocation,
                        folderBrowser.SelectedPath
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
    }
}