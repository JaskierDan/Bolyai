using System;
using System.Collections.Generic;
using System.Text;

namespace Allatkereskedes
{
    class AnimalSelect
    {
        Transaction transaction = new Transaction();

        public void Choose(int price, string type, string extra, Animal animal)
        {
            transaction.Price = price;
            transaction.Type = type;
            transaction.Extra = extra;

            int age;
            string gender;
            string species;

            if(type == "m")
            {
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Gender: ");
                gender = Console.ReadLine();
                Console.Write("Species: ");
                species = Console.ReadLine();
                animal = new Mammal(age, gender, species);
                Console.WriteLine("Price: {0} Ft, Type: {1}, Extra: {2}", price, type, extra);
                Console.WriteLine(animal.ToString());
            }
            else if (type == "a")
            {
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Gender: ");
                gender = Console.ReadLine();
                Console.Write("Species: ");
                species = Console.ReadLine();
                animal = new Amphibian(age, gender, species);
                Console.WriteLine("Price: {0} Ft, Type: {1}, Extra: {2}", price, type, extra);
                Console.WriteLine(animal.ToString());
            }
            else
            {
                Console.WriteLine("Incorrect type!");
            }
        }

        public void Buy(int amount)
        {
            if(amount < transaction.Price)
            {
                Console.WriteLine("Unsuccessful purchase!");
            }
            else if(amount >= transaction.Price)
            {
                Console.WriteLine("Successful purchase!");
            }
        }
    }
}
