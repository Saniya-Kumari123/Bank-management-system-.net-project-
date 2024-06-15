namespace BANKMS
{
    partial class DEPOSIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEPOSIT));
            button3 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            lbl_lastName = new Label();
            lbl_firstName = new Label();
            lbl_Balance = new Label();
            btn_deposit = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(349, 335);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 69;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(236, 379);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 67;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(117, 383);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 64;
            label6.Text = "MONEY DEPOSIT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(472, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 215);
            panel1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(348, 66);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 60;
            label1.Text = "DEPOSIT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(159, 236);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 63;
            label5.Text = "Balance: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 200);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 71;
            label2.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(144, 163);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 72;
            label4.Text = "First Name: ";
            // 
            // lbl_lastName
            // 
            lbl_lastName.AutoSize = true;
            lbl_lastName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_lastName.Location = new Point(231, 200);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(0, 15);
            lbl_lastName.TabIndex = 73;
            // 
            // lbl_firstName
            // 
            lbl_firstName.AutoSize = true;
            lbl_firstName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_firstName.Location = new Point(231, 163);
            lbl_firstName.Name = "lbl_firstName";
            lbl_firstName.Size = new Size(0, 15);
            lbl_firstName.TabIndex = 74;
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Balance.Location = new Point(231, 236);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(0, 15);
            lbl_Balance.TabIndex = 75;
            // 
            // btn_deposit
            // 
            btn_deposit.BackColor = Color.Honeydew;
            btn_deposit.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_deposit.Location = new Point(349, 379);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.Size = new Size(75, 23);
            btn_deposit.TabIndex = 76;
            btn_deposit.Text = "DEPOSIT";
            btn_deposit.UseVisualStyleBackColor = false;
            btn_deposit.Click += btn_deposit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(117, 339);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 77;
            label7.Text = "Account Number: ";
            // 
            // DEPOSIT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btn_deposit);
            Controls.Add(lbl_Balance);
            Controls.Add(lbl_firstName);
            Controls.Add(lbl_lastName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "DEPOSIT";
            Text = "DEPOSIT ";
            Load += DEPOSIT_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label lbl_lastName;
        private Label lbl_firstName;
        private Label lbl_Balance;
        private Button btn_deposit;
        private Label label7;
    }
}