namespace proje
{
    partial class yon_ekle
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
            label1 = new Label();
            tc_textbox = new TextBox();
            sifre_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            email_textbox = new TextBox();
            label5 = new Label();
            soy_isimtextbox = new TextBox();
            label6 = new Label();
            isim_textbox = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 237);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "T.C";
            // 
            // tc_textbox
            // 
            tc_textbox.Location = new Point(43, 270);
            tc_textbox.Name = "tc_textbox";
            tc_textbox.Size = new Size(237, 27);
            tc_textbox.TabIndex = 1;
            // 
            // sifre_textbox
            // 
            sifre_textbox.Location = new Point(43, 343);
            sifre_textbox.Name = "sifre_textbox";
            sifre_textbox.Size = new Size(237, 27);
            sifre_textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 310);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 384);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "pozisyon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 458);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "yetki";
            // 
            // email_textbox
            // 
            email_textbox.Location = new Point(43, 563);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(237, 27);
            email_textbox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 530);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "email";
            // 
            // soy_isimtextbox
            // 
            soy_isimtextbox.Location = new Point(43, 198);
            soy_isimtextbox.Name = "soy_isimtextbox";
            soy_isimtextbox.Size = new Size(237, 27);
            soy_isimtextbox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 165);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "soy isim";
            // 
            // isim_textbox
            // 
            isim_textbox.Location = new Point(43, 120);
            isim_textbox.Name = "isim_textbox";
            isim_textbox.Size = new Size(237, 27);
            isim_textbox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 87);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 12;
            label7.Text = "isim";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(isim_textbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tc_textbox);
            panel1.Controls.Add(soy_isimtextbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(sifre_textbox);
            panel1.Controls.Add(email_textbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 679);
            panel1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(43, 499);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(237, 28);
            comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "memur", "yemek personeli", "rektörlük personeli", "kulüp başkanı", "öğretim görevlisi" });
            comboBox1.Location = new Point(43, 427);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 28);
            comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(106, 616);
            button1.Name = "button1";
            button1.Size = new Size(144, 51);
            button1.TabIndex = 15;
            button1.Text = "kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(88, 19);
            label8.Name = "label8";
            label8.Size = new Size(192, 41);
            label8.TabIndex = 14;
            label8.Text = "yönetici kayıt";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(412, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 679);
            panel2.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(133, 616);
            button2.Name = "button2";
            button2.Size = new Size(144, 51);
            button2.TabIndex = 16;
            button2.Text = "sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(17, 98);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(373, 466);
            checkedListBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(43, 19);
            label9.Name = "label9";
            label9.Size = new Size(199, 41);
            label9.TabIndex = 14;
            label9.Text = "yönetici silme";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yon_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 703);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "yon_ekle";
            Text = "yon_ekle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tc_textbox;
        private TextBox sifre_textbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox email_textbox;
        private Label label5;
        private TextBox soy_isimtextbox;
        private Label label6;
        private TextBox isim_textbox;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label9;
        private Button button1;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}