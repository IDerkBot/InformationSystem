namespace InformationSystem
{
    partial class Map
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
            FontAwesome.Sharp.IconButton iconButton2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButton2
            // 
            iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Expand;
            iconButton2.IconColor = System.Drawing.Color.Black;
            iconButton2.IconSize = 28;
            iconButton2.Location = new System.Drawing.Point(717, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Rotation = 0D;
            iconButton2.Size = new System.Drawing.Size(40, 28);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 28);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(760, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(40, 28);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 422);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.gMapControl1);
            this.panel3.Location = new System.Drawing.Point(12, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 404);
            this.panel3.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(42, 22);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(703, 361);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}