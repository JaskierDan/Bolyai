using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conn = new Connection();
            conn.Connect();
            string command = null;
            
            while (command != "3")
            {
                Console.WriteLine("1 - Read Database\n2 - Insert Into Database\n3 - Exit");
                command = Console.ReadLine();
                if(command=="1")
                {
                    conn.ReadTableContents();
                }
                else if(command=="2")
                {
                    conn.InsertIntoTable();
                }
            }
            conn.CloseConnection();
        }
    }
}
