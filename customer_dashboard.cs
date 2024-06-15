using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKMS
{

    public partial class customer_dashboard : Form
    {
        int userID = GlobalVariable.UserID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Form activeForm;
        public customer_dashboard()
        {
            InitializeComponent();
            activeForm = new Form();
            Shown += customerDashboard_Shown;
        }
        private void customerDashboard_Shown(object sender, EventArgs e)
        {
            SetLabelText();
        }
        private void SetLabelText()
        {
            txtUsername.Text = FirstName + " " + LastName;
        }

        private void customer_dashboard_Load(object sender, EventArgs e)
        {

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

        private void btn_checkBalance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CHECK_BALANCE(), sender);

        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TRANSFER(), sender);
        }

        private void btn_Saving_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SAVING_ACCOUNT(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                LOGIN loginForm = new LOGIN(); // Replace LoginForm with your actual login form class name
                loginForm.Show();
                this.Hide();
            }
        }

        private void btn_ChangePassword_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new CHANGE_PASSWORD(), sender);
        }

        private void btn_Saving_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SAVING_ACCOUNT(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
