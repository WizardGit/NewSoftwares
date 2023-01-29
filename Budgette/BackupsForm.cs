using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgette
{
    public partial class BackupsForm : Form
    {
        public BackupsForm()
        {
            InitializeComponent();
        }

        private void createBackupBtn_Click(object sender, EventArgs e)
        {
            string sourceDB = @"MainDatabase.mdf";
            string sourceDBLog = @"MainDatabase_log.ldf";
            string destinationDB = @"Backups\" + backupNameTxtBox.Text + ".mdf";
            string destinationDBLog = @"Backups\" + backupNameTxtBox.Text + "_log.ldf";

            if (!System.IO.Directory.Exists(@"Backups"))
                System.IO.Directory.CreateDirectory(@"Backups");

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create backup: " + backupNameTxtBox.Text + "? \n This may take a while.", "Database Backup Creation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Copy(sourceDB, destinationDB, true);
                    File.Copy(sourceDBLog, destinationDBLog, true);
                    exceptionPlaceholder.Text = "Backup Creation was successful!";
                }
                catch
                {
                    exceptionPlaceholder.Text = "Backup Creation was NOT successful!";
                }
            }
            LoadBackupFiles();
        }

        private void restoreBackupBtn_Click(object sender, EventArgs e)
        {
            string destinationDB = @"MainDatabase.mdf";
            string destinationDBLog = @"MainDatabase_log.ldf";
            string sourceDB = @"Backups\" + databaseBackupComboBox.Text + ".mdf";
            string sourceDBLog = @"Backups\" + databaseBackupComboBox.Text + "_log.ldf";
            string backupsDirectory = @"Backups";

            if (!System.IO.Directory.Exists(backupsDirectory)) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore backup: " + databaseBackupComboBox.Text + "? \n This may take a while.", "Database Backup Restore", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Copy(sourceDB, destinationDB, true);
                    File.Copy(sourceDBLog, destinationDBLog, true);
                    exceptionPlaceholder.Text = "Backup Restore was successful!";
                }
                catch
                {
                    exceptionPlaceholder.Text = "Backup Restore was NOT successful!";
                }
            }                
        }

        private void BackupsForm_Load(object sender, EventArgs e)
        {
            LoadBackupFiles();
        }

        private void LoadBackupFiles()
        {
            databaseBackupComboBox.Items.Clear();
            removeDBBackupComboBox.Items.Clear();

            string[] fileEntries = Directory.GetFiles(@"Backups");
            foreach (string file in fileEntries)
            {
                if (!Path.GetFileNameWithoutExtension(file).Contains("_log"))
                {
                    databaseBackupComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));
                    removeDBBackupComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeDBBackupBtn_Click(object sender, EventArgs e)
        {
            string sourceDB = @"Backups\" + removeDBBackupComboBox.Text + ".mdf";
            string sourceDBLog = @"Backups\" + removeDBBackupComboBox.Text + "_log.ldf";
            string backupsDirectory = @"Backups";

            if (!System.IO.Directory.Exists(backupsDirectory)) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove backup: " + removeDBBackupComboBox.Text + "?", "Database Backup Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(sourceDB);
                    File.Delete(sourceDBLog);
                    exceptionPlaceholder.Text = "Backup Rwmoval was successful!";
                }
                catch
                {
                    exceptionPlaceholder.Text = "Backup Removal was NOT successful!";
                }
            }
            LoadBackupFiles();
        }
    }
}
