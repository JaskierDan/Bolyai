using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class Transaction
    {
        PickCoffee pickCoffee = new PickCoffee();

        public void Choose(string type, int price, string extra)
        {
            pickCoffee.Type = type;
            pickCoffee.Price = price;
            pickCoffee.Extra = extra;
        }

        public void Buy(int amount)
        {
            if(amount < pickCoffee.Price)
            {
                Console.WriteLine("Sikertelen vásárlás, nem megfelelő összeg!");
            }
            else if(amount >= pickCoffee.Price)
            {
                if(amount > pickCoffee.Price)
                {
                    Console.WriteLine("Sikeres vásárlás! Visszajáró: " + (amount - pickCoffee.Price));
                }
                else
                {
                    Console.WriteLine("Sikeres vásárlás!");
                }
            }
        }
    }
}
