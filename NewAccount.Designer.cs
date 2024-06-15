namespace BANKMS
{
    partial class NewAccount
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
            tab_accountDetail = new TabControl();
            tb_PersonalInfo = new TabPage();
            label17 = new Label();
            DOB = new DateTimePicker();
            btn_next = new Button();
            groupBox2 = new GroupBox();
            rd_female = new RadioButton();
            rd_male = new RadioButton();
            groupBox1 = new GroupBox();
            rd_single = new RadioButton();
            rd_married = new RadioButton();
            label12 = new Label();
            label11 = new Label();
            tb_email = new TextBox();
            label10 = new Label();
            tb_nationality = new TextBox();
            label9 = new Label();
            tb_Address = new TextBox();
            label8 = new Label();
            tb_phoneNo = new TextBox();
            label7 = new Label();
            tb_cnic = new TextBox();
            label6 = new Label();
            tb_motherName = new TextBox();
            label5 = new Label();
            tb_fatherName = new TextBox();
            label4 = new Label();
            tb_LastName = new TextBox();
            label3 = new Label();
            tb_FirstName = new TextBox();
            label2 = new Label();
            cb_title = new ComboBox();
            label1 = new Label();
            tb_accountDetail = new TabPage();
            label15 = new Label();
            label16 = new Label();
            btn_createAcc = new Button();
            tb_OpeningBalance = new TextBox();
            cb_accountType = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            tab_accountDetail.SuspendLayout();
            tb_PersonalInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tb_accountDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tab_accountDetail
            // 
            tab_accountDetail.Controls.Add(tb_PersonalInfo);
            tab_accountDetail.Controls.Add(tb_accountDetail);
            tab_accountDetail.Dock = DockStyle.Fill;
            tab_accountDetail.Location = new Point(0, 0);
            tab_accountDetail.Margin = new Padding(3, 2, 3, 2);
            tab_accountDetail.Name = "tab_accountDetail";
            tab_accountDetail.SelectedIndex = 0;
            tab_accountDetail.Size = new Size(808, 502);
            tab_accountDetail.TabIndex = 0;
            // 
            // tb_PersonalInfo
            // 
            tb_PersonalInfo.Controls.Add(label17);
            tb_PersonalInfo.Controls.Add(DOB);
            tb_PersonalInfo.Controls.Add(btn_next);
            tb_PersonalInfo.Controls.Add(groupBox2);
            tb_PersonalInfo.Controls.Add(groupBox1);
            tb_PersonalInfo.Controls.Add(label12);
            tb_PersonalInfo.Controls.Add(label11);
            tb_PersonalInfo.Controls.Add(tb_email);
            tb_PersonalInfo.Controls.Add(label10);
            tb_PersonalInfo.Controls.Add(tb_nationality);
            tb_PersonalInfo.Controls.Add(label9);
            tb_PersonalInfo.Controls.Add(tb_Address);
            tb_PersonalInfo.Controls.Add(label8);
            tb_PersonalInfo.Controls.Add(tb_phoneNo);
            tb_PersonalInfo.Controls.Add(label7);
            tb_PersonalInfo.Controls.Add(tb_cnic);
            tb_PersonalInfo.Controls.Add(label6);
            tb_PersonalInfo.Controls.Add(tb_motherName);
            tb_PersonalInfo.Controls.Add(label5);
            tb_PersonalInfo.Controls.Add(tb_fatherName);
            tb_PersonalInfo.Controls.Add(label4);
            tb_PersonalInfo.Controls.Add(tb_LastName);
            tb_PersonalInfo.Controls.Add(label3);
            tb_PersonalInfo.Controls.Add(tb_FirstName);
            tb_PersonalInfo.Controls.Add(label2);
            tb_PersonalInfo.Controls.Add(cb_title);
            tb_PersonalInfo.Controls.Add(label1);
            tb_PersonalInfo.Location = new Point(4, 24);
            tb_PersonalInfo.Margin = new Padding(3, 2, 3, 2);
            tb_PersonalInfo.Name = "tb_PersonalInfo";
            tb_PersonalInfo.Padding = new Padding(3, 2, 3, 2);
            tb_PersonalInfo.Size = new Size(800, 474);
            tb_PersonalInfo.TabIndex = 0;
            tb_PersonalInfo.Text = "Personal Information";
            tb_PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(405, 116);
            label17.Name = "label17";
            label17.Size = new Size(34, 16);
            label17.TabIndex = 100;
            label17.Text = "DOB";
            // 
            // DOB
            // 
            DOB.Location = new Point(509, 113);
            DOB.Name = "DOB";
            DOB.Size = new Size(200, 23);
            DOB.TabIndex = 99;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Honeydew;
            btn_next.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_next.Location = new Point(592, 413);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(75, 23);
            btn_next.TabIndex = 91;
            btn_next.Text = "NEXT";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rd_female);
            groupBox2.Controls.Add(rd_male);
            groupBox2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(405, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 83);
            groupBox2.TabIndex = 76;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gender";
            // 
            // rd_female
            // 
            rd_female.AutoSize = true;
            rd_female.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_female.Location = new Point(140, 34);
            rd_female.Name = "rd_female";
            rd_female.Size = new Size(67, 20);
            rd_female.TabIndex = 1;
            rd_female.TabStop = true;
            rd_female.Text = "Female";
            rd_female.UseVisualStyleBackColor = true;
            // 
            // rd_male
            // 
            rd_male.AutoSize = true;
            rd_male.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_male.Location = new Point(16, 34);
            rd_male.Name = "rd_male";
            rd_male.Size = new Size(54, 20);
            rd_male.TabIndex = 0;
            rd_male.TabStop = true;
            rd_male.Text = "Male";
            rd_male.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_single);
            groupBox1.Controls.Add(rd_married);
            groupBox1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(405, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 76);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marital Status";
            // 
            // rd_single
            // 
            rd_single.AutoSize = true;
            rd_single.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_single.Location = new Point(140, 34);
            rd_single.Name = "rd_single";
            rd_single.Size = new Size(60, 20);
            rd_single.TabIndex = 1;
            rd_single.TabStop = true;
            rd_single.Text = "Single";
            rd_single.UseVisualStyleBackColor = true;
            // 
            // rd_married
            // 
            rd_married.AutoSize = true;
            rd_married.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_married.Location = new Point(16, 34);
            rd_married.Name = "rd_married";
            rd_married.Size = new Size(71, 20);
            rd_married.TabIndex = 0;
            rd_married.TabStop = true;
            rd_married.Text = "Married";
            rd_married.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(329, 64);
            label12.Name = "label12";
            label12.Size = new Size(160, 18);
            label12.TabIndex = 21;
            label12.Text = "Customer Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(323, 15);
            label11.Name = "label11";
            label11.Size = new Size(171, 28);
            label11.TabIndex = 20;
            label11.Text = "New Account";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(509, 192);
            tb_email.Margin = new Padding(3, 2, 3, 2);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(133, 23);
            tb_email.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(405, 196);
            label10.Name = "label10";
            label10.Size = new Size(41, 16);
            label10.TabIndex = 18;
            label10.Text = "Email";
            // 
            // tb_nationality
            // 
            tb_nationality.Location = new Point(509, 152);
            tb_nationality.Margin = new Padding(3, 2, 3, 2);
            tb_nationality.Name = "tb_nationality";
            tb_nationality.Size = new Size(133, 23);
            tb_nationality.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(405, 156);
            label9.Name = "label9";
            label9.Size = new Size(72, 16);
            label9.TabIndex = 16;
            label9.Text = "Nationality";
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(195, 407);
            tb_Address.Margin = new Padding(3, 2, 3, 2);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(133, 23);
            tb_Address.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(118, 409);
            label8.Name = "label8";
            label8.Size = new Size(53, 16);
            label8.TabIndex = 14;
            label8.Text = "Address";
            // 
            // tb_phoneNo
            // 
            tb_phoneNo.Location = new Point(195, 368);
            tb_phoneNo.Margin = new Padding(3, 2, 3, 2);
            tb_phoneNo.Name = "tb_phoneNo";
            tb_phoneNo.Size = new Size(133, 23);
            tb_phoneNo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(105, 369);
            label7.Name = "label7";
            label7.Size = new Size(63, 16);
            label7.TabIndex = 12;
            label7.Text = "Phone No.";
            // 
            // tb_cnic
            // 
            tb_cnic.Location = new Point(195, 328);
            tb_cnic.Margin = new Padding(3, 2, 3, 2);
            tb_cnic.Name = "tb_cnic";
            tb_cnic.Size = new Size(133, 23);
            tb_cnic.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(112, 329);
            label6.Name = "label6";
            label6.Size = new Size(61, 16);
            label6.TabIndex = 10;
            label6.Text = "CNIC No.";
            // 
            // tb_motherName
            // 
            tb_motherName.Location = new Point(195, 288);
            tb_motherName.Margin = new Padding(3, 2, 3, 2);
            tb_motherName.Name = "tb_motherName";
            tb_motherName.Size = new Size(133, 23);
            tb_motherName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(84, 290);
            label5.Name = "label5";
            label5.Size = new Size(85, 16);
            label5.TabIndex = 8;
            label5.Text = "Mother Name";
            // 
            // tb_fatherName
            // 
            tb_fatherName.Location = new Point(195, 248);
            tb_fatherName.Margin = new Padding(3, 2, 3, 2);
            tb_fatherName.Name = "tb_fatherName";
            tb_fatherName.Size = new Size(133, 23);
            tb_fatherName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 250);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 6;
            label4.Text = "Father Name";
            // 
            // tb_LastName
            // 
            tb_LastName.Location = new Point(195, 208);
            tb_LastName.Margin = new Padding(3, 2, 3, 2);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(133, 23);
            tb_LastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 210);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // tb_FirstName
            // 
            tb_FirstName.Location = new Point(195, 169);
            tb_FirstName.Margin = new Padding(3, 2, 3, 2);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(133, 23);
            tb_FirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 170);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // cb_title
            // 
            cb_title.FormattingEnabled = true;
            cb_title.Items.AddRange(new object[] { "Mr.", "Mrs." });
            cb_title.Location = new Point(195, 128);
            cb_title.Margin = new Padding(3, 2, 3, 2);
            cb_title.Name = "cb_title";
            cb_title.Size = new Size(133, 23);
            cb_title.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 130);
            label1.Name = "label1";
            label1.Size = new Size(34, 16);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // tb_accountDetail
            // 
            tb_accountDetail.Controls.Add(label15);
            tb_accountDetail.Controls.Add(label16);
            tb_accountDetail.Controls.Add(btn_createAcc);
            tb_accountDetail.Controls.Add(tb_OpeningBalance);
            tb_accountDetail.Controls.Add(cb_accountType);
            tb_accountDetail.Controls.Add(label13);
            tb_accountDetail.Controls.Add(label14);
            tb_accountDetail.Location = new Point(4, 24);
            tb_accountDetail.Margin = new Padding(3, 2, 3, 2);
            tb_accountDetail.Name = "tb_accountDetail";
            tb_accountDetail.Padding = new Padding(3, 2, 3, 2);
            tb_accountDetail.Size = new Size(800, 474);
            tb_accountDetail.TabIndex = 1;
            tb_accountDetail.Text = "Account Details";
            tb_accountDetail.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(337, 72);
            label15.Name = "label15";
            label15.Size = new Size(116, 18);
            label15.TabIndex = 23;
            label15.Text = "Account Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(309, 23);
            label16.Name = "label16";
            label16.Size = new Size(171, 28);
            label16.TabIndex = 22;
            label16.Text = "New Account";
            // 
            // btn_createAcc
            // 
            btn_createAcc.Location = new Point(244, 260);
            btn_createAcc.Name = "btn_createAcc";
            btn_createAcc.Size = new Size(75, 23);
            btn_createAcc.TabIndex = 9;
            btn_createAcc.Text = "Create";
            btn_createAcc.UseVisualStyleBackColor = true;
            btn_createAcc.Click += btn_createAcc_Click;
            // 
            // tb_OpeningBalance
            // 
            tb_OpeningBalance.Location = new Point(199, 182);
            tb_OpeningBalance.Name = "tb_OpeningBalance";
            tb_OpeningBalance.Size = new Size(121, 23);
            tb_OpeningBalance.TabIndex = 8;
            // 
            // cb_accountType
            // 
            cb_accountType.FormattingEnabled = true;
            cb_accountType.Items.AddRange(new object[] { "Saving", "Current" });
            cb_accountType.Location = new Point(199, 146);
            cb_accountType.Name = "cb_accountType";
            cb_accountType.Size = new Size(121, 23);
            cb_accountType.TabIndex = 7;
            cb_accountType.SelectedIndexChanged += cb_accountType_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(74, 185);
            label13.Name = "label13";
            label13.Size = new Size(90, 16);
            label13.TabIndex = 6;
            label13.Text = "Initial Balance";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(74, 150);
            label14.Name = "label14";
            label14.Size = new Size(81, 16);
            label14.TabIndex = 5;
            label14.Text = "Account Type";
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(808, 502);
            Controls.Add(tab_accountDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewAccount";
            Text = "New Account";
            Load += NewAccount_Load;
            tab_accountDetail.ResumeLayout(false);
            tb_PersonalInfo.ResumeLayout(false);
            tb_PersonalInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tb_accountDetail.ResumeLayout(false);
            tb_accountDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_accountDetail;
        private TabPage tb_PersonalInfo;
        private TabPage tb_accountDetail;
        private TextBox tb_email;
        private Label label10;
        private TextBox tb_nationality;
        private Label label9;
        private TextBox tb_Address;
        private Label label8;
        private TextBox tb_phoneNo;
        private Label label7;
        private TextBox tb_cnic;
        private Label label6;
        private TextBox tb_motherName;
        private Label label5;
        private TextBox tb_fatherName;
        private Label label4;
        private TextBox tb_LastName;
        private Label label3;
        private TextBox tb_FirstName;
        private Label label2;
        private ComboBox cb_title;
        private Label label1;
        private Button btn_next;
        private GroupBox groupBox2;
        private RadioButton rd_female;
        private RadioButton rd_male;
        private GroupBox groupBox1;
        private RadioButton rd_single;
        private RadioButton rd_married;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label16;
        private Button btn_createAcc;
        private TextBox tb_OpeningBalance;
        private ComboBox cb_accountType;
        private Label label13;
        private Label label14;
        private Label label17;
        private DateTimePicker DOB;
    }
}