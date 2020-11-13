using System;

namespace Allatkereskedes
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalSelect animalSelect = new AnimalSelect();
            Animal animal = new Animal();
            Random rand = new Random();

            Console.Write("Type: ");
            string type = Console.ReadLine();
            Console.Write("Extra: ");
            string extra = Console.ReadLine();
            int price = rand.Next(100000);
            animalSelect.Choose(price, type, extra, animal);

            Console.Write("Amount to pay: ");
            int amount = int.Parse(Console.ReadLine());
            animalSelect.Buy(amount);
        }
    }
}
