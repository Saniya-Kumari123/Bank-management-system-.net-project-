namespace BANKMS
{
    partial class CHANGE_PASSWORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHANGE_PASSWORD));
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(436, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 352);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 4;
            label5.Text = "CONFIRM PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 300);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "NEW PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(286, 23);
            label1.Name = "label1";
            label1.Size = new Size(227, 24);
            label1.TabIndex = 0;
            label1.Text = "CHANGE PASSWORD";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(286, 406);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 58;
            button3.Text = "CHANGE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(286, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 180);
            panel1.TabIndex = 59;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(436, 405);
            button1.Margin = new Padding(4, 3, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 60;
            button1.Text = "CANCEL";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 270);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 61;
            label2.Text = "USERName";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 62;
            // 
            // CHANGE_PASSWORD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "CHANGE_PASSWORD";
            Text = "CHANGE_PASSWORD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}