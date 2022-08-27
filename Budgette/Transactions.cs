using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgette
{
    [System.Serializable]
    class Transactions
    {
        private List<Transaction> transactionsList;
        public Transactions(List<Transaction> pTransactionsList)
        {
            transactionsList = pTransactionsList;
        }
        public Transactions()
        {
            transactionsList = new List<Transaction>();
        }

        public Transaction GetTransaction()
        {
            return null;
        }

        public bool AddTransaction()
        {
            return false;
        }

        private bool RemoveTransaction()
        {
            return false;
        }


        public string ReturnAllTransactionInfo()
        {
            string ret = "";

            foreach (Transaction t in transactionsList)
            {
                ret += t.ReturnAllInfo();
            }
            return ret;
        }
    }
}
