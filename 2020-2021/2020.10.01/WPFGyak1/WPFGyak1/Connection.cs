using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace WPFGyak1
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=;DATABASE=wpftest");

        private void Connect()
        {
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Couldn't connect! Error: {0}", ex.Message.ToString());
            }
        }

        public void Insert(TextBox tx1)
        {
            Connect();

            if(tx1.Text != "")
            {
                string sql = String.Format("INSERT INTO data(id, message) VALUES(NULL, '{0}')", tx1.Text);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Unsuccessful! Error: {0}", ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please don't leave the input field empty!");
            }

            conn.Close();
        }

        public void FillListBox(ListBox lb)
        {
            Connect();

            string sql = "SELECT id, CONCAT_WS(' ', id, message) as ossz FROM data";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            lb.ItemsSource = ds.Tables[0].DefaultView;
            lb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
            lb.DisplayMemberPath = ds.Tables[0].Columns["ossz"].ToString();

            conn.Close();
        }

        public void Delete(ListBox lb)
        {
            Connect();

            if (lb.SelectedValue != null)
            {
                string sql = String.Format("DELETE FROM data WHERE id={0}", lb.SelectedValue);

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select an item!");
            }
            conn.Close();
        }

        public void Update(ListBox lb, TextBox tb)
        {
            Connect();

            if(lb.SelectedValue != null && tb.Text != "")
            {
                string sql = String.Format("UPDATE data SET message='{0}' WHERE id={1}", tb.Text, lb.SelectedValue);

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    tb.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select an item and type in the new value!");
            }

            conn.Close();
        }
    }
}
