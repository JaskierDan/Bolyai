using System;

namespace DogaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(122, 10000);
            string command = null;
            int a = 0;
            while (command != "5")
            {
                Console.WriteLine("1 - Deposit\n2 - Withdraw\n3 - Show Balance\n4 - Set Id\n5 - Exit");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        Console.Write("Ammount: ");
                        a = int.Parse(Console.ReadLine());
                        client.Deposit(a);
                        break;

                    case "2":
                        {
                            Console.Write("Ammount: ");
                            a = int.Parse(Console.ReadLine());
                            client.Withdraw(a);
                            break;
                        }

                    case "3":
                        {
                            client.ShowBalance();
                            break;
                        }

                    case "4":
                        {
                            Console.Write("New ID: ");
                            a = int.Parse(Console.ReadLine());
                            client.SetId(a);
                            break;
                        }
                }
            }
        }
    }
}
