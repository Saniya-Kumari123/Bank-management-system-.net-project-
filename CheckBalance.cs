using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKMS
{
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text.Trim();
            DBConnection conn = new DBConnection();
            conn.OpenConnection();


            try
            {


                SqlCommand command = new SqlCommand("CheckBalance", conn.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string accountType = reader["AccountType"].ToString();
                        string balance = reader["CurrentBalance"].ToString();

                        // Handle account type and balance here
                        HandleAccountInfo(accountType, balance);
                    }
                }
                else
                {
                    // Handle account not found
                    HandleAccountNotFound();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void HandleAccountInfo(string accountType, string balance)
        {
            // Perform actions with the retrieved account information
            // For example, you can display it in a MessageBox:
            MessageBox.Show($"Account Type: {accountType}, Current Balance: {balance}");
        }

        private void HandleAccountNotFound()
        {
            // Handle the case where the account number is not found
            // For example, display an appropriate message:
            MessageBox.Show("Account number not found.");
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {

        }
    }
}

