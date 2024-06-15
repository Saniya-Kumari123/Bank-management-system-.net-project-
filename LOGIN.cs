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
    public partial class LOGIN : Form
    {
        DBConnection conn = new DBConnection();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            ValidateUser validateUser = new ValidateUser();
            this.Hide();
            validateUser.Show();
        }

        private void lbl_forgetPass_Click(object sender, EventArgs e)
        {
            FORGOT_PASSWORD passwordForgot = new FORGOT_PASSWORD();
            this.Hide();
            passwordForgot.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_username.Text; // Replace with actual username
                string password = tb_password.Text; // Replace with actual password

                int loginResult = 0;
                int roleID;
                string firstName;
                string lastName;


                conn.OpenConnection();

                SqlCommand command = new SqlCommand("UserLogin", conn.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlParameter roleIDParameter = new SqlParameter("@RoleID", SqlDbType.Int);
                roleIDParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(roleIDParameter);

                SqlParameter firstNameParameter = new SqlParameter("@firstName", SqlDbType.VarChar, 25);
                firstNameParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(firstNameParameter);

                SqlParameter lastNameParameter = new SqlParameter("@lastName", SqlDbType.VarChar, 25);
                lastNameParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(lastNameParameter);

                // Execute the stored procedure
                loginResult = Convert.ToInt32(command.ExecuteScalar());

                if (loginResult == 0)
                {
                    // Retrieve output parameters without explicit conversions
                    roleID = (int)roleIDParameter.Value;
                    firstName = (string)firstNameParameter.Value;
                    lastName = (string)lastNameParameter.Value;

                    MessageBox.Show($"Login Successful! Welcome {firstName} {lastName}");

                    if (roleID == 1) // Admin
                    {
                        DASHBOARD adminDashboard = new DASHBOARD();
                        adminDashboard.Show();
                        adminDashboard.FirstName = firstName;
                        adminDashboard.LastName = lastName;
                    }
                    else if (roleID == 2) // Customer
                    {
                        customer_dashboard customerDashboard = new customer_dashboard();
                        customerDashboard.Show();
                        customerDashboard.FirstName = firstName;
                        customerDashboard.LastName = lastName;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Role ID");
                    }


                }

                else
                {
                    MessageBox.Show("Login Failed. Invalid username or password.");
                }

                conn.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
