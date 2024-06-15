namespace BANKMS
{
    partial class customer_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_dashboard));
            panel1 = new Panel();
            panel4 = new Panel();
            btn_ChangePassword = new Button();
            btn_Saving = new Button();
            btn_transfer = new Button();
            btn_checkBalance = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            txtLogo = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            txtTitle = new Label();
            txtUsername = new Label();
            pictureBox2 = new PictureBox();
            ChildScreens = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ChildScreens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 26, 48);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 562);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_ChangePassword);
            panel4.Controls.Add(btn_Saving);
            panel4.Controls.Add(btn_transfer);
            panel4.Controls.Add(btn_checkBalance);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 20, 0, 0);
            panel4.Size = new Size(209, 243);
            panel4.TabIndex = 2;
            // 
            // btn_ChangePassword
            // 
            btn_ChangePassword.Dock = DockStyle.Top;
            btn_ChangePassword.FlatAppearance.BorderSize = 0;
            btn_ChangePassword.FlatStyle = FlatStyle.Flat;
            btn_ChangePassword.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangePassword.ForeColor = Color.FromArgb(221, 242, 253);
            btn_ChangePassword.Location = new Point(0, 146);
            btn_ChangePassword.Name = "btn_ChangePassword";
            btn_ChangePassword.Size = new Size(209, 42);
            btn_ChangePassword.TabIndex = 6;
            btn_ChangePassword.Text = "Change Password";
            btn_ChangePassword.UseVisualStyleBackColor = true;
            btn_ChangePassword.Click += btn_ChangePassword_Click_1;
            // 
            // btn_Saving
            // 
            btn_Saving.Dock = DockStyle.Top;
            btn_Saving.FlatAppearance.BorderSize = 0;
            btn_Saving.FlatStyle = FlatStyle.Flat;
            btn_Saving.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Saving.ForeColor = Color.FromArgb(221, 242, 253);
            btn_Saving.Location = new Point(0, 104);
            btn_Saving.Name = "btn_Saving";
            btn_Saving.Size = new Size(209, 42);
            btn_Saving.TabIndex = 5;
            btn_Saving.Text = "Saving Account";
            btn_Saving.UseVisualStyleBackColor = true;
            btn_Saving.Click += btn_Saving_Click_1;
            // 
            // btn_transfer
            // 
            btn_transfer.Dock = DockStyle.Top;
            btn_transfer.FlatAppearance.BorderSize = 0;
            btn_transfer.FlatStyle = FlatStyle.Flat;
            btn_transfer.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_transfer.ForeColor = Color.FromArgb(221, 242, 253);
            btn_transfer.Location = new Point(0, 62);
            btn_transfer.Name = "btn_transfer";
            btn_transfer.Size = new Size(209, 42);
            btn_transfer.TabIndex = 4;
            btn_transfer.Text = "Transfer";
            btn_transfer.UseVisualStyleBackColor = true;
            btn_transfer.Click += btn_transfer_Click;
            // 
            // btn_checkBalance
            // 
            btn_checkBalance.Dock = DockStyle.Top;
            btn_checkBalance.FlatAppearance.BorderSize = 0;
            btn_checkBalance.FlatStyle = FlatStyle.Flat;
            btn_checkBalance.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_checkBalance.ForeColor = Color.FromArgb(221, 242, 253);
            btn_checkBalance.Location = new Point(0, 20);
            btn_checkBalance.Name = "btn_checkBalance";
            btn_checkBalance.Size = new Size(209, 42);
            btn_checkBalance.TabIndex = 3;
            btn_checkBalance.Text = "Check Balance";
            btn_checkBalance.UseVisualStyleBackColor = true;
            btn_checkBalance.Click += btn_checkBalance_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 482);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 80);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(221, 242, 253);
            button1.Location = new Point(0, 38);
            button1.Name = "button1";
            button1.Size = new Size(209, 42);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 48, 77);
            panel2.Controls.Add(txtLogo);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 80);
            panel2.TabIndex = 0;
            // 
            // txtLogo
            // 
            txtLogo.AutoSize = true;
            txtLogo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogo.ForeColor = Color.FromArgb(221, 242, 253);
            txtLogo.Location = new Point(121, 30);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(82, 20);
            txtLogo.TabIndex = 5;
            txtLogo.Text = "SK Bank";
            txtLogo.Click += txtLogo_Click;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(29, 14);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(76, 53);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(22, 26, 48);
            panel5.Controls.Add(txtTitle);
            panel5.Controls.Add(txtUsername);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(209, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 80);
            panel5.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(221, 242, 253);
            txtTitle.Location = new Point(67, 21);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(142, 28);
            txtTitle.TabIndex = 5;
            txtTitle.Text = "Dashboard";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(221, 242, 253);
            txtUsername.Location = new Point(670, 29);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(93, 20);
            txtUsername.TabIndex = 4;
            txtUsername.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(594, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // ChildScreens
            // 
            ChildScreens.Controls.Add(pictureBox1);
            ChildScreens.Dock = DockStyle.Fill;
            ChildScreens.Location = new Point(209, 80);
            ChildScreens.Name = "ChildScreens";
            ChildScreens.Size = new Size(834, 482);
            ChildScreens.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(849, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // customer_dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1043, 562);
            Controls.Add(ChildScreens);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "customer_dashboard";
            Text = "Customer Dashboard";
            Load += customer_dashboard_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ChildScreens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Label txtLogo;
        private Panel panel6;
        private Panel ChildScreens;
        private Label txtUsername;
        private PictureBox pictureBox2;
        private Label txtTitle;
        private Button btn_Saving;
        private Button btn_transfer;
        private Button btn_checkBalance;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btn_ChangePassword;
    }
}