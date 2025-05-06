namespace proje
{
    partial class yonetici
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
            lbl_profil = new Label();
            btn_profil = new Button();
            pictureBox1 = new PictureBox();
            Close_btn = new Button();
            panel1 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btn_personel_ekle = new Button();
            btn_ogrenci_ekle = new Button();
            panel2 = new Panel();
            btn_oturum = new Button();
            arama = new Button();
            arama_cubugu = new ListBox();
            label1 = new Label();
            arama_textbox = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_profil
            // 
            lbl_profil.Location = new Point(1174, 120);
            lbl_profil.Name = "lbl_profil";
            lbl_profil.Size = new Size(125, 25);
            lbl_profil.TabIndex = 12;
            lbl_profil.Text = "label2";
            lbl_profil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_profil
            // 
            btn_profil.Location = new Point(1175, 148);
            btn_profil.Name = "btn_profil";
            btn_profil.Size = new Size(125, 33);
            btn_profil.TabIndex = 11;
            btn_profil.Text = "profil";
            btn_profil.UseVisualStyleBackColor = true;
            btn_profil.Click += btn_profil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(1174, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(1175, 221);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(125, 29);
            Close_btn.TabIndex = 10;
            Close_btn.Text = "çıkış yap";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_personel_ekle);
            panel1.Controls.Add(btn_ogrenci_ekle);
            panel1.Location = new Point(3, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 339);
            panel1.TabIndex = 13;
            // 
            // button12
            // 
            button12.Location = new Point(879, 84);
            button12.Name = "button12";
            button12.Size = new Size(200, 91);
            button12.TabIndex = 11;
            button12.Text = "normal mesaj";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1099, 220);
            button11.Name = "button11";
            button11.Size = new Size(199, 91);
            button11.TabIndex = 10;
            button11.Text = "Erasmus başvuruları";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(879, 220);
            button10.Name = "button10";
            button10.Size = new Size(200, 91);
            button10.TabIndex = 9;
            button10.Text = "not ekleme";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(635, 220);
            button9.Name = "button9";
            button9.Size = new Size(218, 91);
            button9.TabIndex = 8;
            button9.Text = "müfredat ekleme";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(462, 220);
            button8.Name = "button8";
            button8.Size = new Size(151, 91);
            button8.TabIndex = 7;
            button8.Text = "yemekhane listesi ekleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(233, 220);
            button7.Name = "button7";
            button7.Size = new Size(194, 91);
            button7.TabIndex = 6;
            button7.Text = "kariyer destek sistemine ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(15, 220);
            button6.Name = "button6";
            button6.Size = new Size(190, 91);
            button6.TabIndex = 5;
            button6.Text = "Duyuru ekleme";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1098, 84);
            button5.Name = "button5";
            button5.Size = new Size(200, 91);
            button5.TabIndex = 4;
            button5.Text = "kütüphaneye kitap ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(635, 84);
            button4.Name = "button4";
            button4.Size = new Size(218, 91);
            button4.TabIndex = 3;
            button4.Text = "toplu mesaj";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(462, 84);
            button3.Name = "button3";
            button3.Size = new Size(151, 91);
            button3.TabIndex = 2;
            button3.Text = "kulüp başvuruları";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_personel_ekle
            // 
            btn_personel_ekle.Location = new Point(233, 84);
            btn_personel_ekle.Name = "btn_personel_ekle";
            btn_personel_ekle.Size = new Size(194, 91);
            btn_personel_ekle.TabIndex = 1;
            btn_personel_ekle.Text = "yönetici personel ekleme";
            btn_personel_ekle.UseVisualStyleBackColor = true;
            btn_personel_ekle.Click += button2_Click;
            // 
            // btn_ogrenci_ekle
            // 
            btn_ogrenci_ekle.Location = new Point(15, 84);
            btn_ogrenci_ekle.Name = "btn_ogrenci_ekle";
            btn_ogrenci_ekle.Size = new Size(190, 91);
            btn_ogrenci_ekle.TabIndex = 0;
            btn_ogrenci_ekle.Text = "öğrenci ekleme";
            btn_ogrenci_ekle.UseVisualStyleBackColor = true;
            btn_ogrenci_ekle.Click += btn_ogrenci_ekle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btn_oturum);
            panel2.Controls.Add(arama);
            panel2.Controls.Add(arama_cubugu);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(arama_textbox);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Close_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbl_profil);
            panel2.Controls.Add(btn_profil);
            panel2.Location = new Point(3, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1315, 283);
            panel2.TabIndex = 14;
            // 
            // btn_oturum
            // 
            btn_oturum.Location = new Point(1175, 187);
            btn_oturum.Name = "btn_oturum";
            btn_oturum.Size = new Size(125, 29);
            btn_oturum.TabIndex = 18;
            btn_oturum.Text = "oturumu kapat";
            btn_oturum.UseVisualStyleBackColor = true;
            btn_oturum.Click += btn_oturum_Click;
            // 
            // arama
            // 
            arama.Location = new Point(589, 79);
            arama.Name = "arama";
            arama.Size = new Size(94, 29);
            arama.TabIndex = 17;
            arama.Text = "arama yap";
            arama.UseVisualStyleBackColor = true;
            // 
            // arama_cubugu
            // 
            arama_cubugu.FormattingEnabled = true;
            arama_cubugu.Location = new Point(464, 121);
            arama_cubugu.Name = "arama_cubugu";
            arama_cubugu.Size = new Size(351, 104);
            arama_cubugu.TabIndex = 16;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(464, 4);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 15;
            label1.Text = "arama çubuğu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // arama_textbox
            // 
            arama_textbox.Location = new Point(464, 39);
            arama_textbox.Name = "arama_textbox";
            arama_textbox.Size = new Size(351, 27);
            arama_textbox.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoEN;
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 579);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "yonetici";
            Text = "yonetici";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_profil;
        private Button btn_profil;
        private PictureBox pictureBox1;
        private Button Close_btn;
        private Panel panel1;
        private Panel panel2;
        private Button btn_ogrenci_ekle;
        private Button btn_personel_ekle;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button10;
        private Button button9;
        private Button button11;
        private Button button12;
        private PictureBox pictureBox2;
        private Button arama;
        private ListBox arama_cubugu;
        private Label label1;
        private TextBox arama_textbox;
        private Button btn_oturum;
    }
}