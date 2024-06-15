namespace BANKMS
{
    partial class CheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBalance));
            panel1 = new Panel();
            button3 = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(332, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 200);
            panel1.TabIndex = 72;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(150, 176);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(91, 34);
            button3.TabIndex = 69;
            button3.Text = "DETAIL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 122);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 65;
            label3.Text = "ACCOUNT NO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 64;
            label1.Text = "CHECK BALANCE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 66;
            // 
            // CheckBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 307);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CheckBalance";
            Text = "Check Balance";
            Load += CheckBalance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
    }
}