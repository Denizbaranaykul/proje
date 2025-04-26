namespace proje
{
    partial class Yon_mesaj
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
            label_soy_isim = new Label();
            label8 = new Label();
            label_isim = new Label();
            label6 = new Label();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            btn_gndr = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_soy_isim
            // 
            label_soy_isim.AutoSize = true;
            label_soy_isim.Location = new Point(798, 305);
            label_soy_isim.Name = "label_soy_isim";
            label_soy_isim.Size = new Size(47, 15);
            label_soy_isim.TabIndex = 32;
            label_soy_isim.Text = "soyisim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(798, 280);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 31;
            label8.Text = "kişinin soyismi";
            // 
            // label_isim
            // 
            label_isim.AutoSize = true;
            label_isim.Location = new Point(799, 265);
            label_isim.Name = "label_isim";
            label_isim.Size = new Size(29, 15);
            label_isim.TabIndex = 30;
            label_isim.Text = "isim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(799, 242);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 29;
            label6.Text = "kişinin ismi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(854, 9);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 28;
            label5.Text = "gönderilecek kişi tipini seçiniz";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1002, 55);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "yönetici";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(798, 55);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "öğrenci";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(203, 449);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(177, 56);
            button2.TabIndex = 25;
            button2.Text = "gelen kutusunu yenile";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_gndr
            // 
            btn_gndr.Location = new Point(853, 543);
            btn_gndr.Margin = new Padding(3, 2, 3, 2);
            btn_gndr.Name = "btn_gndr";
            btn_gndr.Size = new Size(164, 56);
            btn_gndr.TabIndex = 24;
            btn_gndr.Text = "gönder";
            btn_gndr.UseVisualStyleBackColor = true;
            btn_gndr.Click += btn_gndr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(798, 399);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 23;
            label4.Text = "mesajınızı giriniz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(798, 426);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(271, 72);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(798, 337);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 21;
            label3.Text = "başlık giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(798, 363);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(799, 86);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 18;
            label2.Text = "gönderilecek kişileri seçin";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-102, -13);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 458);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(276, 37);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 1;
            label1.Text = "gelen kutusu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 79);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(705, 368);
            dataGridView1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(798, 127);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(271, 112);
            checkedListBox1.TabIndex = 33;
            // 
            // Yon_mesaj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 606);
            Controls.Add(checkedListBox1);
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
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Yon_mesaj";
            Text = "Yon_mesaj";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_soy_isim;
        private Label label8;
        private Label label_isim;
        private Label label6;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button btn_gndr;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private CheckedListBox checkedListBox1;
    }
}