using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlPractice
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection("SERVER=localhost;UID=root;PWD=;DATABASE=csharptest");
        public void Connect()
        {
            try
            {              
                conn.Open();
                Console.WriteLine("Connection is " + conn.State.ToString());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
        }

        public void InsertIntoTable()
        { 
            Console.Write("Adja meg a tanuló azonosítóját: ");
            int studentID = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a tanuló keresztnevét: ");
            string fName = Console.ReadLine();
            Console.Write("Adja meg a tanuló vezetéknevét: ");
            string lName = Console.ReadLine();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO students(id, StudentID, StudentFName, StudentLName) values(NULL, '" + studentID + "', '" + fName + "', '" + lName + "')", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void ReadTableContents()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * From students", conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            string str = "[ID]\t[Student ID]\t[First Name]\t[Last Name]" + Environment.NewLine;
            if (rd.HasRows)
            {
                while(rd.Read())
                {
                    str += rd.GetInt32(0) + "\t" + rd.GetInt32(1) + "\t\t" + rd.GetString(2) + "\t\t" + rd.GetString(3) + Environment.NewLine;
                }
                rd.Close();
            }
            Console.WriteLine(str);
        }

        public void CloseConnection()
        {
            conn.Close();
            Console.WriteLine("Connection is " + conn.State.ToString());
        }
    }
}
