using Weather.Constants;
using Weather.Helpers;

namespace Weather.Classes
{
    internal class AirQualityDescription
    {
        public QualityType Quality { get; }

        public PollutantGas Gas { get; }

        public int Value { get; }

        public Color Color { get; }

        public string Emoji { get; }

        //concentration: nong do μg/m3
        public AirQualityDescription(float concentration, PollutantGas gas)
        {
            Gas = gas;
            Value = AQIHelper.CalculateAQI(concentration, gas);
            if (Value >= 0 && Value < 20)
            {
                Quality = QualityType.Good;
                Color = Color.FromArgb(0, 229, 155);
                Emoji = "😍";
            }
            else if (Value >= 20 && Value < 50)
            {
                Quality = QualityType.Moderate;
                Color = Color.FromArgb(255, 195, 2);
                Emoji = "🙁";
            }
            else if (Value >= 50 && Value < 100)
            {
                Quality = QualityType.UnhealthyForSensitiveGroup;
                Color = Color.FromArgb(255, 113, 43);
                Emoji = "😧";
            }
            else if (Value >= 100 && Value < 150)
            {
                Quality = QualityType.Unhealthy;
                Color = Color.FromArgb(246, 42, 85);
                Emoji = "😣";
            }
            else if (Value >= 150 && Value < 250)
            {
                Quality = QualityType.VeryUnhealthy;
                Color = Color.FromArgb(199, 46, 170);
                Emoji = "😥";
            }
            else
            {
                Quality = QualityType.Hazardous;
                Color = Color.FromArgb(153, 48, 255);
                Emoji = "😱";
            }
        }

    }

}
