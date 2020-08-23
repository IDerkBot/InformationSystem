﻿namespace InformationSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogInButton = new InformationSystem.Controls.DecaButton();
            this.LoginText = new InformationSystem.Controls.DecaTextBox();
            this.PasswordText = new InformationSystem.Controls.DecaTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 38);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::InformationSystem.Properties.Resources.Close;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(308, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogInButton);
            this.panel2.Controls.Add(this.LoginText);
            this.panel2.Controls.Add(this.PasswordText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 220);
            this.panel2.TabIndex = 4;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(211)))), ((int)(((byte)(91)))));
            this.LogInButton.BorderElementSize = 1;
            this.LogInButton.Fill = true;
            this.LogInButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(98, 158);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Rounding = 30;
            this.LogInButton.RoundingEnable = true;
            this.LogInButton.Size = new System.Drawing.Size(150, 40);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Войти";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
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
            this.LoginText.Location = new System.Drawing.Point(41, 55);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(250, 40);
            this.LoginText.TabIndex = 1;
            this.LoginText.TextInput = "";
            this.LoginText.TextPreview = "Логин";
            this.LoginText.UseSystemPasswordChar = false;
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
            this.PasswordText.Location = new System.Drawing.Point(41, 101);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(250, 40);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.TextInput = "";
            this.PasswordText.TextPreview = "Пароль";
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Controls.DecaTextBox LoginText;
        private Controls.DecaTextBox PasswordText;
        private System.Windows.Forms.Panel panel2;
        private Controls.DecaButton LogInButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
