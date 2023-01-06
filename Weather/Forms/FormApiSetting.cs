using Weather.Classes;

namespace Weather.Forms
{
    internal partial class FormApiSetting : Form
    {
        internal FormApiSetting()
        {
            InitializeComponent();

            Configuration = AppConfiguration.Get();

        }

        public Configuration Configuration { get; set; }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            TextBox_ApiKey.Text = Configuration.WeatherClient.ApiKey;
            TextBox_BaseApiUrl.Text = Configuration.WeatherClient.WeatherApiURL;
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            Configuration.WeatherClient.ApiKey = TextBox_ApiKey.Text;
            Configuration.WeatherClient.WeatherApiURL = TextBox_BaseApiUrl.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
