namespace BANKMS
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            lbl_forgetPass = new Label();
            btn_login = new Button();
            lbl_register = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(356, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 139);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(311, 19);
            label1.Name = "label1";
            label1.Size = new Size(302, 23);
            label1.TabIndex = 2;
            label1.Text = "BANK MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(356, 228);
            label3.Name = "label3";
            label3.Size = new Size(65, 16);
            label3.TabIndex = 4;
            label3.Text = "USERNAME ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(356, 274);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 5;
            label4.Text = "PASSWORD";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(436, 228);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 7;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(436, 272);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(100, 23);
            tb_password.TabIndex = 8;
            // 
            // lbl_forgetPass
            // 
            lbl_forgetPass.AutoSize = true;
            lbl_forgetPass.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_forgetPass.ForeColor = Color.Blue;
            lbl_forgetPass.Location = new Point(550, 326);
            lbl_forgetPass.Name = "lbl_forgetPass";
            lbl_forgetPass.Size = new Size(155, 16);
            lbl_forgetPass.TabIndex = 10;
            lbl_forgetPass.Text = "FORGOT PASSWORD?";
            lbl_forgetPass.Click += lbl_forgetPass_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Honeydew;
            btn_login.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_login.Location = new Point(436, 326);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 33);
            btn_login.TabIndex = 59;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_register.ForeColor = Color.Blue;
            lbl_register.Location = new Point(550, 344);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(164, 16);
            lbl_register.TabIndex = 60;
            lbl_register.Text = "NEW USER? REGISTER";
            lbl_register.Click += lbl_register_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_register);
            Controls.Add(btn_login);
            Controls.Add(lbl_forgetPass);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LOGIN";
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label lbl_forgetPass;
        private Button btn_login;
        private Label lbl_register;
    }
}