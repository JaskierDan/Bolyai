using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyak
{
    abstract class Animal
    {
        private string name = null;

        protected string GetName
        {
            get { return name; }
            set { name = value; }
        }

    }
}
