using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyak
{
    class Mammal : Animal //Örökítés
    {
        public Mammal(string n) //
        {                       // Konstruktor
            GetName = n;        //
        }                       //

        public void ShowName()
        {
            Console.WriteLine(GetName);
        }
    }
}
