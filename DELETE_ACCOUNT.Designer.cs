namespace BANKMS
{
    partial class DELETE_ACCOUNT
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 241);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(765, 360);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 150);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 154);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 1;
            label2.Text = "ACCOUNT ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(348, 47);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 0;
            label1.Text = "DELETE  ACCOUNT";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(580, 154);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 58;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // DELETE_ACCOUNT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DELETE_ACCOUNT";
            Text = "DELETE ACCOUNT";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}