using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InformationSystem
{
    public partial class Organization : Form
    {
        #region Компоненты Базы Данных

            private readonly MySqlConnection conn;

        #endregion

        public Organization()
        {
            InitializeComponent();
            conn = DatabaseConnect.Connect();
        }

        struct tableOrganization
        {
            public int id;
            public string name, number, position, address, area, type;
        }
        

        private void Organization_Load(object sender, EventArgs e)
        {
            if(DataBank.Access == "admin")
            {
                decaButton1.Visible = true;
            }
            List<tableOrganization> tbOrgan = getTableOrgan();
            for (int i = 0; i < tbOrgan.Count; i++) comboBox1.Items.Add(tbOrgan[i].name);

        }
        List<tableOrganization> getTableOrgan()
        {
            List<tableOrganization> tbOrgan = new List<tableOrganization>();
            tableOrganization tmp;
            tbOrgan.Clear();
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `organization`", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tmp.id = int.Parse(reader["id"].ToString());
                tmp.name = reader["name"].ToString();
                tmp.number = reader["number"].ToString();
                tmp.position = reader["position"].ToString();
                tmp.address = reader["address"].ToString();
                tmp.area = reader["area"].ToString();
                tmp.type = reader["type"].ToString();
                tbOrgan.Add(tmp);
            }
            reader.Close();
            return tbOrgan;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<tableOrganization> tbOrgan = getTableOrgan();
            int index = comboBox1.SelectedIndex;
            decaGroup1.Text = tbOrgan[index].number;
            decaGroup2.Text = tbOrgan[index].position;
            decaGroup3.Text = tbOrgan[index].address;
            decaGroup4.Text = tbOrgan[index].area;
            decaGroup5.Text = tbOrgan[index].type;
            Refresh();
        }

        private void decaGroup1_TextChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void decaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrganizationAdd().Show();
        }

        private void decaButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
