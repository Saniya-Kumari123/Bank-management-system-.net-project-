namespace BANKMS
{
    partial class DASHBOARD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
            SideBar = new Panel();
            panel1 = new Panel();
            btn_Logout = new Button();
            MenuBar = new Panel();
            btn_calcIR = new Button();
            btn_ChangePass = new Button();
            btn_Withdraw = new Button();
            btn_Deposite = new Button();
            btn_BalanceSheet = new Button();
            btn_CustomerList = new Button();
            btn_updateInfo = new Button();
            btn_createAcc = new Button();
            PanelLogo = new Panel();
            txtLogo = new Label();
            panel3 = new Panel();
            panelHeader = new Panel();
            txtUsername = new Label();
            pictureBox2 = new PictureBox();
            txtTitle = new Label();
            ChildScreens = new Panel();
            lbl_sAccount = new Label();
            lbl_Balance = new Label();
            lbl_CAccount = new Label();
            lbl_customer = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl_Totcust = new Label();
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            MenuBar.SuspendLayout();
            PanelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ChildScreens.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(22, 26, 48);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(MenuBar);
            SideBar.Controls.Add(PanelLogo);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Margin = new Padding(3, 2, 3, 2);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(219, 562);
            SideBar.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Logout);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 524);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 38);
            panel1.TabIndex = 2;
            // 
            // btn_Logout
            // 
            btn_Logout.Dock = DockStyle.Top;
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.FromArgb(221, 242, 253);
            btn_Logout.Location = new Point(0, 0);
            btn_Logout.Margin = new Padding(3, 2, 3, 2);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(219, 32);
            btn_Logout.TabIndex = 9;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // MenuBar
            // 
            MenuBar.Controls.Add(btn_calcIR);
            MenuBar.Controls.Add(btn_ChangePass);
            MenuBar.Controls.Add(btn_Withdraw);
            MenuBar.Controls.Add(btn_Deposite);
            MenuBar.Controls.Add(btn_BalanceSheet);
            MenuBar.Controls.Add(btn_CustomerList);
            MenuBar.Controls.Add(btn_updateInfo);
            MenuBar.Controls.Add(btn_createAcc);
            MenuBar.Dock = DockStyle.Top;
            MenuBar.Location = new Point(0, 60);
            MenuBar.Margin = new Padding(3, 2, 3, 2);
            MenuBar.Name = "MenuBar";
            MenuBar.Padding = new Padding(0, 8, 0, 0);
            MenuBar.Size = new Size(219, 366);
            MenuBar.TabIndex = 1;
            // 
            // btn_calcIR
            // 
            btn_calcIR.Dock = DockStyle.Top;
            btn_calcIR.FlatAppearance.BorderSize = 0;
            btn_calcIR.FlatStyle = FlatStyle.Flat;
            btn_calcIR.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcIR.ForeColor = Color.FromArgb(221, 242, 253);
            btn_calcIR.Location = new Point(0, 232);
            btn_calcIR.Margin = new Padding(3, 2, 3, 2);
            btn_calcIR.Name = "btn_calcIR";
            btn_calcIR.Size = new Size(219, 32);
            btn_calcIR.TabIndex = 12;
            btn_calcIR.Text = "Calculate Interest";
            btn_calcIR.UseVisualStyleBackColor = true;
            btn_calcIR.Click += btn_calcIR_Click;
            // 
            // btn_ChangePass
            // 
            btn_ChangePass.Dock = DockStyle.Top;
            btn_ChangePass.FlatAppearance.BorderSize = 0;
            btn_ChangePass.FlatStyle = FlatStyle.Flat;
            btn_ChangePass.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangePass.ForeColor = Color.FromArgb(221, 242, 253);
            btn_ChangePass.Location = new Point(0, 200);
            btn_ChangePass.Margin = new Padding(3, 2, 3, 2);
            btn_ChangePass.Name = "btn_ChangePass";
            btn_ChangePass.Size = new Size(219, 32);
            btn_ChangePass.TabIndex = 11;
            btn_ChangePass.Text = "Change Password";
            btn_ChangePass.UseVisualStyleBackColor = true;
            btn_ChangePass.Click += btn_ChangePass_Click;
            // 
            // btn_Withdraw
            // 
            btn_Withdraw.Dock = DockStyle.Top;
            btn_Withdraw.FlatAppearance.BorderSize = 0;
            btn_Withdraw.FlatStyle = FlatStyle.Flat;
            btn_Withdraw.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Withdraw.ForeColor = Color.FromArgb(221, 242, 253);
            btn_Withdraw.Location = new Point(0, 168);
            btn_Withdraw.Margin = new Padding(3, 2, 3, 2);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.Size = new Size(219, 32);
            btn_Withdraw.TabIndex = 9;
            btn_Withdraw.Text = "Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = true;
            btn_Withdraw.Click += btn_Withdraw_Click;
            // 
            // btn_Deposite
            // 
            btn_Deposite.Dock = DockStyle.Top;
            btn_Deposite.FlatAppearance.BorderSize = 0;
            btn_Deposite.FlatStyle = FlatStyle.Flat;
            btn_Deposite.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Deposite.ForeColor = Color.FromArgb(221, 242, 253);
            btn_Deposite.Location = new Point(0, 136);
            btn_Deposite.Margin = new Padding(3, 2, 3, 2);
            btn_Deposite.Name = "btn_Deposite";
            btn_Deposite.Size = new Size(219, 32);
            btn_Deposite.TabIndex = 8;
            btn_Deposite.Text = "Deposite";
            btn_Deposite.UseVisualStyleBackColor = true;
            btn_Deposite.Click += btn_Deposite_Click;
            // 
            // btn_BalanceSheet
            // 
            btn_BalanceSheet.Dock = DockStyle.Top;
            btn_BalanceSheet.FlatAppearance.BorderSize = 0;
            btn_BalanceSheet.FlatStyle = FlatStyle.Flat;
            btn_BalanceSheet.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BalanceSheet.ForeColor = Color.FromArgb(221, 242, 253);
            btn_BalanceSheet.Location = new Point(0, 104);
            btn_BalanceSheet.Margin = new Padding(3, 2, 3, 2);
            btn_BalanceSheet.Name = "btn_BalanceSheet";
            btn_BalanceSheet.Size = new Size(219, 32);
            btn_BalanceSheet.TabIndex = 7;
            btn_BalanceSheet.Text = "Balance Sheet";
            btn_BalanceSheet.UseVisualStyleBackColor = true;
            btn_BalanceSheet.Click += btn_BalanceSheet_Click;
            // 
            // btn_CustomerList
            // 
            btn_CustomerList.Dock = DockStyle.Top;
            btn_CustomerList.FlatAppearance.BorderSize = 0;
            btn_CustomerList.FlatStyle = FlatStyle.Flat;
            btn_CustomerList.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CustomerList.ForeColor = Color.FromArgb(221, 242, 253);
            btn_CustomerList.Location = new Point(0, 72);
            btn_CustomerList.Margin = new Padding(3, 2, 3, 2);
            btn_CustomerList.Name = "btn_CustomerList";
            btn_CustomerList.Size = new Size(219, 32);
            btn_CustomerList.TabIndex = 3;
            btn_CustomerList.Text = "Customer List";
            btn_CustomerList.UseVisualStyleBackColor = true;
            btn_CustomerList.Click += btn_CustomerList_Click;
            // 
            // btn_updateInfo
            // 
            btn_updateInfo.Dock = DockStyle.Top;
            btn_updateInfo.FlatAppearance.BorderSize = 0;
            btn_updateInfo.FlatStyle = FlatStyle.Flat;
            btn_updateInfo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_updateInfo.ForeColor = Color.FromArgb(221, 242, 253);
            btn_updateInfo.Location = new Point(0, 40);
            btn_updateInfo.Margin = new Padding(3, 2, 3, 2);
            btn_updateInfo.Name = "btn_updateInfo";
            btn_updateInfo.Size = new Size(219, 32);
            btn_updateInfo.TabIndex = 2;
            btn_updateInfo.Text = "Update Information";
            btn_updateInfo.UseVisualStyleBackColor = true;
            btn_updateInfo.Click += btn_updateInfo_Click;
            // 
            // btn_createAcc
            // 
            btn_createAcc.Dock = DockStyle.Top;
            btn_createAcc.FlatAppearance.BorderSize = 0;
            btn_createAcc.FlatStyle = FlatStyle.Flat;
            btn_createAcc.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_createAcc.ForeColor = Color.FromArgb(221, 242, 253);
            btn_createAcc.Location = new Point(0, 8);
            btn_createAcc.Margin = new Padding(3, 2, 3, 2);
            btn_createAcc.Name = "btn_createAcc";
            btn_createAcc.Size = new Size(219, 32);
            btn_createAcc.TabIndex = 1;
            btn_createAcc.Text = "Create Account";
            btn_createAcc.UseVisualStyleBackColor = true;
            btn_createAcc.Click += btn_createAcc_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(49, 48, 77);
            PanelLogo.BackgroundImageLayout = ImageLayout.None;
            PanelLogo.Controls.Add(txtLogo);
            PanelLogo.Controls.Add(panel3);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(3, 2, 3, 2);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(219, 60);
            PanelLogo.TabIndex = 0;
            // 
            // txtLogo
            // 
            txtLogo.AutoSize = true;
            txtLogo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogo.ForeColor = Color.FromArgb(221, 242, 253);
            txtLogo.Location = new Point(103, 22);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(82, 20);
            txtLogo.TabIndex = 3;
            txtLogo.Text = "SK Bank";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(23, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(66, 40);
            panel3.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(22, 26, 48);
            panelHeader.Controls.Add(txtUsername);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(txtTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(219, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(824, 60);
            panelHeader.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Right;
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(221, 242, 253);
            txtUsername.Location = new Point(664, 24);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(93, 20);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(578, 5);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(221, 242, 253);
            txtTitle.Location = new Point(47, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(142, 28);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Dashboard";
            // 
            // ChildScreens
            // 
            ChildScreens.Controls.Add(lbl_sAccount);
            ChildScreens.Controls.Add(lbl_Balance);
            ChildScreens.Controls.Add(lbl_CAccount);
            ChildScreens.Controls.Add(lbl_customer);
            ChildScreens.Controls.Add(label4);
            ChildScreens.Controls.Add(label3);
            ChildScreens.Controls.Add(label2);
            ChildScreens.Controls.Add(lbl_Totcust);
            ChildScreens.Location = new Point(222, 60);
            ChildScreens.Name = "ChildScreens";
            ChildScreens.Size = new Size(824, 499);
            ChildScreens.TabIndex = 6;
            // 
            // lbl_sAccount
            // 
            lbl_sAccount.AutoSize = true;
            lbl_sAccount.Location = new Point(461, 152);
            lbl_sAccount.Name = "lbl_sAccount";
            lbl_sAccount.Size = new Size(0, 15);
            lbl_sAccount.TabIndex = 11;
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Location = new Point(461, 290);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(0, 15);
            lbl_Balance.TabIndex = 10;
            // 
            // lbl_CAccount
            // 
            lbl_CAccount.AutoSize = true;
            lbl_CAccount.Location = new Point(78, 279);
            lbl_CAccount.Name = "lbl_CAccount";
            lbl_CAccount.Size = new Size(0, 15);
            lbl_CAccount.TabIndex = 9;
            // 
            // lbl_customer
            // 
            lbl_customer.AutoSize = true;
            lbl_customer.Location = new Point(71, 152);
            lbl_customer.Name = "lbl_customer";
            lbl_customer.Size = new Size(0, 15);
            lbl_customer.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(439, 238);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 6;
            label4.Text = "TOTAL BALANCE ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(60, 239);
            label3.Name = "label3";
            label3.Size = new Size(285, 20);
            label3.TabIndex = 5;
            label3.Text = "TOTAL CHECKING ACCOUNTS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(439, 110);
            label2.Name = "label2";
            label2.Size = new Size(261, 20);
            label2.TabIndex = 4;
            label2.Text = "TOTAL SAVING ACCOUNTS ";
            // 
            // lbl_Totcust
            // 
            lbl_Totcust.Anchor = AnchorStyles.Right;
            lbl_Totcust.AutoSize = true;
            lbl_Totcust.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Totcust.ForeColor = Color.Black;
            lbl_Totcust.Location = new Point(60, 116);
            lbl_Totcust.Name = "lbl_Totcust";
            lbl_Totcust.Size = new Size(202, 20);
            lbl_Totcust.TabIndex = 3;
            lbl_Totcust.Text = "TOTAL  CUSTOMERS ";
            // 
            // DASHBOARD
            // 
            AccessibleRole = AccessibleRole.Caret;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            CausesValidation = false;
            ClientSize = new Size(1043, 562);
            Controls.Add(ChildScreens);
            Controls.Add(panelHeader);
            Controls.Add(SideBar);
            Name = "DASHBOARD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD";
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            MenuBar.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ChildScreens.ResumeLayout(false);
            ChildScreens.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel SideBar;
        private Panel PanelLogo;
        private Panel panelHeader;
        private Label txtLogo;
        private Button btn_createAcc;
        private Panel MenuBar;
        private Panel panel3;
        private Panel panel1;
        private Button btn_Logout;
        private Button btn_Deposite;
        private Button btn_BalanceSheet;
        private Button btn_CustomerList;
        private Button btn_updateInfo;
        private Button btn_Withdraw;
        private Button btn_ChangePass;
        private Label txtTitle;
        private Label txtUsername;
        private PictureBox pictureBox2;
        private Button btn_calcIR;
        private Panel ChildScreens;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_Totcust;
        private Label lbl_Balance;
        private Label lbl_CAccount;
        private Label lbl_customer;
        private Label lbl_sAccount;
    }
}