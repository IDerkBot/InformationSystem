namespace InformationSystem
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLabel = new System.Windows.Forms.Panel();
            this.resize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.panelFields = new System.Windows.Forms.Panel();
            this.showPass = new FontAwesome.Sharp.IconButton();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.LoginText = new InformationSystem.Controls.DecaTextBox();
            this.LogInButton = new InformationSystem.Controls.DecaButton();
            this.PasswordText = new InformationSystem.Controls.DecaTextBox();
            this.panelLabel.SuspendLayout();
            this.panelFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.resize);
            this.panelLabel.Controls.Add(this.close);
            this.panelLabel.Controls.Add(this.AuthLabel);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Location = new System.Drawing.Point(0, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(346, 38);
            this.panelLabel.TabIndex = 0;
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resize.FlatAppearance.BorderSize = 0;
            this.resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.resize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.resize.IconColor = System.Drawing.Color.Black;
            this.resize.IconSize = 28;
            this.resize.Location = new System.Drawing.Point(277, 3);
            this.resize.Name = "resize";
            this.resize.Rotation = 0D;
            this.resize.Size = new System.Drawing.Size(30, 28);
            this.resize.TabIndex = 1;
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.close.IconColor = System.Drawing.Color.Black;
            this.close.IconSize = 28;
            this.close.Location = new System.Drawing.Point(313, 3);
            this.close.Name = "close";
            this.close.Rotation = 0D;
            this.close.Size = new System.Drawing.Size(30, 28);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AuthLabel
            // 
            this.AuthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AuthLabel.Location = new System.Drawing.Point(0, 0);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(346, 38);
            this.AuthLabel.TabIndex = 0;
            this.AuthLabel.Text = "Авторизация";
            this.AuthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFields
            // 
            this.panelFields.Controls.Add(this.showPass);
            this.panelFields.Controls.Add(this.userIcon);
            this.panelFields.Controls.Add(this.LoginText);
            this.panelFields.Controls.Add(this.LogInButton);
            this.panelFields.Controls.Add(this.PasswordText);
            this.panelFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFields.Location = new System.Drawing.Point(0, 38);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(346, 206);
            this.panelFields.TabIndex = 5;
            // 
            // showPass
            // 
            this.showPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showPass.FlatAppearance.BorderSize = 0;
            this.showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPass.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.showPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPass.IconColor = System.Drawing.Color.Black;
            this.showPass.IconSize = 28;
            this.showPass.Location = new System.Drawing.Point(301, 98);
            this.showPass.Name = "showPass";
            this.showPass.Rotation = 0D;
            this.showPass.Size = new System.Drawing.Size(39, 30);
            this.showPass.TabIndex = 6;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPass_MouseDown);
            this.showPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPass_MouseUp);
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.SystemColors.Control;
            this.userIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.userIcon.IconSize = 121;
            this.userIcon.Location = new System.Drawing.Point(97, -94);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(150, 121);
            this.userIcon.TabIndex = 5;
            this.userIcon.TabStop = false;
            this.userIcon.Visible = false;
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.White;
            this.LoginText.BorderColor = System.Drawing.Color.LightBlue;
            this.LoginText.BorderColorNotActive = System.Drawing.Color.Blue;
            this.LoginText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.LoginText.FontTextPreview = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold);
            this.LoginText.ForeColor = System.Drawing.Color.Black;
            this.LoginText.Location = new System.Drawing.Point(45, 44);
            this.LoginText.MaximumSize = new System.Drawing.Size(250, 40);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(250, 40);
            this.LoginText.TabIndex = 1;
            this.LoginText.TextInput = "";
            this.LoginText.TextPreview = "Логин";
            this.LoginText.UseSystemPasswordChar = false;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.LogInButton.BorderElementSize = 1;
            this.LogInButton.Fill = true;
            this.LogInButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(97, 145);
            this.LogInButton.MaximumSize = new System.Drawing.Size(150, 40);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Rounding = 30;
            this.LogInButton.RoundingEnable = true;
            this.LogInButton.Size = new System.Drawing.Size(150, 40);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Войти";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.White;
            this.PasswordText.BorderColor = System.Drawing.Color.LightBlue;
            this.PasswordText.BorderColorNotActive = System.Drawing.Color.Blue;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.PasswordText.FontTextPreview = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold);
            this.PasswordText.ForeColor = System.Drawing.Color.Black;
            this.PasswordText.Location = new System.Drawing.Point(45, 90);
            this.PasswordText.MaximumSize = new System.Drawing.Size(250, 40);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(250, 40);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.TextInput = "";
            this.PasswordText.TextPreview = "Пароль";
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 244);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.panelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Auth_KeyDown);
            this.panelLabel.ResumeLayout(false);
            this.panelFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label AuthLabel;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton resize;
        private System.Windows.Forms.Panel panelFields;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private Controls.DecaTextBox LoginText;
        private Controls.DecaButton LogInButton;
        private Controls.DecaTextBox PasswordText;
        private FontAwesome.Sharp.IconButton showPass;
    }
}

