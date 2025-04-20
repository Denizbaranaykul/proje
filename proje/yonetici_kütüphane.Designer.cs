namespace proje
{
    partial class yonetici_kütüphane
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            cmbUyeler = new ComboBox();
            cmbKitaplar = new ComboBox();
            dtBorrowDate = new DateTimePicker();
            dtDueDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnOduncVer = new Button();
            btnTeslimAl = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 414);
            button1.Name = "button1";
            button1.Size = new Size(143, 68);
            button1.TabIndex = 0;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(121, 35);
            label1.TabIndex = 2;
            label1.Text = "kitap ismi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(160, 35);
            label2.TabIndex = 4;
            label2.Text = "kitabın yazarı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(45, 263);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "evet";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(126, 263);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "hayır";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(45, 210);
            label3.Name = "label3";
            label3.Size = new Size(127, 35);
            label3.TabIndex = 7;
            label3.Text = "E-kitap mı";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 358);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(45, 303);
            label4.Name = "label4";
            label4.Size = new Size(243, 35);
            label4.TabIndex = 9;
            label4.Text = "E-kitapsa dosya yolu";
            // 
            // cmbUyeler
            // 
            cmbUyeler.FormattingEnabled = true;
            cmbUyeler.Location = new Point(540, 79);
            cmbUyeler.Name = "cmbUyeler";
            cmbUyeler.Size = new Size(250, 28);
            cmbUyeler.TabIndex = 10;
            // 
            // cmbKitaplar
            // 
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(540, 167);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(250, 28);
            cmbKitaplar.TabIndex = 11;
            // 
            // dtBorrowDate
            // 
            dtBorrowDate.Location = new Point(540, 251);
            dtBorrowDate.Name = "dtBorrowDate";
            dtBorrowDate.Size = new Size(250, 27);
            dtBorrowDate.TabIndex = 12;
            // 
            // dtDueDate
            // 
            dtDueDate.Location = new Point(540, 328);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(250, 27);
            dtDueDate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(540, 210);
            label5.Name = "label5";
            label5.Size = new Size(236, 35);
            label5.TabIndex = 14;
            label5.Text = "ödünç verilme tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(540, 281);
            label6.Name = "label6";
            label6.Size = new Size(197, 35);
            label6.TabIndex = 15;
            label6.Text = "geri gelme tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(540, 119);
            label7.Name = "label7";
            label7.Size = new Size(142, 35);
            label7.TabIndex = 16;
            label7.Text = "alınan kitap";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(540, 30);
            label8.Name = "label8";
            label8.Size = new Size(152, 35);
            label8.TabIndex = 17;
            label8.Text = "alan öğrenci";
            // 
            // btnOduncVer
            // 
            btnOduncVer.Location = new Point(540, 414);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(100, 68);
            btnOduncVer.TabIndex = 18;
            btnOduncVer.Text = "ödünç ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Location = new Point(687, 414);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(103, 68);
            btnTeslimAl.TabIndex = 19;
            btnTeslimAl.Text = "teslim al";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // yonetici_kütüphane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 560);
            Controls.Add(btnTeslimAl);
            Controls.Add(btnOduncVer);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtDueDate);
            Controls.Add(dtBorrowDate);
            Controls.Add(cmbKitaplar);
            Controls.Add(cmbUyeler);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "yonetici_kütüphane";
            Text = "yonetici_kütüphane";
            Load += yonetici_kütüphane_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ComboBox cmbUyeler;
        private ComboBox cmbKitaplar;
        private DateTimePicker dtBorrowDate;
        private DateTimePicker dtDueDate;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnOduncVer;
        private Button btnTeslimAl;
    }
}