using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.AccessControl;

namespace Budgette
{
    [System.Serializable]
    class InfoSave
    {
        public Accounts accounts;
        public Transactions transactions;
        public string userName;
        private string userPass;
        private string dataFile;

        public InfoSave(string pUser)
        {
            userName = pUser;
            dataFile = userName + "AllRecords.save";

            if (File.Exists(dataFile))
                LoadUser();
            else
            {
                accounts = new Accounts();
                transactions = new Transactions();
                userPass = "";
                SaveUser();
            }                
        }

        // Saves our class/variables to a local file
        public void SaveUser()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(dataFile);
            bf.Serialize(file, this);
            file.Close();
            
        }
        //Loads the variables in the file at 'username' if possible
        public void LoadUser()
        {
            if (File.Exists(dataFile))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(dataFile, FileMode.Open);
                InfoSave savedRecords = (InfoSave)bf.Deserialize(file);
                file.Close();

                accounts = savedRecords.accounts;
                transactions = savedRecords.transactions;
                userName = savedRecords.userName;
                userPass = savedRecords.userPass;
                dataFile = savedRecords.dataFile;
            }
            else
                throw new Exception();
        }
        public void DeleteUser()
        {
            File.Delete(dataFile);
        }
    }
}
