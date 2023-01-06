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

        public string Advise { get; }

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
                Advise = "Chất lượng không khí lý tưởng. Hãy tận hưởng các hoạt động ngoài trời bình thường.";
            }
            else if (Value >= 20 && Value < 50)
            {
                Quality = QualityType.Moderate;
                Color = Color.FromArgb(255, 195, 2);
                Emoji = "🙁";
                Advise = "Không khí bị ô nhiễm vừa. Có thể gây hại cho các nhóm nhạy cảm.";
            }
            else if (Value >= 50 && Value < 100)
            {
                Quality = QualityType.UnhealthyForSensitiveGroup;
                Color = Color.FromArgb(255, 113, 43);
                Emoji = "😧";
                Advise = "Không khí đã đạt mức ô nhiễm cao và không phù hợp với các nhóm đối tượng nhạy cảm.";
            }
            else if (Value >= 100 && Value < 150)
            {
                Quality = QualityType.Unhealthy;
                Color = Color.FromArgb(246, 42, 85);
                Emoji = "😥";
                Advise = "Hãy giới hạn hoạt động ngoài trời.";
            }
            else if (Value >= 150 && Value < 250)
            {
                Quality = QualityType.VeryUnhealthy;
                Color = Color.FromArgb(199, 46, 170);
                Emoji = "😣";
                Advise = "Hãy cân nhắc việc ở trong nhà và dời lịch cho các hoạt động ngoài trời.";
            }
            else
            {
                Quality = QualityType.Hazardous;
                Color = Color.FromArgb(153, 48, 255);
                Emoji = "😱";
                Advise = "Mọi tiếp xúc với không khí, dù chỉ vài phút, cũng có thể dẫn đến tác động nghiêm trọng đến sức khỏe đối với mọi đối tượng. Hãy tránh các hoạt động ngoài trời.";
            }
        }

    }

}
