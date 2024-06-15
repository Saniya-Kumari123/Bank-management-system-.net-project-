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
    public partial class BALANCE_SHEET : Form
    {
        DBConnection conn = new DBConnection();
        public BALANCE_SHEET()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BALANCE_SHEET_Load(object sender, EventArgs e)
        {
            PopulateAccountNumbersListBox();
        }
        private void PopulateAccountNumbersListBox()
        {
            conn.OpenConnection();
            string storedProcedure = "GetAccountNumbers"; // Your stored procedure name


            using (SqlCommand command = new SqlCommand(storedProcedure, conn.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {

                    SqlDataReader reader = command.ExecuteReader();

                    List<string> accountNumbers = new List<string>();

                    while (reader.Read())
                    {
                        string accountNumber = reader["AccountNumber"].ToString();
                        accountNumbers.Add(accountNumber);
                    }

                    accountnumberlist.DataSource = accountNumbers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.CloseConnection();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string accountNumber = textBox1.Text.Trim();


            try
            {
                conn.OpenConnection();

                using (SqlCommand cmd = new SqlCommand("FetchAccountOperations", conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    if (dataSet.Tables.Count >= 2) // Check if there are at least two tables in the dataset
                    {
                        // Display deposit details in dataGridViewDeposits
                        DATAGRIDDEPOSIT.DataSource = dataSet.Tables[0];

                        // Display withdrawal details in dataGridViewWithdrawals
                        DATAGRIDWITHDRAW.DataSource = dataSet.Tables[1];

                        if (dataSet.Tables.Count >= 3)
                        {
                            // Display transfer details in dataGridViewTransfers
                            DATAGRIDTRANSF.DataSource = dataSet.Tables[2];
                        }
                        else
                        {
                            // Clear the DataSource for dataGridViewTransfers as there are no transfer details for a saving account
                            DATAGRIDTRANSF.DataSource = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient data returned for the account.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}