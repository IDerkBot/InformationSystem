using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class OrganizationAdd : Form
    {
        MySqlConnection conn;
        public OrganizationAdd()
        {
            InitializeComponent();
            conn = DatabaseConnect.Connect();
        }

        private void decaButton1_Click(object sender, EventArgs e)
        {
            if(decaTextBox1.Text.Length > 0 && decaTextBox2.Text.Length > 0 && decaTextBox3.Text.Length > 0 && decaTextBox4.Text.Length > 0 && decaTextBox5.Text.Length > 0 && comboBox1.SelectedIndex != 0)
            {
                string sql = "insert into `organization` (`name`,`number`,`position`,`address`,`area`,`type`) values('" + decaTextBox1.Text + "','" + decaTextBox2.Text + "','" + decaTextBox3.Text + "','" + decaTextBox4.Text + "','" + decaTextBox5.Text + "','" + comboBox1.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
            }
        }
    }
}
