namespace BANKMS
{
    partial class SAVING_ACCOUNT
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
            button2 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_openingbalance = new Label();
            lbl_totalearning = new Label();
            lbl_currentbalance = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(376, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 67;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(131, 169);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 63;
            label7.Text = "Total Earning";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(131, 137);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 62;
            label5.Text = "Opening Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(131, 99);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 61;
            label4.Text = "ACCOUNT NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(188, 42);
            label2.Name = "label2";
            label2.Size = new Size(197, 24);
            label2.TabIndex = 60;
            label2.Text = "SAVING ACCOUNT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 207);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 69;
            label1.Text = "CURRENT BALANCE";
            label1.Click += label1_Click;
            // 
            // lbl_openingbalance
            // 
            lbl_openingbalance.AutoSize = true;
            lbl_openingbalance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_openingbalance.Location = new Point(251, 137);
            lbl_openingbalance.Name = "lbl_openingbalance";
            lbl_openingbalance.Size = new Size(0, 15);
            lbl_openingbalance.TabIndex = 70;
            // 
            // lbl_totalearning
            // 
            lbl_totalearning.AutoSize = true;
            lbl_totalearning.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totalearning.Location = new Point(251, 169);
            lbl_totalearning.Name = "lbl_totalearning";
            lbl_totalearning.Size = new Size(0, 15);
            lbl_totalearning.TabIndex = 71;
            // 
            // lbl_currentbalance
            // 
            lbl_currentbalance.AutoSize = true;
            lbl_currentbalance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_currentbalance.Location = new Point(251, 207);
            lbl_currentbalance.Name = "lbl_currentbalance";
            lbl_currentbalance.Size = new Size(0, 15);
            lbl_currentbalance.TabIndex = 72;
            // 
            // SAVING_ACCOUNT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 325);
            Controls.Add(lbl_currentbalance);
            Controls.Add(lbl_totalearning);
            Controls.Add(lbl_openingbalance);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "SAVING_ACCOUNT";
            Text = "SAVING_ACCOUNT";
            Load += SAVING_ACCOUNT_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lbl_openingbalance;
        private Label lbl_totalearning;
        private Label lbl_currentbalance;
    }
}