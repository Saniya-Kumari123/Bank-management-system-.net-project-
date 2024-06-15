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
    public partial class NewUserRegsitration : Form
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public NewUserRegsitration()
        {
            InitializeComponent();
            Shown += NewUserRegsitration_Shown;
        }
        private void NewUserRegsitration_Shown(object sender, EventArgs e)
        {
            SetLabelText();
        }
        private void SetLabelText()
        {
            lbl_Name.Text = FirstName + " " + LastName;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            conn.OpenConnection();

            int userID = UserID;
            string username = tb_username.Text;
            string password = tb_password.Text;
            SqlCommand command = new SqlCommand("InsertNewUserLogin", conn.GetConnection());

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", userID); // Assuming you have the user ID
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            SqlParameter resultCodeParameter = new SqlParameter("@ResultCode", SqlDbType.Int);
            resultCodeParameter.Direction = ParameterDirection.Output;
            command.Parameters.Add(resultCodeParameter);

            command.ExecuteNonQuery();

            int resultCode = Convert.ToInt32(resultCodeParameter.Value);

            if (resultCode == 0)
            {
                MessageBox.Show("Account Created! You can now login into our application.");
                LOGIN login = new LOGIN();
                this.Hide();
                login.Show();
            }
            else if (resultCode == -1)
            {
                MessageBox.Show("Username is already taken. Please choose another username.");
            }
            else
            {
                MessageBox.Show("Something went wrong! Please try Again");

            }
        }
    }
}
