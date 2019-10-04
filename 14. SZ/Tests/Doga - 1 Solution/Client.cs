using System;
using System.Collections.Generic;
using System.Text;

namespace DogaTest
{
    class Client : BankAccount
    {
        public Client(int id, int balance)
        {
            GetId = id;
            GetBalance = balance;
        }

        public void Deposit(int val) {
            GetBalance += val;
        }

        public void Withdraw(int val) {
            if (val > GetBalance)
            {
                Console.WriteLine("Not enough money!");
            }
            else
            {
                GetBalance -= val;
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine("ID: " + GetId + " Balance: " + GetBalance);
        }

        public void SetId(int val)
        {
            GetId = val;
        }
    }
}
