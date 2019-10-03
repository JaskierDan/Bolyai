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
            string cmd = null, user = null, pwd = null;
            while (cmd != "3")
            {
                Console.WriteLine("1 - Create Account\n2 - Login\n3 - Exit");
                cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        Console.WriteLine("CREATE ACCOUNT");
                        Console.Write("New User: ");
                        user = Console.ReadLine();
                        Console.Write("Password: ");
                        pwd = SecurityBase.Encrypt(Console.ReadLine());
                        conn.CreateAccount(user, pwd);
                        break;
                    case "2":
                        Console.WriteLine("LOGIN");
                        Console.Write("Username: ");
                        user = Console.ReadLine();
                        Console.Write("Password: ");
                        pwd = SecurityBase.Encrypt(Console.ReadLine());
                        conn.CheckUser(user, pwd);
                        break;
                    default:
                        break;
                }
            }
            conn.CloseConnection();
        }
    }
}
