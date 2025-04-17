namespace proje
{
    partial class mesaj_form
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            btn_gndr = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            label_isim = new Label();
            label8 = new Label();
            label_soy_isim = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 544);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(259, 8);
            label1.Name = "label1";
            label1.Size = new Size(236, 39);
            label1.TabIndex = 1;
            label1.Text = "gelen kutusu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 491);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(850, 95);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 2;
            label2.Text = "gönderilecek kişiyi seçin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(850, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(850, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(850, 299);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "başlık giriniz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(850, 417);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(309, 94);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(850, 381);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 7;
            label4.Text = "mesajınızı giriniz";
            // 
            // btn_gndr
            // 
            btn_gndr.Location = new Point(937, 573);
            btn_gndr.Name = "btn_gndr";
            btn_gndr.Size = new Size(188, 75);
            btn_gndr.TabIndex = 8;
            btn_gndr.Text = "gönder";
            btn_gndr.UseVisualStyleBackColor = true;
            btn_gndr.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 573);
            button2.Name = "button2";
            button2.Size = new Size(202, 75);
            button2.TabIndex = 9;
            button2.Text = "gelen kutusunu yenile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(850, 53);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "öğrenci";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1077, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "yönetici";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(903, 20);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 12;
            label5.Text = "gönderilecek kişi tipini seçiniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(850, 162);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 13;
            label6.Text = "kişinin ismi";
            // 
            // label_isim
            // 
            label_isim.AutoSize = true;
            label_isim.Location = new Point(850, 193);
            label_isim.Name = "label_isim";
            label_isim.Size = new Size(36, 20);
            label_isim.TabIndex = 14;
            label_isim.Text = "isim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(850, 223);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 15;
            label8.Text = "kişinin soyismi";
            // 
            // label_soy_isim
            // 
            label_soy_isim.AutoSize = true;
            label_soy_isim.Location = new Point(850, 256);
            label_soy_isim.Name = "label_soy_isim";
            label_soy_isim.Size = new Size(58, 20);
            label_soy_isim.TabIndex = 16;
            label_soy_isim.Text = "soyisim";
            // 
            // mesaj_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 679);
            Controls.Add(label_soy_isim);
            Controls.Add(label8);
            Controls.Add(label_isim);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(btn_gndr);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "mesaj_form";
            Text = "mesaj_form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button btn_gndr;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private Label label6;
        private Label label_isim;
        private Label label8;
        private Label label_soy_isim;
    }
}