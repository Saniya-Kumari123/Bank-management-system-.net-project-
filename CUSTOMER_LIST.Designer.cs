namespace BANKMS
{
    partial class CUSTOMER_LIST
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
            button1 = new Button();
            dob = new DateTimePicker();
            lbldate = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(504, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dob
            // 
            dob.Location = new Point(298, 53);
            dob.Name = "dob";
            dob.Size = new Size(200, 23);
            dob.TabIndex = 8;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Location = new Point(200, 59);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(31, 15);
            lbldate.TabIndex = 7;
            lbldate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(302, 21);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 5;
            label1.Text = "CUSTOMER LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(575, 337);
            dataGridView1.TabIndex = 6;
            // 
            // CUSTOMER_LIST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dob);
            Controls.Add(lbldate);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CUSTOMER_LIST";
            Text = "CUSTOMER LIST";
            Load += CUSTOMER_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dob;
        private Label lbldate;
        private Label label1;
        private DataGridView dataGridView1;
    }
}