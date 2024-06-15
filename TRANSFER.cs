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
    public partial class TRANSFER : Form
    {
        DBConnection conn = new DBConnection();



        public TRANSFER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void TRANSFER_Load(object sender, EventArgs e)
        {

        }

        private void btn_sender_Click(object sender, EventArgs e)
        {
            string accountNumber = txtsender.Text.Trim();


            if (!string.IsNullOrEmpty(accountNumber))
            {
                string firstName = string.Empty;
                string lastName = string.Empty;

                try
                {
                    conn.OpenConnection();

                    SqlCommand cmd = new SqlCommand("GetUserInfoByAccountNumber", conn.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameter values
                    firstName = cmd.Parameters["@FirstName"].Value.ToString();
                    lastName = cmd.Parameters["@LastName"].Value.ToString();

                    lbl_sfirstname.Text = firstName;
                    lbl_slastname.Text = lastName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.CloseConnection(); // Close the database connection
                }
            }
            else
            {
                MessageBox.Show("Please enter an account number.");
            }

        }
        private void btn_reciever_Click(object sender, EventArgs e)
        {
            string accountNumber = txtreceiver.Text.Trim();

            if (!string.IsNullOrEmpty(accountNumber))
            {
                string firstName = string.Empty;
                string lastName = string.Empty;

                try
                {
                    conn.OpenConnection();

                    SqlCommand cmd = new SqlCommand("GetUserInfoByAccountNumber", conn.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    firstName = cmd.Parameters["@FirstName"].Value.ToString();
                    lastName = cmd.Parameters["@LastName"].Value.ToString();

                    lbl_rfirstanme.Text = firstName;
                    lbl_rlastname.Text = lastName;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter an account number.");
            }


        }

        private void btntranfer_Click(object sender, EventArgs e)
        {
            string senderAccountNumber = txtsender.Text.Trim();
            string receiverAccountNumber = txtreceiver.Text.Trim();
            decimal transferAmount;

            if (!decimal.TryParse(TXTAMOUNT.Text, out transferAmount))
            {
                MessageBox.Show("Please enter a valid transfer amount.");
                return;
            }

            try
            {

                decimal senderBalance = GetAccountBalance(senderAccountNumber);

                if (senderBalance >= transferAmount)
                {
                    conn.OpenConnection();

                    SqlCommand cmd = new SqlCommand("TransferAmount", conn.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SenderAccountNumber", senderAccountNumber);
                    cmd.Parameters.AddWithValue("@ReceiverAccountNumber", receiverAccountNumber);
                    cmd.Parameters.AddWithValue("@Amount", transferAmount);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Transfer successful!");
                }

                else
                {
                    MessageBox.Show("You have insufficient funds to transfer this amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private decimal GetAccountBalance(string accountNumber)
        {
            decimal balance = 0;

            try
            {
                conn.OpenConnection();

                SqlCommand cmd = new SqlCommand("SELECT CurrentBalance FROM Checking_Account WHERE AccountNumber = @AccountNumber", conn.GetConnection());
                cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    balance = Convert.ToDecimal(result);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error fetching account balance: " + ex.Message);
            }

            return balance;
        }
    }
}