using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InformationSystem
{
    class DatabaseConnect
    {

        public static MySqlConnection Connect()
        {
            MySqlConnectionStringBuilder db;
            MySqlConnection conn;
            db = new MySqlConnectionStringBuilder();
            db.Server = DataBank.Host;
            db.Database = DataBank.Db;
            db.UserID = DataBank.User;
            db.Password = DataBank.Password;
            db.Port = DataBank.Port;
            db.CharacterSet = "utf8";
            conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
                Application.Exit();
            }

            return conn;
        }

        public static int Count(string table, string field, string value, MySqlConnection connection)
        {
            string sql = "select count(*) from `" + table + "` where `" + field + "` = '" + value + "'";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            int c = 0;
            while (reader.Read())
            {
                c = int.Parse(reader["count(*)"].ToString());
            }
            reader.Close();
            return c;
        }

        public static string[] GetTableUsers(string sql, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            string[] User = new string[4];

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User[0] = reader["id"].ToString();
                User[1] = reader["login"].ToString();
                User[2] = reader["password"].ToString();
                User[3] = reader["access"].ToString();
            }

            reader.Close();

            return User;
        }
        public static string[] GetTableOrganizations(string sql, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            string[] Organization = new string[7];

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Organization[0] = reader["id"].ToString();
                Organization[1] = reader["name"].ToString();
                Organization[2] = reader["number"].ToString();
                Organization[3] = reader["position"].ToString();
                Organization[4] = reader["address"].ToString();
                Organization[5] = reader["area"].ToString();
                Organization[6] = reader["type"].ToString();
            }

            reader.Close();

            return Organization;
        }

        public static string[] GetTableCultures(string sql, MySqlConnection connection)
        {
            var _cmd = new MySqlCommand("SELECT * FROM `cultures`" + sql, connection);
            var _cultures = new string[10];
            var reader = _cmd.ExecuteReader();
            while (reader.Read())
            {
                _cultures[0] = reader["id"].ToString();
                _cultures[1] = reader["name"].ToString();
                _cultures[2] = reader["ph"].ToString();
                _cultures[3] = reader["phosphor"].ToString();
                _cultures[4] = reader["potassium"].ToString();
                _cultures[5] = reader["magnesium"].ToString();
                _cultures[6] = reader["calcium"].ToString();
                _cultures[7] = reader["humidity"].ToString();
                _cultures[8] = reader["nitrogen"].ToString();
                _cultures[9] = reader["temperature"].ToString();
            }
            reader.Close();
            return _cultures;
        }
    }
}
