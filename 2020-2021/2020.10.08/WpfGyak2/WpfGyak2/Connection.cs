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

namespace WpfGyak2
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=;DATABASE=school");

        private void Connect()
        {
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region SQL Operations
        public void Grade(ComboBox cb1, ComboBox cb2, TextBox tb)
        {
            Connect();
            string sql = String.Format("INSERT INTO data(id, student_id, subject_id, grade) VALUES(NULL, {0}, {1}, {2})", cb1.SelectedValue, cb2.SelectedValue, Convert.ToInt32(tb.Text));
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
        }

        public void AddNewData(TextBox tb, string table)
        {
            Connect();
            string sql = String.Format("INSERT INTO {0}(id, name) VALUES(NULL, '{1}')", table, tb.Text);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
        }

        public void FillComboBox(ComboBox cb, string table)
        {
            Connect();
            string sql = String.Format("SELECT id, name FROM {0}", table);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cb.ItemsSource = ds.Tables[0].DefaultView;
            cb.DisplayMemberPath = ds.Tables[0].Columns[1].ToString();
            cb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
            conn.Close();
        }


        public void FillListBox(ListBox lb, ComboBox cb)
        {
            Connect();
            string sql = String.Format("SELECT CONCAT_WS(' ', subjects.name, data.grade) as ossz FROM subjects LEFT JOIN data ON data.subject_id = subjects.id WHERE data.student_id={0}", cb.SelectedValue);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lb.ItemsSource = ds.Tables[0].DefaultView;
            lb.DisplayMemberPath = ds.Tables[0].Columns["ossz"].ToString();
            conn.Close();
        }
        #endregion
    }
}