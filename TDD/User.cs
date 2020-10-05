using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class User
    {
        private string pin;
        public string Pin { get { return pin; } }
        
        private double balance;
        public double Balance { get { return balance; } }

        public User(string pin, double balance)
        {
            this.pin = pin;
            this.balance = balance;
        }

        public void InsertMoney(double amount)
        {
            balance += amount;
        }

        public void WithdrawMoney(double amount)
        {
            balance -= amount;
        }
    }
}
