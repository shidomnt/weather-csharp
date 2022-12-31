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

        private /*async*/ void TextBox_ThanhPho_TextChanged(object sender, EventArgs e)
        {
            //if (sender is not TextBox textBox) { return; }
            //if (textBox.Text == string.Empty) { return; }

            //var locations = await WeatherController.GetLocations(textBox.Text);
            //if (locations is null) return;
            //var names = locations
            //    .Select(location => location.Name)
            //    .Distinct()
            //    .ToArray();

            //var nameCollection = new AutoCompleteStringCollection();

            //nameCollection.AddRange(names);

            //textBox.AutoCompleteCustomSource = nameCollection;
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
