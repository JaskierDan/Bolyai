using System;
using System.Collections.Generic;
using System.Text;

namespace DogaTest
{
    class BankAccount
    {
        private int id = 0;
        private int balance = 0;

        protected int GetId
        {
            get { return id; }
            set { id = value; }
        }

        protected int GetBalance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
