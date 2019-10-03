using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SecuritySystem
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=;DATABASE=userdata");

        public void Connect()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void CreateAccount(string name, string pwd)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users(id, username, password) values('NULL', '" + name + "', '" + pwd + "')", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void CheckUser(string user, string pwd)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT password FROM users WHERE username='" + user + "'", conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                if (pwd == rd.GetString(0))
                {
                    Console.WriteLine("Successful login!");
                }
                else
                {
                    Console.WriteLine("Unsuccessful login!");
                }
            }
            else
            {
                Console.WriteLine("Wrong username!");

            }
            rd.Close();
        }
    }
}
