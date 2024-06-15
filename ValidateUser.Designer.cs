namespace BANKMS
{
    partial class ValidateUser
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
            btn_validate = new Button();
            label4 = new Label();
            tb_UC = new TextBox();
            label3 = new Label();
            tb_PhoneNo = new TextBox();
            label2 = new Label();
            tb_accNum = new TextBox();
            label1 = new Label();
            tb_cnic = new TextBox();
            SuspendLayout();
            // 
            // btn_validate
            // 
            btn_validate.Location = new Point(336, 254);
            btn_validate.Margin = new Padding(3, 2, 3, 2);
            btn_validate.Name = "btn_validate";
            btn_validate.Size = new Size(82, 22);
            btn_validate.TabIndex = 17;
            btn_validate.Text = "Validate";
            btn_validate.UseVisualStyleBackColor = true;
            btn_validate.Click += btn_validate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 202);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 16;
            label4.Text = "Unique Code";
            // 
            // tb_UC
            // 
            tb_UC.Location = new Point(336, 202);
            tb_UC.Margin = new Padding(3, 2, 3, 2);
            tb_UC.Name = "tb_UC";
            tb_UC.Size = new Size(125, 23);
            tb_UC.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 163);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 14;
            label3.Text = "Phone No.";
            // 
            // tb_PhoneNo
            // 
            tb_PhoneNo.Location = new Point(336, 160);
            tb_PhoneNo.Margin = new Padding(3, 2, 3, 2);
            tb_PhoneNo.Name = "tb_PhoneNo";
            tb_PhoneNo.Size = new Size(125, 23);
            tb_PhoneNo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 122);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 12;
            label2.Text = "Account Number";
            // 
            // tb_accNum
            // 
            tb_accNum.Location = new Point(336, 122);
            tb_accNum.Margin = new Padding(3, 2, 3, 2);
            tb_accNum.Name = "tb_accNum";
            tb_accNum.Size = new Size(125, 23);
            tb_accNum.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 80);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 10;
            label1.Text = "CNIC";
            // 
            // tb_cnic
            // 
            tb_cnic.Location = new Point(336, 80);
            tb_cnic.Margin = new Padding(3, 2, 3, 2);
            tb_cnic.Name = "tb_cnic";
            tb_cnic.Size = new Size(125, 23);
            tb_cnic.TabIndex = 9;
            // 
            // ValidateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_validate);
            Controls.Add(label4);
            Controls.Add(tb_UC);
            Controls.Add(label3);
            Controls.Add(tb_PhoneNo);
            Controls.Add(label2);
            Controls.Add(tb_accNum);
            Controls.Add(label1);
            Controls.Add(tb_cnic);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ValidateUser";
            Text = "ValidateUser";
            Load += ValidateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_validate;
        private Label label4;
        private TextBox tb_UC;
        private Label label3;
        private TextBox tb_PhoneNo;
        private Label label2;
        private TextBox tb_accNum;
        private Label label1;
        private TextBox tb_cnic;
    }
}