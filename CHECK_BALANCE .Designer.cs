namespace BANKMS
{
    partial class CHECK_BALANCE
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
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button3 = new Button();
            label5 = new Label();
            lbl_balance = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 121);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "ACCOUNT NO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(146, 52);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 4;
            label1.Text = "CHECK BALANCE";
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(301, 114);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(91, 34);
            button3.TabIndex = 58;
            button3.Text = "DETAIL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 160);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 64;
            label5.Text = "Balance: ";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_balance.Location = new Point(176, 160);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(0, 15);
            lbl_balance.TabIndex = 65;
            // 
            // CHECK_BALANCE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 311);
            Controls.Add(lbl_balance);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CHECK_BALANCE";
            Text = "CHECK_BALANCE";
            Load += CHECK_BALANCE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Button button3;
        private Label label5;
        private Label lbl_balance;
    }
}