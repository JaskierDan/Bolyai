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
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfGyak3
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=;DATABASE=zoo");

        private void Connect()
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region SQL Commands
        public void Insert(string table, TextBox data)
        {
            Connect();
            string sql = String.Format("INSERT INTO {0}(id, name) VALUES(NULL, '{1}')", table, data.Text);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
        }

        public void FillListBox(ListBox lb)
        {
            Connect();
            string sql = "SELECT animal.id, CONCAT_WS(' ', animal.name, species.name) AS ossz FROM residents LEFT JOIN animal ON animal.id = residents.animal_ID LEFT JOIN species ON species.id = residents.species_ID";
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                lb.ItemsSource = ds.Tables[0].DefaultView;
                lb.DisplayMemberPath = ds.Tables[0].Columns["ossz"].ToString();
                lb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
        }

        public void FillComboBox(ComboBox cb)
        {
            Connect();
            string sql = "SELECT id, name FROM species";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cb.ItemsSource = ds.Tables[0].DefaultView;
            cb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            cb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
            conn.Close();
        }

        public void AddAnimal(TextBox tb, ComboBox cb)
        {
            Insert("animal", tb);
            Connect();
            string sql = String.Format("INSERT INTO residents(id, animal_ID, species_ID) VALUES(NULL, (SELECT id FROM animal WHERE name='{0}'), {1})", tb.Text, cb.SelectedValue);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
        }

        public void DeleteAnimal(ListBox lb)
        {
            Connect();
            if(lb.SelectedValue != null)
            {
                string sql = String.Format("DELETE FROM residents WHERE animal_ID={0}; DELETE FROM animal WHERE id={0}", lb.SelectedValue);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kérlek jelöld ki valamelyik állatot!");
            }
            
            conn.Close();
        }
        #endregion
    }
}
