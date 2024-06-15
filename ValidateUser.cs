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
    public partial class ValidateUser : Form
    {
        public ValidateUser()
        {
            InitializeComponent();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            try
            {

                long cnic = Convert.ToInt64(tb_cnic.Text);
                string accountNumber = tb_accNum.Text;
                string phoneNo = tb_PhoneNo.Text;
                string code = tb_UC.Text;

                int userID = 0;
                string firstName = "";
                string lastName = "";

                bool isValid = false;

                DBConnection conn = new DBConnection();

                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("ValidateUserInput", conn.GetConnection());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CNIC", cnic);
                cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                cmd.Parameters.AddWithValue("@Code", code);

                SqlParameter isValidParameter = new SqlParameter("@IsUserValid", SqlDbType.Bit);
                isValidParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isValidParameter);

                SqlParameter userIDParameter = new SqlParameter("@UserID", SqlDbType.Int);
                userIDParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(userIDParameter);

                SqlParameter firstNameParameter = new SqlParameter("@FirstName", SqlDbType.VarChar, 25);
                firstNameParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(firstNameParameter);

                SqlParameter lastNameParameter = new SqlParameter("@LastName", SqlDbType.VarChar, 25);
                lastNameParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(lastNameParameter);

                cmd.ExecuteNonQuery();

                isValid = Convert.ToBoolean(isValidParameter.Value);
                userID = Convert.ToInt32(userIDParameter.Value);
                firstName = firstNameParameter.Value.ToString();
                lastName = lastNameParameter.Value.ToString();

                conn.CloseConnection();
                if (isValid)
                {
                    DBConnection connection = new DBConnection();

                    connection.OpenConnection();

                    SqlCommand command = new SqlCommand("CheckUserExistence", connection.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlParameter resultCodeParameter = new SqlParameter("@ResultCode", SqlDbType.Int);
                    resultCodeParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(resultCodeParameter);

                    command.ExecuteNonQuery();

                    int userExistenceResultCode = Convert.ToInt32(resultCodeParameter.Value);

                    if (userExistenceResultCode == 1)
                    {
                        MessageBox.Show("User with the specified UserID already has login credentials.");
                    }
                    else if (userExistenceResultCode == 0)
                    {
                        MessageBox.Show($"Validation successful! Welcome, {firstName} {lastName}.");

                        NewUserRegsitration registerForm = new NewUserRegsitration();
                        registerForm.UserID = userID;
                        registerForm.FirstName = firstName;
                        registerForm.LastName = lastName;
                        this.Hide();
                        registerForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Validation failed. Please check your input.");
                    }
                }

                else
                {
                    MessageBox.Show("Validation failed. Please check your input.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ValidateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
