namespace InformationSystem
{
    partial class Organization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.decaButton2 = new InformationSystem.Controls.DecaButton();
            this.decaButton1 = new InformationSystem.Controls.DecaButton();
            this.decaGroup5 = new InformationSystem.Controls.DecaGroup();
            this.decaGroup4 = new InformationSystem.Controls.DecaGroup();
            this.decaGroup3 = new InformationSystem.Controls.DecaGroup();
            this.decaGroup2 = new InformationSystem.Controls.DecaGroup();
            this.decaGroup1 = new InformationSystem.Controls.DecaGroup();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор организации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // decaButton2
            // 
            this.decaButton2.BackColor = System.Drawing.Color.LightGreen;
            this.decaButton2.BorderElementSize = 1;
            this.decaButton2.Fill = true;
            this.decaButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decaButton2.ForeColor = System.Drawing.Color.White;
            this.decaButton2.Location = new System.Drawing.Point(195, 329);
            this.decaButton2.Name = "decaButton2";
            this.decaButton2.RoundingEnable = false;
            this.decaButton2.Size = new System.Drawing.Size(100, 30);
            this.decaButton2.TabIndex = 13;
            this.decaButton2.Text = "Далее";
            this.decaButton2.Click += new System.EventHandler(this.decaButton2_Click);
            // 
            // decaButton1
            // 
            this.decaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.decaButton1.BorderElementSize = 2;
            this.decaButton1.Fill = false;
            this.decaButton1.Location = new System.Drawing.Point(8, 329);
            this.decaButton1.Name = "decaButton1";
            this.decaButton1.Rounding = 50;
            this.decaButton1.RoundingEnable = true;
            this.decaButton1.Size = new System.Drawing.Size(100, 30);
            this.decaButton1.TabIndex = 12;
            this.decaButton1.Text = "Добавить";
            this.decaButton1.Visible = false;
            this.decaButton1.Click += new System.EventHandler(this.decaButton1_Click);
            // 
            // decaGroup5
            // 
            this.decaGroup5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decaGroup5.BorderElementSize = 1;
            this.decaGroup5.FontLabelGroup = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.decaGroup5.FontTextGroup = new System.Drawing.Font("Arial", 8F);
            this.decaGroup5.ForeColorLabelGroup = System.Drawing.Color.Black;
            this.decaGroup5.ForeColorTextGroup = System.Drawing.Color.Black;
            this.decaGroup5.LabelGroup = "Тип почвы:";
            this.decaGroup5.Location = new System.Drawing.Point(8, 284);
            this.decaGroup5.Name = "decaGroup5";
            this.decaGroup5.RoundingEnable = false;
            this.decaGroup5.Size = new System.Drawing.Size(292, 39);
            this.decaGroup5.TabIndex = 11;
            this.decaGroup5.Text = "None select";
            this.decaGroup5.TextGroup = "None select";
            // 
            // decaGroup4
            // 
            this.decaGroup4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decaGroup4.BorderElementSize = 1;
            this.decaGroup4.FontLabelGroup = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.decaGroup4.FontTextGroup = new System.Drawing.Font("Arial", 8F);
            this.decaGroup4.ForeColorLabelGroup = System.Drawing.Color.Black;
            this.decaGroup4.ForeColorTextGroup = System.Drawing.Color.Black;
            this.decaGroup4.LabelGroup = "Площадь:";
            this.decaGroup4.Location = new System.Drawing.Point(8, 239);
            this.decaGroup4.Name = "decaGroup4";
            this.decaGroup4.RoundingEnable = false;
            this.decaGroup4.Size = new System.Drawing.Size(292, 39);
            this.decaGroup4.TabIndex = 11;
            this.decaGroup4.Text = "None select";
            this.decaGroup4.TextGroup = "None select";
            // 
            // decaGroup3
            // 
            this.decaGroup3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decaGroup3.BorderElementSize = 1;
            this.decaGroup3.FontLabelGroup = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.decaGroup3.FontTextGroup = new System.Drawing.Font("Arial", 8F);
            this.decaGroup3.ForeColorLabelGroup = System.Drawing.Color.Black;
            this.decaGroup3.ForeColorTextGroup = System.Drawing.Color.Black;
            this.decaGroup3.LabelGroup = "Адрес:";
            this.decaGroup3.Location = new System.Drawing.Point(8, 194);
            this.decaGroup3.Name = "decaGroup3";
            this.decaGroup3.RoundingEnable = false;
            this.decaGroup3.Size = new System.Drawing.Size(292, 39);
            this.decaGroup3.TabIndex = 11;
            this.decaGroup3.Text = "None select";
            this.decaGroup3.TextGroup = "None select";
            // 
            // decaGroup2
            // 
            this.decaGroup2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decaGroup2.BorderElementSize = 1;
            this.decaGroup2.FontLabelGroup = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.decaGroup2.FontTextGroup = new System.Drawing.Font("Arial", 8F);
            this.decaGroup2.ForeColorLabelGroup = System.Drawing.Color.Black;
            this.decaGroup2.ForeColorTextGroup = System.Drawing.Color.Black;
            this.decaGroup2.LabelGroup = "Местоположение:";
            this.decaGroup2.Location = new System.Drawing.Point(8, 149);
            this.decaGroup2.Name = "decaGroup2";
            this.decaGroup2.RoundingEnable = false;
            this.decaGroup2.Size = new System.Drawing.Size(292, 39);
            this.decaGroup2.TabIndex = 11;
            this.decaGroup2.Text = "None select";
            this.decaGroup2.TextGroup = "None select";
            // 
            // decaGroup1
            // 
            this.decaGroup1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.decaGroup1.BorderElementSize = 1;
            this.decaGroup1.FontLabelGroup = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.decaGroup1.FontTextGroup = new System.Drawing.Font("Arial", 8F);
            this.decaGroup1.ForeColorLabelGroup = System.Drawing.Color.Black;
            this.decaGroup1.ForeColorTextGroup = System.Drawing.Color.Black;
            this.decaGroup1.LabelGroup = "Кадастровый номер:";
            this.decaGroup1.Location = new System.Drawing.Point(8, 104);
            this.decaGroup1.Name = "decaGroup1";
            this.decaGroup1.RoundingEnable = false;
            this.decaGroup1.Size = new System.Drawing.Size(292, 39);
            this.decaGroup1.TabIndex = 11;
            this.decaGroup1.Text = "None select";
            this.decaGroup1.TextGroup = "None select";
            this.decaGroup1.TextChanged += new System.EventHandler(this.decaGroup1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(279, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(25, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Organization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 383);
            this.Controls.Add(this.decaButton2);
            this.Controls.Add(this.decaButton1);
            this.Controls.Add(this.decaGroup5);
            this.Controls.Add(this.decaGroup4);
            this.Controls.Add(this.decaGroup3);
            this.Controls.Add(this.decaGroup2);
            this.Controls.Add(this.decaGroup1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Organization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizationSelect";
            this.Load += new System.EventHandler(this.Organization_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Controls.DecaGroup decaGroup1;
        private Controls.DecaGroup decaGroup2;
        private Controls.DecaGroup decaGroup3;
        private Controls.DecaGroup decaGroup4;
        private Controls.DecaGroup decaGroup5;
        private Controls.DecaButton decaButton1;
        private Controls.DecaButton decaButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}