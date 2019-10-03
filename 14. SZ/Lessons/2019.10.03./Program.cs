using System;
using System.Text;
using System.Security.Cryptography;

namespace SecuritySystem
{
    class Program
    { 
        static void Main(string[] args)
        {
            Connection conn = new Connection();
            conn.Connect();
            Console.Write("Password: ");
            string pwd = SecurityBase.Encrypt(Console.ReadLine());
            SecurityBase sb = new SecurityBase(pwd);
            Console.WriteLine(sb.ToString());
            Console.Write("New User: ");
            string user = Console.ReadLine();
            Console.Write("Password: ");
            string npwd = SecurityBase.Encrypt(Console.ReadLine());
            conn.CreateAccount(user, npwd);
            conn.CloseConnection();
        }
    }
}
