using System.Collections.Generic;
using System.Windows.Forms;

namespace Budgette
{
    [System.Serializable]
    public class Accounts
    {
        private List<Account> accountsList;
        public Accounts(List<Account> pAccountsList)
        {
            accountsList = pAccountsList;
        }

        public Accounts()
        {
            accountsList = new List<Account>();
        }

        public Account GetAccount(string accountName)
        {
            foreach (Account a in accountsList)
            {
                if (a.GetName() == accountName)
                    return a;
            }
            return null;
        }

        public int NumOfAccounts()
        {
            return accountsList.Count;
        }

        public bool AddAccount(string pName, decimal pBalance = 0.0m)
        {
            foreach (Account a in accountsList)
            {
                if (a.GetName() == pName)
                    return false;
            }
            Account newAcc = new Account(pName, pBalance);
            accountsList.Add(newAcc);

            return true;
        }
        public bool RemoveAccount(string pName)
        {
            foreach (Account a in accountsList)
            {
                if (a.GetName() == pName)
                {
                    if (a.GetBalance() == 0.0m)
                    {
                        accountsList.Remove(a);
                        return true;
                    }
                    return false;
                }

            }
            return false;
        }

        public string ReturnAllAccountInfo()
        {
            string ret = "";

            foreach (Account a in accountsList)
            {
                ret += a.ReturnAllInfo() + "\n";
            }
            return ret;
        }
    }
}
