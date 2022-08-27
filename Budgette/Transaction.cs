using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgette
{
    [System.Serializable]
    class Transaction
    {
        private DateTime date;
        private string description = "";
        private decimal fromAccountMon = 0.0m;
        private decimal toAccountMon = 0.0m;
        private string fromAccountStr = "";
        private string toAccountStr = "";

        public Transaction(DateTime pDate, string pDescription, 
                           decimal pFromAccountMon, decimal pToAccountMon,
                           string pFromAccountStr, string pToAccountStr)
        {
            date = pDate;
            description = pDescription;
            fromAccountMon = pFromAccountMon;
            toAccountMon = pToAccountMon;
            toAccountStr = pToAccountStr;
            fromAccountStr = pFromAccountStr;
        }

        public void CompleteTransaction(Accounts ga)
        {
            ga.GetAccount(fromAccountStr).Withdraw(fromAccountMon);
            ga.GetAccount(toAccountStr).Deposit(toAccountMon);
        }

        public string ReturnAllInfo()
        {
            return date + " : " + description + " : " + fromAccountMon + " : " + fromAccountStr + " : " + toAccountMon + " : " + toAccountStr;
        }
    }
}
