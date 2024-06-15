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
    public partial class SEARCH_ACCOUNT : Form
    {
        List<string> allAccountNumbersList = new List<string>();

        public SEARCH_ACCOUNT(List<string> savingAccountNumbers, List<string> checkingAccountNumbers)
        {
            InitializeComponent();

            // Combine both lists into a single list
            allAccountNumbersList.AddRange(savingAccountNumbers);
            allAccountNumbersList.AddRange(checkingAccountNumbers);

            // Use 'allAccountNumbersList' to display all account numbers in the UI
            // For example:
            foreach (var accountNumber in allAccountNumbersList)
            {
                // Add account numbers to your list box or display them in the UI
                accountnumberlist.Items.Add(accountNumber);
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            conn.OpenConnection();

            string accountNumber = textBox1.Text.Trim();

            try
            {


                SqlCommand command = new SqlCommand("AccountSearch", conn.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Display fetched details in DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SEARCH_ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void accountnumberlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

