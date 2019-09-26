using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogaGyak
{
    abstract class Animal //az abstract jelölés azt jelzi, hogy ezt az osztályt nem fogjuk példányosítani, hanem csak örökíteni fogunk belőle
    {
        private string name = null; //attribútum

        protected string GetName //attribútum get-set metódusa
        {
            get { return name; }
            set { name = value; }
        }

    }
}
