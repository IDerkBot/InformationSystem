using System;
using System.Drawing;
using System.Windows.Forms;
using InformationSystem.Controls;
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;

namespace InformationSystem
{
    public partial class Auth : Form
    {
        #region Компоненты Базы Данных

        private readonly MySqlConnection conn;

        #endregion

        // Начальное кол-во ошибок
        private int _error = 0;

        public Auth()
        {
            InitializeComponent();
            // Старт анимации для собственных элементов
            Animator.Start();
            // Подключение к базе данных
            conn = DatabaseConnect.Connect();
            DataBank.FullScreen = false;
        }

        // Кнопка выхода
        private void Close_Click(object sender, EventArgs e)
        {
            // Выход по нажатию на кнопку выхода(крестик)
            Application.Exit();
        }

        // Кнопка входа
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = LoginText.TextInput;
            string password = PasswordText.TextInput;

            int countUsers = DatabaseConnect.Count("users", "login", login, conn);
            if (countUsers == 1)
            {
                var user = DatabaseConnect.GetTableUsers("select * from `users` where `login` = '" + login + "'", conn);
                if (password == user[2])
                {
                    DataBank.Access = user[3];
                    Hide();
                    new Menu().Show();
                }
                else
                {
                    MessageBox.Show("Пароль не верный!", "Не верные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Error();
                }
            }
            else
            {
                MessageBox.Show("Логин не верный!", "Не верные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Error();
            }
        }

        // Счетчик ошибок
        private void Error()
        {
            LoginText.TextInput = "";
            PasswordText.TextInput = "";
            _error++;
            if (_error >= 5)
            {
                MessageBox.Show("Вы превысели допустимый лимит попыток", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Кнопка изменения размера формы
        private void Resize_Click(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            if (this.Width == screenWidth)
            {
                this.Width = 346;
                this.Height = 244;
                this.Location = new Point(screenWidth / 2 - this.Width / 2, screenHeight / 2 - this.Height / 2);
                userIcon.Visible = false;
                DataBank.FullScreen = false;
            }
            else
            {
                this.Width = screenWidth;
                this.Height = screenHeight;
                this.Location = new Point(0, 0);
                userIcon.Visible = true;
                DataBank.FullScreen = true;
            }
            CenterTB(LoginText, -50);
            CenterTB(PasswordText, 0);
            CenterBtn(LogInButton, 50);
            CenterBtnFA(showPass, PasswordText.Width / 2 + 25, 3);
            CenterPB(userIcon, -150);
        }
        private void showPass_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordText.UseSystemPasswordChar = false;
        }
        private void showPass_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordText.UseSystemPasswordChar = true;
        }


        #region Centering
        void CenterTB(DecaTextBox tb, int topMargin)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            int tbWidth = tb.Width;
            int tbHeight = tb.Height;
            tb.Location = new Point((formWidth / 2) - (tbWidth / 2), (formHeight / 2) - (tbHeight / 2) + topMargin);
        }
        void CenterBtn(DecaButton btn, int topMargin)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            int btnWidth = btn.Width;
            int btnHeight = btn.Height;
            btn.Location = new Point((formWidth / 2) - (btnWidth / 2), (formHeight / 2) - (btnHeight / 2) + topMargin);
        }
        void CenterBtnFA(IconButton btn, int leftMargin, int topMargin)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            int btnWidth = btn.Width;
            int btnHeight = btn.Height;
            btn.Location = new Point((formWidth / 2) - (btnWidth / 2) + leftMargin, (formHeight / 2) - (btnHeight / 2) + topMargin);
        }
        void CenterPB(IconPictureBox pb, int topMargin)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            int pbWidth = pb.Width;
            int pbHeight = pb.Height;
            pb.Location = new Point((formWidth / 2) - (pbWidth / 2), (formHeight / 2) - (pbHeight / 2) + topMargin);
        }
        #endregion

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) LogInButton_Click(LogInButton, null);
        }
    }
}
