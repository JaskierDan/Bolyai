using System;
using System.Collections.Generic;
using System.Text;

namespace Allatkereskedes
{
    class Transaction
    {
        private int price;
        private string type;
        private string extra;

        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public string Extra { get => extra; set => extra = value; }
    }
}
