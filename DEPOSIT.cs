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
    public partial class DEPOSIT : Form
    {

        DBConnection conn = new DBConnection();
        string accountType;
        string firstName;
        string lastName;
        decimal balance;
        string accountNumber;
        public DEPOSIT()
        {
            InitializeComponent();
        }

        private void DEPOSIT_Load(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_Balance.Text = string.Empty;
            lbl_firstName.Text = string.Empty;
            lbl_lastName.Text = string.Empty;


            accountNumber = textBox2.Text; // Fetch account number from textbox
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
            lbl_firstName.Text = firstName;
            lbl_lastName.Text = lastName;
            lbl_Balance.Text = balance.ToString();


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            decimal depositAmount;
            if (!decimal.TryParse(textBox4.Text, out depositAmount))
            {
                MessageBox.Show("Please enter a valid deposit amount.");
                return;
            }

            conn.OpenConnection();

            using (SqlCommand command = new SqlCommand("UpdateAccountBalance", conn.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumber;
                command.Parameters.Add("@AccountType", SqlDbType.VarChar, 3).Value = accountType;
                command.Parameters.Add("@Amount", SqlDbType.Money).Value = depositAmount;
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