using System.Collections.Generic;

namespace Budgette
{
    [System.Serializable]
    public class Transactions
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
