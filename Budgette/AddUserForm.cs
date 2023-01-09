using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budgette
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDatabaseDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.mainDatabaseDataSet.tblUser);

        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            List<string> idNumbers = new List<string>();
            idNumbers.Add("1000");



            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Budgette.Properties.Settings.MainDatabaseConnectionString"].ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("Select UserId from tblUser order by UserId desc", con);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                    idNumbers.Add(string.Format("{0}", reader["UserId"]));
            }


            int.TryParse(idNumbers[idNumbers.Count - 1], out int userId);
            userId++;

            SqlCommand cmd = new SqlCommand("insert into tblUser values('" + userId + "', '" + usernameTxtBox.Text + "','" + passwordTxtBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            tbluserDataGridView.Update();
            tbluserDataGridView.Refresh();
        }
    }
}
