using System;
using System.Collections.Generic;
using System.Text;

namespace Allatkereskedes
{
    class Animal
    {
        protected int age;
        protected string gender;
        protected string species;

        public override string ToString() //toString() metódus felülírása
        {
            string result = String.Format("Age: {0}, Gender: {1}, Species: {2}", age, gender, species);
            return result;
        }
    }
}
