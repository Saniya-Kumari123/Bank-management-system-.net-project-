using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CHANGE_PASSWORD : Form
    {
        DBConnection conn = new DBConnection();

        public CHANGE_PASSWORD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                conn.OpenConnection();
                string UserName = textBox1.Text;
                string newPassword = textBox2.Text;
                string confirmPassword = textBox3.Text;

                SqlCommand cmd = new SqlCommand("Change_Password", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", UserName);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Password updated successfully.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
