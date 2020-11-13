using System;
using System.Collections.Generic;
using System.Text;

namespace Allatkereskedes
{
    class Mammal : Animal
    {
        public Mammal(int age, string gender, string species)
        {
            this.age = age;
            this.gender = gender;
            this.species = species;
        }
    }
}
