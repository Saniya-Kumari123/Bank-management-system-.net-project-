namespace BANKMS
{
    partial class WITHDRAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WITHDRAW));
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lbl_Balance = new Label();
            lblLastName = new Label();
            lbl_FirstName = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(93, 314);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 5;
            label6.Text = "WITHDRAW MONEY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(326, 39);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 0;
            label1.Text = "WITHDRAW";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(457, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 266);
            panel1.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(322, 265);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 56;
            button3.Text = "DETAIL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Honeydew;
            button2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(326, 310);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 57;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 60;
            label5.Text = "BALANCE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 265);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 58;
            label3.Text = "ACCOUNT NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 144);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 59;
            label4.Text = "firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 188);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 61;
            label2.Text = "lastname";
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Balance.Location = new Point(216, 221);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(0, 15);
            lbl_Balance.TabIndex = 62;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(216, 179);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 15);
            lblLastName.TabIndex = 63;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.Location = new Point(216, 144);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(0, 15);
            lbl_FirstName.TabIndex = 64;
            // 
            // WITHDRAW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_FirstName);
            Controls.Add(lblLastName);
            Controls.Add(lbl_Balance);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Name = "WITHDRAW";
            Text = "WITHDRAW";
            Load += WITHDRAW_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox3;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lbl_Balance;
        private Label lblLastName;
        private Label lbl_FirstName;
    }
}