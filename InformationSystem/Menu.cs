using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (DataBank.Access == "user")
            {
                this.Height = 240;
            }
            else if(DataBank.Access == "admin")
            {
                this.Height = 300;

                users.Visible = true;
            }
        }

        private void organizationButton_Click(object sender, EventArgs e)
        {
            Hide();
            new Organization().Show();
        }

        private void cultures_Click(object sender, EventArgs e)
        {
            Hide();
            new Cultures().Show();
        }

        private void fields_Click(object sender, EventArgs e)
        {
            Hide();
            new Fields().Show();
        }

        private void users_Click(object sender, EventArgs e)
        {
            Hide();
            new Users().Show();
        }
    }
}
