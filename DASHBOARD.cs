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
    public partial class DASHBOARD : Form
    {
        DBConnection conn = new DBConnection();
        int userID = GlobalVariable.UserID;
        private Form activeForm;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DASHBOARD()
        {
            InitializeComponent();
            activeForm = new Form();
            Shown += adminDashboard_Shown;
        }
        private void adminDashboard_Shown(object sender, EventArgs e)
        {
            SetLabelText();
            UpdateDashboard();
        }
        private void SetLabelText()
        {
            txtUsername.Text = FirstName + " " + LastName;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildScreens.Controls.Add(childForm);
            this.ChildScreens.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            txtTitle.Text = childForm.Text;
        }


        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewAccount(), sender);

        }

        private void btn_updateInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateInformation(), sender);

        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CUSTOMER_LIST(), sender);

        }

        private void btn_BalanceSheet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BALANCE_SHEET(), sender);

        }

        private void btn_Deposite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DEPOSIT(), sender);

        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WITHDRAW(), sender);

        }


        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CHANGE_PASSWORD(), sender);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                LOGIN loginForm = new LOGIN(); // Replace LoginForm with your actual login form class name
                loginForm.Show();
                this.Hide();
            }
        }

        private void btn_calcIR_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();

            try
            {
                using (SqlCommand command = new SqlCommand("CalculateMoneyEarnedOnInterest3", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();

                    MessageBox.Show("All the saving account earning updated successfully.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.CloseConnection(); }
        }
        private void UpdateDashboard()
        {
            conn.OpenConnection();

            try
            {
                using (SqlCommand command = new SqlCommand("AdminDashboard", conn.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Create SqlDataReader to retrieve the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Retrieve calculated values from the resultset
                                int totalCustomers = Convert.ToInt32(reader["TotalCustomers"]);
                                int totalSavingsAccounts = Convert.ToInt32(reader["TotalSavingsAccounts"]);
                                int totalCheckingAccounts = Convert.ToInt32(reader["TotalCheckingAccounts"]);
                                decimal totalBalance = Convert.ToDecimal(reader["TotalBalance"]);

                                // Update the text of your text boxes or labels
                                lbl_customer.Text = totalCustomers.ToString();
                                lbl_sAccount.Text = totalSavingsAccounts.ToString();
                                lbl_CAccount.Text = totalCheckingAccounts.ToString();
                                lbl_Balance.Text = totalBalance.ToString("C");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
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
}
// Then, you can call this method wherever you need to update the dashboard




