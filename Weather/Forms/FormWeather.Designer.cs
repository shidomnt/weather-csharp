namespace Weather.Forms
{
    partial class FormWeather
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ChangeLocation = new System.Windows.Forms.Button();
            this.Label_Location = new System.Windows.Forms.Label();
            this.Btn_Export = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_WeatherCondition = new System.Windows.Forms.Label();
            this.Label_Temperature = new System.Windows.Forms.Label();
            this.Label_AQI = new System.Windows.Forms.Label();
            this.PicBox_WeatherCondition = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_UV = new System.Windows.Forms.Label();
            this.Label_UV_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Wind_Speed = new System.Windows.Forms.Label();
            this.Label_Wind_Speed_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Pressure = new System.Windows.Forms.Label();
            this.Label_Pressure_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Precipitation_Amount = new System.Windows.Forms.Label();
            this.Label_Precipitation_Amount_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Humidity = new System.Windows.Forms.Label();
            this.Label_Humidity_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_FeelLike = new System.Windows.Forms.Label();
            this.Label_FeelLike_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_WeatherCondition)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_ChangeLocation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_Location, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Export, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Btn_ChangeLocation
            // 
            this.Btn_ChangeLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ChangeLocation.Location = new System.Drawing.Point(3, 3);
            this.Btn_ChangeLocation.Name = "Btn_ChangeLocation";
            this.Btn_ChangeLocation.Size = new System.Drawing.Size(65, 27);
            this.Btn_ChangeLocation.TabIndex = 0;
            this.Btn_ChangeLocation.Text = "Change";
            this.Btn_ChangeLocation.UseVisualStyleBackColor = true;
            this.Btn_ChangeLocation.Click += new System.EventHandler(this.Btn_ChangeLocation_Click);
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Location.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Location.Location = new System.Drawing.Point(74, 0);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(207, 47);
            this.Label_Location.TabIndex = 1;
            this.Label_Location.Text = "Location";
            this.Label_Location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Export
            // 
            this.Btn_Export.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Export.Location = new System.Drawing.Point(287, 3);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(66, 23);
            this.Btn_Export.TabIndex = 2;
            this.Btn_Export.Text = "Export";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Label_WeatherCondition, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Label_Temperature, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Label_AQI, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.PicBox_WeatherCondition, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 259);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Label_WeatherCondition
            // 
            this.Label_WeatherCondition.AutoSize = true;
            this.Label_WeatherCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_WeatherCondition.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_WeatherCondition.Location = new System.Drawing.Point(3, 147);
            this.Label_WeatherCondition.Name = "Label_WeatherCondition";
            this.Label_WeatherCondition.Size = new System.Drawing.Size(350, 51);
            this.Label_WeatherCondition.TabIndex = 2;
            this.Label_WeatherCondition.Text = "WeatherCondition";
            this.Label_WeatherCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Temperature
            // 
            this.Label_Temperature.AutoSize = true;
            this.Label_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Temperature.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Temperature.Location = new System.Drawing.Point(3, 6);
            this.Label_Temperature.Name = "Label_Temperature";
            this.Label_Temperature.Size = new System.Drawing.Size(350, 77);
            this.Label_Temperature.TabIndex = 0;
            this.Label_Temperature.Text = "Temperature";
            this.Label_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_AQI
            // 
            this.Label_AQI.AutoSize = true;
            this.Label_AQI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_AQI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_AQI.Location = new System.Drawing.Point(3, 198);
            this.Label_AQI.Name = "Label_AQI";
            this.Label_AQI.Size = new System.Drawing.Size(350, 38);
            this.Label_AQI.TabIndex = 2;
            this.Label_AQI.Text = "AQI";
            this.Label_AQI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBox_WeatherCondition
            // 
            this.PicBox_WeatherCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_WeatherCondition.Location = new System.Drawing.Point(3, 86);
            this.PicBox_WeatherCondition.Name = "PicBox_WeatherCondition";
            this.PicBox_WeatherCondition.Size = new System.Drawing.Size(350, 58);
            this.PicBox_WeatherCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBox_WeatherCondition.TabIndex = 3;
            this.PicBox_WeatherCondition.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 321);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(356, 206);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.Label_UV, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.Label_UV_Value, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(181, 139);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(172, 64);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // Label_UV
            // 
            this.Label_UV.AutoSize = true;
            this.Label_UV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_UV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_UV.Location = new System.Drawing.Point(3, 0);
            this.Label_UV.Name = "Label_UV";
            this.Label_UV.Size = new System.Drawing.Size(166, 32);
            this.Label_UV.TabIndex = 0;
            this.Label_UV.Text = "UV";
            this.Label_UV.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_UV_Value
            // 
            this.Label_UV_Value.AutoSize = true;
            this.Label_UV_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_UV_Value.Location = new System.Drawing.Point(3, 32);
            this.Label_UV_Value.Name = "Label_UV_Value";
            this.Label_UV_Value.Size = new System.Drawing.Size(31, 21);
            this.Label_UV_Value.TabIndex = 1;
            this.Label_UV_Value.Text = "UV";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.Label_Wind_Speed, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.Label_Wind_Speed_Value, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(172, 64);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // Label_Wind_Speed
            // 
            this.Label_Wind_Speed.AutoSize = true;
            this.Label_Wind_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Wind_Speed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Wind_Speed.Location = new System.Drawing.Point(3, 0);
            this.Label_Wind_Speed.Name = "Label_Wind_Speed";
            this.Label_Wind_Speed.Size = new System.Drawing.Size(166, 32);
            this.Label_Wind_Speed.TabIndex = 0;
            this.Label_Wind_Speed.Text = "Tốc độ gió";
            this.Label_Wind_Speed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Wind_Speed_Value
            // 
            this.Label_Wind_Speed_Value.AutoSize = true;
            this.Label_Wind_Speed_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Wind_Speed_Value.Location = new System.Drawing.Point(3, 32);
            this.Label_Wind_Speed_Value.Name = "Label_Wind_Speed_Value";
            this.Label_Wind_Speed_Value.Size = new System.Drawing.Size(92, 21);
            this.Label_Wind_Speed_Value.TabIndex = 1;
            this.Label_Wind_Speed_Value.Text = "Wind speed";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.Label_Pressure, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.Label_Pressure_Value, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(181, 71);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(172, 62);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // Label_Pressure
            // 
            this.Label_Pressure.AutoSize = true;
            this.Label_Pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Pressure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pressure.Location = new System.Drawing.Point(3, 0);
            this.Label_Pressure.Name = "Label_Pressure";
            this.Label_Pressure.Size = new System.Drawing.Size(166, 31);
            this.Label_Pressure.TabIndex = 0;
            this.Label_Pressure.Text = "Áp suất";
            this.Label_Pressure.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Pressure_Value
            // 
            this.Label_Pressure_Value.AutoSize = true;
            this.Label_Pressure_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pressure_Value.Location = new System.Drawing.Point(3, 31);
            this.Label_Pressure_Value.Name = "Label_Pressure_Value";
            this.Label_Pressure_Value.Size = new System.Drawing.Size(70, 21);
            this.Label_Pressure_Value.TabIndex = 1;
            this.Label_Pressure_Value.Text = "Pressure";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.Label_Precipitation_Amount, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Label_Precipitation_Amount_Value, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(172, 62);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // Label_Precipitation_Amount
            // 
            this.Label_Precipitation_Amount.AutoSize = true;
            this.Label_Precipitation_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Precipitation_Amount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Precipitation_Amount.Location = new System.Drawing.Point(3, 0);
            this.Label_Precipitation_Amount.Name = "Label_Precipitation_Amount";
            this.Label_Precipitation_Amount.Size = new System.Drawing.Size(166, 31);
            this.Label_Precipitation_Amount.TabIndex = 0;
            this.Label_Precipitation_Amount.Text = "Lượng mưa";
            this.Label_Precipitation_Amount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Precipitation_Amount_Value
            // 
            this.Label_Precipitation_Amount_Value.AutoSize = true;
            this.Label_Precipitation_Amount_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Precipitation_Amount_Value.Location = new System.Drawing.Point(3, 31);
            this.Label_Precipitation_Amount_Value.Name = "Label_Precipitation_Amount_Value";
            this.Label_Precipitation_Amount_Value.Size = new System.Drawing.Size(155, 21);
            this.Label_Precipitation_Amount_Value.TabIndex = 1;
            this.Label_Precipitation_Amount_Value.Text = "Precipitation amount";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.Label_Humidity, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Label_Humidity_Value, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(181, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(172, 62);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // Label_Humidity
            // 
            this.Label_Humidity.AutoSize = true;
            this.Label_Humidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Humidity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Humidity.Location = new System.Drawing.Point(3, 0);
            this.Label_Humidity.Name = "Label_Humidity";
            this.Label_Humidity.Size = new System.Drawing.Size(166, 31);
            this.Label_Humidity.TabIndex = 0;
            this.Label_Humidity.Text = "Độ ẩm";
            this.Label_Humidity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Humidity_Value
            // 
            this.Label_Humidity_Value.AutoSize = true;
            this.Label_Humidity_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Humidity_Value.Location = new System.Drawing.Point(3, 31);
            this.Label_Humidity_Value.Name = "Label_Humidity_Value";
            this.Label_Humidity_Value.Size = new System.Drawing.Size(74, 21);
            this.Label_Humidity_Value.TabIndex = 1;
            this.Label_Humidity_Value.Text = "Humidity";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.Label_FeelLike, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Label_FeelLike_Value, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(172, 62);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Label_FeelLike
            // 
            this.Label_FeelLike.AutoSize = true;
            this.Label_FeelLike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_FeelLike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_FeelLike.Location = new System.Drawing.Point(3, 0);
            this.Label_FeelLike.Name = "Label_FeelLike";
            this.Label_FeelLike.Size = new System.Drawing.Size(166, 31);
            this.Label_FeelLike.TabIndex = 0;
            this.Label_FeelLike.Text = "Cảm giác như";
            this.Label_FeelLike.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_FeelLike_Value
            // 
            this.Label_FeelLike_Value.AutoSize = true;
            this.Label_FeelLike_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_FeelLike_Value.Location = new System.Drawing.Point(3, 31);
            this.Label_FeelLike_Value.Name = "Label_FeelLike_Value";
            this.Label_FeelLike_Value.Size = new System.Drawing.Size(66, 21);
            this.Label_FeelLike_Value.TabIndex = 1;
            this.Label_FeelLike_Value.Text = "FeelLike";
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormWeather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.FormWeather_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_WeatherCondition)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Btn_ChangeLocation;
        private Label Label_Location;
        private TableLayoutPanel tableLayoutPanel3;
        private Label Label_Temperature;
        private Label Label_AQI;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel10;
        private Label Label_UV;
        private Label Label_UV_Value;
        private TableLayoutPanel tableLayoutPanel9;
        private Label Label_Wind_Speed;
        private Label Label_Wind_Speed_Value;
        private TableLayoutPanel tableLayoutPanel8;
        private Label Label_Pressure;
        private Label Label_Pressure_Value;
        private TableLayoutPanel tableLayoutPanel7;
        private Label Label_Precipitation_Amount;
        private Label Label_Precipitation_Amount_Value;
        private TableLayoutPanel tableLayoutPanel6;
        private Label Label_Humidity;
        private Label Label_Humidity_Value;
        private TableLayoutPanel tableLayoutPanel5;
        private Label Label_FeelLike;
        private Label Label_FeelLike_Value;
        private Button Btn_Export;
        private Label Label_WeatherCondition;
        private PictureBox PicBox_WeatherCondition;
    }
}