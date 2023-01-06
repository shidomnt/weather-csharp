namespace Weather.Forms
{
    public partial class FormCollectLocation : Form
    {
        public string LocationName { get; set; }

        public FormCollectLocation()
        {
            InitializeComponent();
            LocationName = string.Empty;
        }

        private void FormCollectLocation_Load(object sender, EventArgs e)
        {
            TextBox_ThanhPho.AutoCompleteCustomSource = new();
        }

        private async void TextBox_ThanhPho_TextChanged(object sender, EventArgs e)
        {
            //if (sender is not TextBox textBox) { return; }
            //if (textBox.Text == string.Empty) { return; }

            //if (textBox.Text.Length != 3) { return; }

            //var controller = new WeatherController();

            //var locations = await controller.GetLocations(textBox.Text);
            //if (locations is null) return;
            //var names = locations
            //    .Select(location => location.Name)
            //    .Distinct()
            //    .ToArray();

            //textBox.AutoCompleteCustomSource.Clear();

            //textBox.AutoCompleteCustomSource.AddRange(names);

        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            LocationName = TextBox_ThanhPho.Text;
        }

        private void TextBox_ThanhPho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_XacNhan.PerformClick();
            }
        }

    }
}
