namespace BANKMS
{
    partial class BALANCE_SHEET
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            accountnumberlist = new ListBox();
            DATAGRIDDEPOSIT = new DataGridView();
            DATAGRIDWITHDRAW = new DataGridView();
            DATAGRIDTRANSF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDDEPOSIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDWITHDRAW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDTRANSF).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(591, 169);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 8;
            label4.Text = "TRANSFER DETAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(340, 167);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 7;
            label3.Text = "WITHDRAW DETAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 169);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "DEPOSIT DETAIL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(294, 38);
            label1.Name = "label1";
            label1.Size = new Size(193, 24);
            label1.TabIndex = 0;
            label1.Text = "BALANCE  SHEET";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(501, 82);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 57;
            button3.Text = "SHOW";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // accountnumberlist
            // 
            accountnumberlist.FormattingEnabled = true;
            accountnumberlist.ItemHeight = 15;
            accountnumberlist.Location = new Point(3, -3);
            accountnumberlist.Name = "accountnumberlist";
            accountnumberlist.Size = new Size(111, 169);
            accountnumberlist.TabIndex = 59;
            // 
            // DATAGRIDDEPOSIT
            // 
            DATAGRIDDEPOSIT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDDEPOSIT.Location = new Point(24, 200);
            DATAGRIDDEPOSIT.Name = "DATAGRIDDEPOSIT";
            DATAGRIDDEPOSIT.RowTemplate.Height = 25;
            DATAGRIDDEPOSIT.Size = new Size(240, 238);
            DATAGRIDDEPOSIT.TabIndex = 60;
            // 
            // DATAGRIDWITHDRAW
            // 
            DATAGRIDWITHDRAW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDWITHDRAW.Location = new Point(308, 200);
            DATAGRIDWITHDRAW.Name = "DATAGRIDWITHDRAW";
            DATAGRIDWITHDRAW.RowTemplate.Height = 25;
            DATAGRIDWITHDRAW.Size = new Size(240, 150);
            DATAGRIDWITHDRAW.TabIndex = 61;
            // 
            // DATAGRIDTRANSF
            // 
            DATAGRIDTRANSF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRIDTRANSF.Location = new Point(584, 216);
            DATAGRIDTRANSF.Name = "DATAGRIDTRANSF";
            DATAGRIDTRANSF.RowTemplate.Height = 25;
            DATAGRIDTRANSF.Size = new Size(240, 150);
            DATAGRIDTRANSF.TabIndex = 62;
            // 
            // BALANCE_SHEET
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(DATAGRIDTRANSF);
            Controls.Add(DATAGRIDWITHDRAW);
            Controls.Add(DATAGRIDDEPOSIT);
            Controls.Add(accountnumberlist);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "BALANCE_SHEET";
            Text = "BALANCE_SHEET";
            Load += BALANCE_SHEET_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRIDDEPOSIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDWITHDRAW).EndInit();
            ((System.ComponentModel.ISupportInitialize)DATAGRIDTRANSF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button3;
        private ListBox accountnumberlist;
        private DataGridView DATAGRIDDEPOSIT;
        private DataGridView DATAGRIDWITHDRAW;
        private DataGridView DATAGRIDTRANSF;
    }
}