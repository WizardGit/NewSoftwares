using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgette
{
    [System.Serializable]
    class Account
    {
        private decimal balance;
        private string name;

        public Account(string pName, decimal pBalance = 0.0m)
        {
            name = pName;
        }

        public string GetName() => name;
        public decimal GetBalance() => balance;

        public void Deposit(decimal depositAmt)
        {
            balance += depositAmt;
        }
        public void Withdraw(decimal depositAmt)
        {
            balance -= depositAmt;
        }
        public string ReturnAllInfo()
        {
            return name + " : " + balance;
        }
    }
}
