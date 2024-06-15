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
    public partial class FORGOT_PASSWORD : Form
    {
        DBConnection conn = new DBConnection();

        public FORGOT_PASSWORD()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(dateTimePicker1.Text);
            long cnicNumber = long.Parse(textBox1.Text);

            bool isVerified = false;

            // Call the stored procedure to verify Date of Birth and CNIC
            //    using (SqlConnection connection = new SqlConnection("YourConnectionString"))
            {
                conn.OpenConnection();

                using (SqlCommand command = new SqlCommand("VerifyDOBAndCNIC", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@CNIC_No", cnicNumber);
                    command.Parameters.Add("@IsVerified", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    isVerified = (bool)command.Parameters["@IsVerified"].Value;
                }
            }

            if (isVerified)
            {
                // Navigate to the change password screen
                CHANGE_PASSWORD changePasswordForm = new CHANGE_PASSWORD();
                changePasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Date of Birth or CNIC Number. Please try again.");
            }
        }

        private void FORGOT_PASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
