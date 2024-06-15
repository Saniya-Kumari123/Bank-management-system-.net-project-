namespace BANKMS
{
    partial class FORGOT_PASSWORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORGOT_PASSWORD));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(288, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(272, 45);
            label1.Name = "label1";
            label1.Size = new Size(226, 24);
            label1.TabIndex = 1;
            label1.Text = "FORGOT PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 213);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "CNIC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 257);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "DATE OF BIRTH";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(387, 251);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(358, 317);
            button1.Margin = new Padding(4, 3, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 8;
            button1.Text = "NEXT";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(358, 363);
            button3.Margin = new Padding(4, 3, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "CANCEL";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FORGOT_PASSWORD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FORGOT_PASSWORD";
            Text = "FORGOT PASSWORD";
            Load += FORGOT_PASSWORD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button3;
    }
}