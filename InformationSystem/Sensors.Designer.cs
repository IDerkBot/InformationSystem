namespace InformationSystem
{
    partial class Sensors
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
            this.PanelSensors = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelTemperature = new System.Windows.Forms.Label();
            this.LabelPh = new System.Windows.Forms.Label();
            this.LabelHumidity = new System.Windows.Forms.Label();
            this.LabelPhosphorus = new System.Windows.Forms.Label();
            this.LabelPotasium = new System.Windows.Forms.Label();
            this.LabelMagnesium = new System.Windows.Forms.Label();
            this.LabelCalcium = new System.Windows.Forms.Label();
            this.LabelNitrogen = new System.Windows.Forms.Label();
            this.AddSensor = new InformationSystem.Controls.DecaButton();
            this.decaButton1 = new InformationSystem.Controls.DecaButton();
            this.SuspendLayout();
            // 
            // PanelSensors
            // 
            this.PanelSensors.AutoScroll = true;
            this.PanelSensors.Location = new System.Drawing.Point(12, 117);
            this.PanelSensors.Name = "PanelSensors";
            this.PanelSensors.Size = new System.Drawing.Size(869, 207);
            this.PanelSensors.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(41, 39);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите культуру";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "рожь",
            "ячмень",
            "овес",
            "гречиха",
            "сахарная свекла"});
            this.comboBox1.Location = new System.Drawing.Point(34, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // LabelTemperature
            // 
            this.LabelTemperature.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelTemperature.Location = new System.Drawing.Point(96, 100);
            this.LabelTemperature.Name = "LabelTemperature";
            this.LabelTemperature.Size = new System.Drawing.Size(27, 14);
            this.LabelTemperature.TabIndex = 5;
            this.LabelTemperature.Text = "t,°C";
            // 
            // LabelPh
            // 
            this.LabelPh.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelPh.Location = new System.Drawing.Point(121, 100);
            this.LabelPh.Name = "LabelPh";
            this.LabelPh.Size = new System.Drawing.Size(50, 14);
            this.LabelPh.TabIndex = 5;
            this.LabelPh.Text = "pH";
            this.LabelPh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelHumidity
            // 
            this.LabelHumidity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelHumidity.Location = new System.Drawing.Point(173, 100);
            this.LabelHumidity.Name = "LabelHumidity";
            this.LabelHumidity.Size = new System.Drawing.Size(90, 14);
            this.LabelHumidity.TabIndex = 5;
            this.LabelHumidity.Text = "Влажность, %";
            this.LabelHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPhosphorus
            // 
            this.LabelPhosphorus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelPhosphorus.Location = new System.Drawing.Point(263, 100);
            this.LabelPhosphorus.Name = "LabelPhosphorus";
            this.LabelPhosphorus.Size = new System.Drawing.Size(49, 14);
            this.LabelPhosphorus.TabIndex = 5;
            this.LabelPhosphorus.Text = "Р, мг/кг";
            // 
            // LabelPotasium
            // 
            this.LabelPotasium.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelPotasium.Location = new System.Drawing.Point(308, 100);
            this.LabelPotasium.Name = "LabelPotasium";
            this.LabelPotasium.Size = new System.Drawing.Size(51, 14);
            this.LabelPotasium.TabIndex = 5;
            this.LabelPotasium.Text = "К, мг/кг";
            // 
            // LabelMagnesium
            // 
            this.LabelMagnesium.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelMagnesium.Location = new System.Drawing.Point(357, 100);
            this.LabelMagnesium.Name = "LabelMagnesium";
            this.LabelMagnesium.Size = new System.Drawing.Size(61, 14);
            this.LabelMagnesium.TabIndex = 5;
            this.LabelMagnesium.Text = "Mg, мг/кг";
            // 
            // LabelCalcium
            // 
            this.LabelCalcium.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelCalcium.Location = new System.Drawing.Point(418, 100);
            this.LabelCalcium.Name = "LabelCalcium";
            this.LabelCalcium.Size = new System.Drawing.Size(57, 14);
            this.LabelCalcium.TabIndex = 5;
            this.LabelCalcium.Text = "Ca, мг/кг";
            // 
            // LabelNitrogen
            // 
            this.LabelNitrogen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LabelNitrogen.Location = new System.Drawing.Point(482, 100);
            this.LabelNitrogen.Name = "LabelNitrogen";
            this.LabelNitrogen.Size = new System.Drawing.Size(51, 14);
            this.LabelNitrogen.TabIndex = 5;
            this.LabelNitrogen.Text = "N, мг/кг";
            // 
            // AddSensor
            // 
            this.AddSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.AddSensor.BorderElementSize = 1;
            this.AddSensor.Fill = true;
            this.AddSensor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AddSensor.ForeColor = System.Drawing.Color.White;
            this.AddSensor.Location = new System.Drawing.Point(579, 42);
            this.AddSensor.Name = "AddSensor";
            this.AddSensor.Rounding = 20;
            this.AddSensor.RoundingEnable = true;
            this.AddSensor.Size = new System.Drawing.Size(127, 46);
            this.AddSensor.TabIndex = 4;
            this.AddSensor.Text = "Добавить узел";
            this.AddSensor.Click += new System.EventHandler(this.AddSensor_Click);
            // 
            // decaButton1
            // 
            this.decaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.decaButton1.BorderElementSize = 1;
            this.decaButton1.Fill = true;
            this.decaButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.decaButton1.ForeColor = System.Drawing.Color.White;
            this.decaButton1.Location = new System.Drawing.Point(730, 42);
            this.decaButton1.Name = "decaButton1";
            this.decaButton1.Rounding = 20;
            this.decaButton1.RoundingEnable = true;
            this.decaButton1.Size = new System.Drawing.Size(151, 46);
            this.decaButton1.TabIndex = 4;
            this.decaButton1.Text = "Дать рекомендацию";
            this.decaButton1.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Sensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 340);
            this.Controls.Add(this.LabelNitrogen);
            this.Controls.Add(this.LabelCalcium);
            this.Controls.Add(this.LabelMagnesium);
            this.Controls.Add(this.LabelPotasium);
            this.Controls.Add(this.LabelPhosphorus);
            this.Controls.Add(this.LabelHumidity);
            this.Controls.Add(this.LabelPh);
            this.Controls.Add(this.LabelTemperature);
            this.Controls.Add(this.decaButton1);
            this.Controls.Add(this.AddSensor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.PanelSensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sensors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sensors";
            this.Load += new System.EventHandler(this.Sensors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSensors;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Controls.DecaButton AddSensor;
        private System.Windows.Forms.Label LabelTemperature;
        private System.Windows.Forms.Label LabelPh;
        private System.Windows.Forms.Label LabelHumidity;
        private System.Windows.Forms.Label LabelPhosphorus;
        private System.Windows.Forms.Label LabelPotasium;
        private System.Windows.Forms.Label LabelMagnesium;
        private System.Windows.Forms.Label LabelCalcium;
        private System.Windows.Forms.Label LabelNitrogen;
        private Controls.DecaButton decaButton1;
    }
}