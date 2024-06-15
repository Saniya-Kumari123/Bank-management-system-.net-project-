using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKMS
{
    public partial class NewAccount : Form
    {

        DBConnection conn = new DBConnection();
        public NewAccount()
        {
            InitializeComponent();
            //   NewAccount_Load(null, null);

            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "yyyy-MM-dd";
        }



        private void cb_accountType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tab_accountDetail.SelectTab("tb_accountDetail");
        }



        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from UI controls
                string Title = cb_title.Text;
                string FirstName = tb_FirstName.Text;
                string LastName = tb_LastName.Text;
                string FatherName = tb_fatherName.Text;
                string MotherName = tb_motherName.Text;
                string EmailAddress = tb_email.Text;
                string CNIC = tb_cnic.Text;
                string PhoneNo = tb_phoneNo.Text;
                string Address = tb_Address.Text;
                string Nationality = tb_nationality.Text;
                string dob = DOB.Text;
                string Gender = rd_male.Checked ? "Male" : "Female";
                string MaritalStatus = rd_married.Checked ? "Married" : "Single";
                int AccountType = cb_accountType.Text == "Saving" ? 1 : 2;
                decimal OpeningBalance = decimal.Parse(tb_OpeningBalance.Text);
                int userId = -1;
                string accountNumber = string.Empty;
                string errorMessage = string.Empty;

                // Establish database connection
                conn.OpenConnection();

                // Create a SqlCommand object and specify the stored procedure
                using (SqlCommand cmd = new SqlCommand("InsertUserAndAccounts", conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Set input parameters
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@FatherName", FatherName);
                    cmd.Parameters.AddWithValue("@MotherName", MotherName);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                    cmd.Parameters.AddWithValue("@Phone", PhoneNo);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@CNIC_No", CNIC);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Marital_status", MaritalStatus);
                    cmd.Parameters.AddWithValue("@AccountTypeID", AccountType);
                    cmd.Parameters.AddWithValue("@InterestRateID", 1); // Set default interest rate ID
                    cmd.Parameters.AddWithValue("@OpeningBalance", OpeningBalance);

                    // Output parameters
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@AccountNumber", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, -1).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    // Retrieve output parameter values
                    // Retrieve output parameter values
                    userId = cmd.Parameters["@UserID"].Value == DBNull.Value ? -1 : Convert.ToInt32(cmd.Parameters["@UserID"].Value);
                    accountNumber = cmd.Parameters["@AccountNumber"].Value == DBNull.Value ? string.Empty : cmd.Parameters["@AccountNumber"].Value.ToString();
                    errorMessage = cmd.Parameters["@ErrorMessage"].Value == DBNull.Value ? string.Empty : cmd.Parameters["@ErrorMessage"].Value.ToString();


                    if (!string.IsNullOrEmpty(errorMessage))
                    {
                        MessageBox.Show("Error occurred: " + errorMessage);
                    }
                    else
                    {
                        MessageBox.Show($"User ID: {userId} created successfully.\nAccount Number: {accountNumber}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
        
    }
}
