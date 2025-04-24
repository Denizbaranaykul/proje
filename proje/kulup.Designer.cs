namespace proje
{
    partial class kulup
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
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBoxArama = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(613, 186);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(138, 47);
            button3.TabIndex = 4;
            button3.Text = "topluluk başvurusu yap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(573, 77);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 40);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 6;
            label1.Text = "topluluğun adı";
            // 
            // textBoxArama
            // 
            textBoxArama.Location = new Point(45, 77);
            textBoxArama.Name = "textBoxArama";
            textBoxArama.Size = new Size(176, 23);
            textBoxArama.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 8;
            label2.Text = "arama çubuğu";
            // 
            // button2
            // 
            button2.Location = new Point(45, 124);
            button2.Name = "button2";
            button2.Size = new Size(75, 46);
            button2.TabIndex = 9;
            button2.Text = "ara";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(146, 124);
            button4.Name = "button4";
            button4.Size = new Size(75, 46);
            button4.TabIndex = 10;
            button4.Text = "yenile";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 255);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(397, 229);
            listBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F);
            label3.Location = new Point(132, 195);
            label3.Name = "label3";
            label3.Size = new Size(195, 38);
            label3.TabIndex = 12;
            label3.Text = "topluluk listesi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 112);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "danışman hocası";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(573, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 15;
            // 
            // kulup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 541);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBoxArama);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "kulup";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxArama;
        private Label label2;
        private Button button2;
        private Button button4;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}