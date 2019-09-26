using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyak
{
    class Mammal : Animal
    {
        public Mammal(string n)
        {
            GetName = n;
        }

        public void ShowName()
        {
            Console.WriteLine(GetName);
        }
    }
}
