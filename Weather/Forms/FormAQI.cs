using Weather.Classes;
using Weather.Classes.Serialization;
using Weather.Constants;
using Weather.Helpers;

namespace Weather.Forms
{
    internal partial class FormAQI : Form
    {

        public CurrentLocation CurrentLocation { get; set; }

        public CurrentWeather CurrentWeather { get; set; }

        public int AQIValue { get; set; }

        internal FormAQI(CurrentLocation location, CurrentWeather currentWeather)
        {
            InitializeComponent();
            this.CurrentLocation = location;
            this.CurrentWeather = currentWeather;
            ExtractToForm(CurrentLocation, CurrentWeather);
        }

        private void ExtractToForm(CurrentLocation location, CurrentWeather currentWeather)
        {
            Label_TitleDescription.Text = $"{location.Name} lúc {location.LocalTime.ToShortTimeString()}";

            var currentAirQuality = currentWeather.AirQuality;

            var pm25Desc = new AirQualityDescription(currentAirQuality.Pm25, PollutantGas.Pm25);
            var pm10Desc = new AirQualityDescription(currentAirQuality.Pm10, PollutantGas.Pm10);
            var so2Desc = new AirQualityDescription(currentAirQuality.So2, PollutantGas.So2);
            var no2Desc = new AirQualityDescription(currentAirQuality.No2, PollutantGas.No2);
            var coDesc = new AirQualityDescription(currentAirQuality.Co, PollutantGas.Co);
            var o3Desc = new AirQualityDescription(currentAirQuality.O3, PollutantGas.O3);

            var maxDesc = AQIHelper.CalculateTotalAQI(currentWeather.AirQuality);

            AQIValue = maxDesc.Value;

            Label_AirQuality_Title.Text = maxDesc.Value.ToString();
            Label_AirQuality_Title.ForeColor = maxDesc.Color;

            Label_AirQuality_Description.Text = maxDesc.Quality switch
            {
                QualityType.Good => "Trong lành",
                QualityType.Moderate => "Vừa phải",
                QualityType.UnhealthyForSensitiveGroup => "Xấu",
                QualityType.Unhealthy => "Có hại",
                QualityType.VeryUnhealthy => "Rất có hại",
                _ => "Nguy hiểm"
            };
            Label_AirQuality_Description.ForeColor = maxDesc.Color;

            Label_Pm10_Value.Text = pm10Desc.Value.ToString();
            Label_Pm10_Value.ForeColor = pm10Desc.Color;

            Label_Pm25_Value.Text = pm25Desc.Value.ToString();
            Label_Pm25_Value.ForeColor = pm25Desc.Color;

            Label_So2_Value.Text = so2Desc.Value.ToString();
            Label_So2_Value.ForeColor = so2Desc.Color;

            Label_No2_Value.Text = no2Desc.Value.ToString();
            Label_No2_Value.ForeColor = no2Desc.Color;

            Label_O3_Value.Text = o3Desc.Value.ToString();
            Label_O3_Value.ForeColor = o3Desc.Color;

            Label_Co_Value.Text = coDesc.Value.ToString();
            Label_Co_Value.ForeColor = coDesc.Color;

        }

    }
}
