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
    public partial class SAVING_ACCOUNT : Form
    {
        DBConnection conn = new DBConnection();
        public SAVING_ACCOUNT()
        {
            InitializeComponent();
        }

        private void SAVING_ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox2.Text.Trim();

            conn.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("GetSaving_AccountDetails ", conn.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = accountNumber;
                cmd.Parameters.Add("@OpeningBalance", SqlDbType.Money).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CurrentBalance", SqlDbType.Money).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@TotalEarnings", SqlDbType.Money).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, -1).Direction = ParameterDirection.Output;

                try
                {
                    cmd.ExecuteNonQuery();

                    decimal openingBalance = Convert.ToDecimal(cmd.Parameters["@OpeningBalance"].Value);
                    decimal currentBalance = Convert.ToDecimal(cmd.Parameters["@CurrentBalance"].Value);
                    decimal totalEarnings = Convert.ToDecimal(cmd.Parameters["@TotalEarnings"].Value);
                    string errorMessage = cmd.Parameters["@ErrorMessage"].Value.ToString();

                    // Displaying retrieved data in labels
                    lbl_openingbalance.Text = " " + openingBalance.ToString("C");
                    lbl_currentbalance.Text = " " + currentBalance.ToString("C");
                    lbl_totalearning.Text = " " + totalEarnings.ToString("C");
                    //  lblErrorMessage.Text = "Error Message: " + errorMessage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
