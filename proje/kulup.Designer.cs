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
            button3.Location = new Point(701, 248);
            button3.Name = "button3";
            button3.Size = new Size(158, 63);
            button3.TabIndex = 4;
            button3.Text = "topluluk başvurusu yap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(655, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 53);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 6;
            label1.Text = "topluluğun adı";
            // 
            // textBoxArama
            // 
            textBoxArama.Location = new Point(51, 103);
            textBoxArama.Margin = new Padding(3, 4, 3, 4);
            textBoxArama.Name = "textBoxArama";
            textBoxArama.Size = new Size(201, 27);
            textBoxArama.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "arama çubuğu";
            // 
            // button2
            // 
            button2.Location = new Point(51, 165);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 61);
            button2.TabIndex = 9;
            button2.Text = "ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(167, 165);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 61);
            button4.TabIndex = 10;
            button4.Text = "yenile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(51, 340);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(453, 304);
            listBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F);
            label3.Location = new Point(151, 260);
            label3.Name = "label3";
            label3.Size = new Size(241, 47);
            label3.TabIndex = 12;
            label3.Text = "topluluk listesi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(656, 149);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 14;
            label4.Text = "danışman hocası";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(655, 196);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 28);
            comboBox1.TabIndex = 15;
            // 
            // kulup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 721);
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