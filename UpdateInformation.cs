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
    public partial class UpdateInformation : Form
    {
        public UpdateInformation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(txt_userid.Text, out userID))
            {
                DBConnection conn = new DBConnection();
                conn.OpenConnection();


                string query = "SELECT * FROM UserInfo WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@UserID", userID);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Populate form fields with retrieved user information
                    txtnationlity.Text = reader["Nationality"].ToString();
                    txtemail.Text = reader["emailAddress"].ToString();
                    txtaddress.Text = reader["ADDRESS"].ToString();
                    txtphone.Text = reader["phone"].ToString();
                    // Retrieve Marital Status and set radio buttons accordingly
                    string maritalStatus = reader["Marital_status"].ToString();
                    if (maritalStatus == "Single")
                    {
                        rdsingle.Checked = true;
                    }
                    else if (maritalStatus == "Married")
                    {
                        rdmarried.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                    // Clear form fields and radio buttons
                    ClearFields();
                }
                reader.Close();
            }

            else
            {
                MessageBox.Show("Please enter a valid UserID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userID;
            if (int.TryParse(txt_userid.Text, out userID))
            {
                string maritalStatus = GetSelectedMaritalStatus();

                DBConnection conn = new DBConnection();
                conn.OpenConnection();

                string query = "EXEC UpdateUserAccount @UserID, @Nationality,@ADDRESS, @EmailAddress, @MaritalStatus, @Phone";
                SqlCommand command = new SqlCommand(query, conn.GetConnection());
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Nationality", txtnationlity.Text);
                command.Parameters.AddWithValue("@EmailAddress", txtemail.Text);
                command.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                command.Parameters.AddWithValue("@Phone", txtphone.Text);
                command.Parameters.AddWithValue("@ADDRESS", txtaddress.Text);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User account updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update user account.");
                }
            }

            else
            {
                MessageBox.Show("Please enter a valid UserID.");
            }
        }

        private string GetSelectedMaritalStatus()
        {
            if (rdsingle.Checked)
            {
                return "Single";
            }
            else if (rdmarried.Checked)
            {
                return "Married";
            }
            return "";
        }

        private void ClearFields()
        {
            txt_userid.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtaddress.Text = " ";
            rdsingle.Checked = false;
            rdmarried.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


