namespace BANKMS
{
    partial class NewUserRegsitration
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
            lbl_Name = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_register = new Button();
            label3 = new Label();
            tb_ConfirmPassword = new TextBox();
            label2 = new Label();
            tb_password = new TextBox();
            label1 = new Label();
            tb_username = new TextBox();
            SuspendLayout();
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(347, 30);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(0, 15);
            lbl_Name.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(239, 26);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 15;
            label4.Text = "WELCOME!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(164, 82);
            label5.Name = "label5";
            label5.Size = new Size(408, 17);
            label5.TabIndex = 24;
            label5.Text = "please enter username and password to confirm your registration";
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_register.Location = new Point(366, 263);
            btn_register.Margin = new Padding(3, 2, 3, 2);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(82, 22);
            btn_register.TabIndex = 23;
            btn_register.Text = "Regsiter";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(177, 226);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 22;
            label3.Text = "Confirm Password";
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Location = new Point(324, 223);
            tb_ConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.Size = new Size(125, 23);
            tb_ConfirmPassword.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(226, 185);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 20;
            label2.Text = "Password";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(324, 185);
            tb_password.Margin = new Padding(3, 2, 3, 2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(125, 23);
            tb_password.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 143);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 18;
            label1.Text = "Username";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(324, 143);
            tb_username.Margin = new Padding(3, 2, 3, 2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(125, 23);
            tb_username.TabIndex = 17;
            // 
            // NewUserRegsitration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(btn_register);
            Controls.Add(label3);
            Controls.Add(tb_ConfirmPassword);
            Controls.Add(label2);
            Controls.Add(tb_password);
            Controls.Add(label1);
            Controls.Add(tb_username);
            Controls.Add(lbl_Name);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewUserRegsitration";
            Text = "NewUserRegsitration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Name;
        private Label label4;
        private Label label5;
        private Button btn_register;
        private Label label3;
        private TextBox tb_ConfirmPassword;
        private Label label2;
        private TextBox tb_password;
        private Label label1;
        private TextBox tb_username;
    }
}