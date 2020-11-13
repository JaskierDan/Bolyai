using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class PickCoffee
    {
        private string type;
        private string extra;
        private int price;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
