namespace BANKMS
{
    partial class TRANSFER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRANSFER));
            btn_reciever = new Button();
            btn_sender = new Button();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            btntranfer = new Button();
            txtsender = new TextBox();
            panel1 = new Panel();
            txtreceiver = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            TXTAMOUNT = new TextBox();
            label1 = new Label();
            lbl_rlastname = new Label();
            lbl_rfirstanme = new Label();
            lbl_slastname = new Label();
            lbl_sfirstname = new Label();
            SuspendLayout();
            // 
            // btn_reciever
            // 
            btn_reciever.Location = new Point(379, 215);
            btn_reciever.Name = "btn_reciever";
            btn_reciever.Size = new Size(75, 23);
            btn_reciever.TabIndex = 83;
            btn_reciever.Text = "Detail";
            btn_reciever.UseMnemonic = false;
            btn_reciever.UseVisualStyleBackColor = true;
            btn_reciever.Click += btn_reciever_Click;
            // 
            // btn_sender
            // 
            btn_sender.Location = new Point(390, 125);
            btn_sender.Name = "btn_sender";
            btn_sender.Size = new Size(75, 23);
            btn_sender.TabIndex = 82;
            btn_sender.Text = "Detail";
            btn_sender.UseMnemonic = false;
            btn_sender.UseVisualStyleBackColor = true;
            btn_sender.Click += btn_sender_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(83, 281);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 81;
            label7.Text = "lastname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(83, 251);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 80;
            label6.Text = "firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 161);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 79;
            label2.Text = "firstname";
            // 
            // btntranfer
            // 
            btntranfer.BackColor = Color.Honeydew;
            btntranfer.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btntranfer.Location = new Point(360, 335);
            btntranfer.Name = "btntranfer";
            btntranfer.Size = new Size(75, 29);
            btntranfer.TabIndex = 78;
            btntranfer.Text = "TRANSER";
            btntranfer.UseVisualStyleBackColor = false;
            btntranfer.Click += btntranfer_Click;
            // 
            // txtsender
            // 
            txtsender.Location = new Point(237, 125);
            txtsender.Name = "txtsender";
            txtsender.Size = new Size(100, 21);
            txtsender.TabIndex = 76;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(511, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 200);
            panel1.TabIndex = 66;
            // 
            // txtreceiver
            // 
            txtreceiver.Location = new Point(237, 215);
            txtreceiver.Name = "txtreceiver";
            txtreceiver.Size = new Size(100, 21);
            txtreceiver.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 125);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 67;
            label3.Text = "ACCOUNT NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 190);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 68;
            label4.Text = "lastname";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 224);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 70;
            label8.Text = "ACCOUNT NO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 314);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 69;
            label5.Text = "tranfer amont";
            // 
            // TXTAMOUNT
            // 
            TXTAMOUNT.Location = new Point(237, 305);
            TXTAMOUNT.Name = "TXTAMOUNT";
            TXTAMOUNT.Size = new Size(100, 21);
            TXTAMOUNT.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(211, 49);
            label1.Name = "label1";
            label1.Size = new Size(124, 24);
            label1.TabIndex = 65;
            label1.Text = "TRANSFER";
            // 
            // lbl_rlastname
            // 
            lbl_rlastname.AutoSize = true;
            lbl_rlastname.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_rlastname.Location = new Point(237, 281);
            lbl_rlastname.Name = "lbl_rlastname";
            lbl_rlastname.Size = new Size(0, 15);
            lbl_rlastname.TabIndex = 84;
            // 
            // lbl_rfirstanme
            // 
            lbl_rfirstanme.AutoSize = true;
            lbl_rfirstanme.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_rfirstanme.Location = new Point(237, 251);
            lbl_rfirstanme.Name = "lbl_rfirstanme";
            lbl_rfirstanme.Size = new Size(0, 15);
            lbl_rfirstanme.TabIndex = 85;
            // 
            // lbl_slastname
            // 
            lbl_slastname.AutoSize = true;
            lbl_slastname.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_slastname.Location = new Point(237, 181);
            lbl_slastname.Name = "lbl_slastname";
            lbl_slastname.Size = new Size(0, 15);
            lbl_slastname.TabIndex = 86;
            // 
            // lbl_sfirstname
            // 
            lbl_sfirstname.AutoSize = true;
            lbl_sfirstname.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sfirstname.Location = new Point(237, 161);
            lbl_sfirstname.Name = "lbl_sfirstname";
            lbl_sfirstname.Size = new Size(0, 15);
            lbl_sfirstname.TabIndex = 87;
            // 
            // TRANSFER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(785, 440);
            Controls.Add(lbl_sfirstname);
            Controls.Add(lbl_slastname);
            Controls.Add(lbl_rfirstanme);
            Controls.Add(lbl_rlastname);
            Controls.Add(btn_reciever);
            Controls.Add(btn_sender);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btntranfer);
            Controls.Add(txtsender);
            Controls.Add(panel1);
            Controls.Add(txtreceiver);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(TXTAMOUNT);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "TRANSFER";
            Text = "TRANSFER";
            Load += TRANSFER_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_reciever;
        private Button btn_sender;
        private Label label7;
        private Label label6;
        private Label label2;
        private Button btntranfer;
        private TextBox txtsender;
        private Panel panel1;
        private TextBox txtreceiver;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label5;
        private TextBox TXTAMOUNT;
        private Label label1;
        private Label lbl_rlastname;
        private Label lbl_rfirstanme;
        private Label lbl_slastname;
        private Label lbl_sfirstname;
    }
}