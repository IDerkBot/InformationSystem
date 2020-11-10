namespace InformationSystem
{
    partial class Menu
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
            this.MenuTitle = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.fields = new InformationSystem.Controls.DecaButton();
            this.users = new InformationSystem.Controls.DecaButton();
            this.cultures = new InformationSystem.Controls.DecaButton();
            this.organizationButton = new InformationSystem.Controls.DecaButton();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitle
            // 
            this.MenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.MenuTitle.Location = new System.Drawing.Point(0, 0);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(280, 47);
            this.MenuTitle.TabIndex = 1;
            this.MenuTitle.Text = "Меню";
            this.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuTop
            // 
            this.MenuTop.Controls.Add(this.iconButton1);
            this.MenuTop.Controls.Add(this.MenuTitle);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(280, 47);
            this.MenuTop.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(247, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(30, 28);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fields
            // 
            this.fields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.fields.BorderElementSize = 1;
            this.fields.Fill = true;
            this.fields.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.fields.ForeColor = System.Drawing.Color.White;
            this.fields.Location = new System.Drawing.Point(22, 180);
            this.fields.Name = "fields";
            this.fields.Rounding = 25;
            this.fields.RoundingEnable = true;
            this.fields.Size = new System.Drawing.Size(240, 40);
            this.fields.TabIndex = 0;
            this.fields.Text = "Поля";
            this.fields.Click += new System.EventHandler(this.fields_Click);
            // 
            // users
            // 
            this.users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.users.BorderElementSize = 1;
            this.users.Fill = true;
            this.users.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.users.ForeColor = System.Drawing.Color.White;
            this.users.Location = new System.Drawing.Point(22, 237);
            this.users.Name = "users";
            this.users.Rounding = 25;
            this.users.RoundingEnable = true;
            this.users.Size = new System.Drawing.Size(240, 40);
            this.users.TabIndex = 0;
            this.users.Text = "Пользователи";
            this.users.Visible = false;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // cultures
            // 
            this.cultures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.cultures.BorderElementSize = 1;
            this.cultures.Fill = true;
            this.cultures.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.cultures.ForeColor = System.Drawing.Color.White;
            this.cultures.Location = new System.Drawing.Point(22, 123);
            this.cultures.Name = "cultures";
            this.cultures.Rounding = 25;
            this.cultures.RoundingEnable = true;
            this.cultures.Size = new System.Drawing.Size(240, 40);
            this.cultures.TabIndex = 0;
            this.cultures.Text = "Культуры";
            this.cultures.Click += new System.EventHandler(this.cultures_Click);
            // 
            // organizationButton
            // 
            this.organizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.organizationButton.BorderElementSize = 1;
            this.organizationButton.Fill = true;
            this.organizationButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.organizationButton.ForeColor = System.Drawing.Color.White;
            this.organizationButton.Location = new System.Drawing.Point(22, 65);
            this.organizationButton.Name = "organizationButton";
            this.organizationButton.Rounding = 25;
            this.organizationButton.RoundingEnable = true;
            this.organizationButton.Size = new System.Drawing.Size(240, 40);
            this.organizationButton.TabIndex = 0;
            this.organizationButton.Text = "Организации";
            this.organizationButton.Click += new System.EventHandler(this.organizationButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 304);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.fields);
            this.Controls.Add(this.users);
            this.Controls.Add(this.cultures);
            this.Controls.Add(this.organizationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DecaButton organizationButton;
        private System.Windows.Forms.Panel MenuTop;
        private Controls.DecaButton cultures;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Controls.DecaButton users;
        private Controls.DecaButton fields;
        public System.Windows.Forms.Label MenuTitle;
    }
}