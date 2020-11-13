using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Transaction transaction = new Transaction();
            Console.Write("Típus: ");
            string type = Console.ReadLine();
            int price = random.Next(500);
            Console.WriteLine("Ár: {0}", price);
            Console.Write("Extra: ");
            string extra = Console.ReadLine();
            transaction.Choose(type, price, extra);
            Console.Write("Adja meg az összeget: ");
            int amount = int.Parse(Console.ReadLine());
            transaction.Buy(amount);
        }
    }
}
