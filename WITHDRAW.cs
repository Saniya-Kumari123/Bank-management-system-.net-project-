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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BANKMS
{
    public partial class WITHDRAW : Form
    {
        DBConnection conn = new DBConnection();
        string accountType;
        string firstName;
        string lastName;
        decimal balance;
        string accountNumber;
        decimal @CurrentBalance;
        public WITHDRAW()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WITHDRAW_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_Balance.Text = string.Empty;
            lbl_FirstName.Text = string.Empty;
            lblLastName.Text = string.Empty;


            accountNumber = textBox3.Text; // Fetch account number from textbox
            string[] parts = accountNumber.Split('-');
            accountType = parts[0]; // Extract the account type

            if (accountType == "SAV")
            {
                conn.OpenConnection();

                using (SqlCommand command = new SqlCommand("GetSavingAccountDetails", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumber;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Balance", SqlDbType.Money).Direction = ParameterDirection.Output;


                    command.ExecuteNonQuery();

                    firstName = command.Parameters["@FirstName"].Value.ToString();
                    lastName = command.Parameters["@LastName"].Value.ToString();
                    balance = Convert.ToDecimal(command.Parameters["@Balance"].Value);
                }
                conn.CloseConnection();

            }
            else if (accountType == "CHK")
            {
                conn.OpenConnection();

                using (SqlCommand command = new SqlCommand("GetCheckingAccountDetails", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumber;
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 25).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Balance", SqlDbType.Money).Direction = ParameterDirection.Output;


                    command.ExecuteNonQuery();

                    firstName = command.Parameters["@FirstName"].Value.ToString();
                    lastName = command.Parameters["@LastName"].Value.ToString();
                    balance = Convert.ToDecimal(command.Parameters["@Balance"].Value);


                }
                conn.CloseConnection();
            }
            else
            {
                MessageBox.Show("Wrong Account Number");
            }
            lbl_FirstName.Text = firstName;
            lblLastName.Text = lastName;
            lbl_Balance.Text = balance.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal withdrawamount;
            if (!decimal.TryParse(textBox5.Text, out withdrawamount))
            {
                MessageBox.Show("Please enter a valid withdraw amount.");
                return;
            }

            conn.OpenConnection();

            using (SqlCommand command = new SqlCommand("WithdrawMoney", conn.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumber;
                command.Parameters.Add("@AccountType", SqlDbType.VarChar, 3).Value = accountType;
                 command.Parameters.Add("@Amount", SqlDbType.Money).Value = withdrawamount;
                command.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, -1).Direction = ParameterDirection.Output;

                try
                {
                    command.ExecuteNonQuery();
                    string errorMessage = command.Parameters["@ErrorMessage"].Value.ToString();
                    MessageBox.Show(errorMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            conn.CloseConnection();
        }
    }
}
   

