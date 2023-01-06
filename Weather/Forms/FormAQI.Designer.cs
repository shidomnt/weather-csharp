namespace Weather.Forms
{
    partial class FormAQI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_TitleDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_AirQuality_Title = new System.Windows.Forms.Label();
            this.Label_AirQuality_Description = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.Label_Co_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Label_O3_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.Label_No2_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.Label_So2_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.Label_Pm10_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Pm25_Value = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_TitleDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 212);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉ số chất lượng không khí";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TitleDescription
            // 
            this.Label_TitleDescription.AutoSize = true;
            this.Label_TitleDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TitleDescription.ForeColor = System.Drawing.Color.White;
            this.Label_TitleDescription.Location = new System.Drawing.Point(3, 60);
            this.Label_TitleDescription.Name = "Label_TitleDescription";
            this.Label_TitleDescription.Size = new System.Drawing.Size(417, 30);
            this.Label_TitleDescription.TabIndex = 1;
            this.Label_TitleDescription.Text = "LocationName lúc x giờ";
            this.Label_TitleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Label_AirQuality_Title, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_AirQuality_Description, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Label_AirQuality_Title
            // 
            this.Label_AirQuality_Title.AutoSize = true;
            this.Label_AirQuality_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_AirQuality_Title.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_AirQuality_Title.ForeColor = System.Drawing.Color.White;
            this.Label_AirQuality_Title.Location = new System.Drawing.Point(3, 0);
            this.Label_AirQuality_Title.Name = "Label_AirQuality_Title";
            this.Label_AirQuality_Title.Size = new System.Drawing.Size(50, 54);
            this.Label_AirQuality_Title.TabIndex = 0;
            this.Label_AirQuality_Title.Text = "0";
            this.Label_AirQuality_Title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_AirQuality_Description
            // 
            this.Label_AirQuality_Description.AutoSize = true;
            this.Label_AirQuality_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_AirQuality_Description.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_AirQuality_Description.ForeColor = System.Drawing.Color.White;
            this.Label_AirQuality_Description.Location = new System.Drawing.Point(59, 0);
            this.Label_AirQuality_Description.Name = "Label_AirQuality_Description";
            this.Label_AirQuality_Description.Size = new System.Drawing.Size(355, 54);
            this.Label_AirQuality_Description.TabIndex = 1;
            this.Label_AirQuality_Description.Text = "Chất lượng";
            this.Label_AirQuality_Description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 56);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.Label_Co_Value, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(348, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(66, 50);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "CO";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Co_Value
            // 
            this.Label_Co_Value.AutoSize = true;
            this.Label_Co_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Co_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Co_Value.ForeColor = System.Drawing.Color.White;
            this.Label_Co_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_Co_Value.Name = "Label_Co_Value";
            this.Label_Co_Value.Size = new System.Drawing.Size(60, 25);
            this.Label_Co_Value.TabIndex = 1;
            this.Label_Co_Value.Text = "0";
            this.Label_Co_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.Label_O3_Value, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(279, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(63, 50);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "O₃";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_O3_Value
            // 
            this.Label_O3_Value.AutoSize = true;
            this.Label_O3_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_O3_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_O3_Value.ForeColor = System.Drawing.Color.White;
            this.Label_O3_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_O3_Value.Name = "Label_O3_Value";
            this.Label_O3_Value.Size = new System.Drawing.Size(57, 25);
            this.Label_O3_Value.TabIndex = 1;
            this.Label_O3_Value.Text = "0";
            this.Label_O3_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.Label_No2_Value, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(210, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(63, 50);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "NO₂";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_No2_Value
            // 
            this.Label_No2_Value.AutoSize = true;
            this.Label_No2_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_No2_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_No2_Value.ForeColor = System.Drawing.Color.White;
            this.Label_No2_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_No2_Value.Name = "Label_No2_Value";
            this.Label_No2_Value.Size = new System.Drawing.Size(57, 25);
            this.Label_No2_Value.TabIndex = 1;
            this.Label_No2_Value.Text = "0";
            this.Label_No2_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.Label_So2_Value, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(141, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(63, 50);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "SO₂";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_So2_Value
            // 
            this.Label_So2_Value.AutoSize = true;
            this.Label_So2_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_So2_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_So2_Value.ForeColor = System.Drawing.Color.White;
            this.Label_So2_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_So2_Value.Name = "Label_So2_Value";
            this.Label_So2_Value.Size = new System.Drawing.Size(57, 25);
            this.Label_So2_Value.TabIndex = 1;
            this.Label_So2_Value.Text = "0";
            this.Label_So2_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Label_Pm10_Value, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(72, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(63, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "PM10";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Pm10_Value
            // 
            this.Label_Pm10_Value.AutoSize = true;
            this.Label_Pm10_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Pm10_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pm10_Value.ForeColor = System.Drawing.Color.White;
            this.Label_Pm10_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_Pm10_Value.Name = "Label_Pm10_Value";
            this.Label_Pm10_Value.Size = new System.Drawing.Size(57, 25);
            this.Label_Pm10_Value.TabIndex = 1;
            this.Label_Pm10_Value.Text = "0";
            this.Label_Pm10_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Label_Pm25_Value, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(63, 50);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "PM2.5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Pm25_Value
            // 
            this.Label_Pm25_Value.AutoSize = true;
            this.Label_Pm25_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Pm25_Value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Pm25_Value.ForeColor = System.Drawing.Color.White;
            this.Label_Pm25_Value.Location = new System.Drawing.Point(3, 0);
            this.Label_Pm25_Value.Name = "Label_Pm25_Value";
            this.Label_Pm25_Value.Size = new System.Drawing.Size(57, 25);
            this.Label_Pm25_Value.TabIndex = 1;
            this.Label_Pm25_Value.Text = "0";
            this.Label_Pm25_Value.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormAQI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(423, 212);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormAQI";
            this.Text = "Chất lượng không khí";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label Label_TitleDescription;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Label_AirQuality_Title;
        private Label Label_AirQuality_Description;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label15;
        private Label Label_Co_Value;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label13;
        private Label Label_O3_Value;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label11;
        private Label Label_No2_Value;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label9;
        private Label Label_So2_Value;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
        private Label Label_Pm10_Value;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private Label Label_Pm25_Value;
    }
}