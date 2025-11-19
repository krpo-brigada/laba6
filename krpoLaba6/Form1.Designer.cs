namespace krpoLaba6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Honeydew;
            label1.Location = new Point(159, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа 8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Honeydew;
            label2.Location = new Point(132, 36);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 1;
            label2.Text = "Сравнение функций хеширования";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 362);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(185, 296);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 13;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(265, 232);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Honeydew;
            label7.Location = new Point(107, 232);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 11;
            label7.Text = "Метод умножения";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Honeydew;
            label6.Location = new Point(107, 203);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 9;
            label6.Text = "Метод свертывания";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Honeydew;
            label5.Location = new Point(107, 174);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 7;
            label5.Text = "Метод середины квадрата";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Honeydew;
            label4.Location = new Point(107, 145);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Метод деления";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ButtonHighlight;
            numericUpDown1.Location = new Point(195, 87);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 45678, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Honeydew;
            label3.Location = new Point(151, 89);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Ключ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 362);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}
