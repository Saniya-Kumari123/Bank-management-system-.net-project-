namespace BANKMS
{
    partial class SEARCH_ACCOUNT
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            accountnumberlist = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 277);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 103);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "account number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(305, 29);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "SEARCH ACCOUNT";
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(443, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 57;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // accountnumberlist
            // 
            accountnumberlist.FormattingEnabled = true;
            accountnumberlist.ItemHeight = 15;
            accountnumberlist.Location = new Point(12, 174);
            accountnumberlist.Name = "accountnumberlist";
            accountnumberlist.Size = new Size(111, 274);
            accountnumberlist.TabIndex = 58;
            accountnumberlist.SelectedIndexChanged += accountnumberlist_SelectedIndexChanged;
            // 
            // SEARCH_ACCOUNT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(accountnumberlist);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SEARCH_ACCOUNT";
            Text = "SEARCH_ACCOUNT";
            Load += SEARCH_ACCOUNT_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button3;
        private ListBox accountnumberlist;
    }
}