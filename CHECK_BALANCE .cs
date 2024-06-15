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
    public partial class CHECK_BALANCE : Form
    {
        DBConnection conn = new DBConnection();
        decimal balance;

        public CHECK_BALANCE()
        {

            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHECK_BALANCE_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text.Trim();
            lbl_balance.Text = string.Empty;

            if (!string.IsNullOrEmpty(accountNumber))
            {
                string accountType;

                if (accountNumber.StartsWith("CHK")) // Criteria for Checking account
                {
                    accountType = "CHK"; // Set account type to Checking
                }
                else if (accountNumber.StartsWith("SAV")) // Criteria for Saving account
                {
                    accountType = "SAV"; // Set account type to Saving
                }
                else
                {
                    MessageBox.Show("Invalid account number format.");
                    return;
                }

                conn.OpenConnection(); // Open the database connection

                using (SqlCommand command = new SqlCommand("GetAccountBalance", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@AccountType", accountType); // Pass the account type to the stored procedure
                    command.Parameters.Add("@Balance", SqlDbType.Money).Direction = ParameterDirection.Output;

                    try
                    {
                        command.ExecuteNonQuery();

                        balance = Convert.ToDecimal(command.Parameters["@Balance"].Value);

                        lbl_balance.Text = balance.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                conn.CloseConnection(); // Close the database connection
            }
            else
            {
                MessageBox.Show("Please enter an account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}