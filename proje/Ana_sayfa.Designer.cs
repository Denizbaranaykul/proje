namespace proje
{
    partial class Ana_sayfa
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            Close_btn = new Button();
            panel1 = new Panel();
            btn_otrm_kapat = new Button();
            lbl_profil = new Label();
            btn_profil = new Button();
            pictureBox2 = new PictureBox();
            arama = new Button();
            arama_cubugu = new ListBox();
            label1 = new Label();
            arama_textbox = new TextBox();
            panel2 = new Panel();
            btn_makale = new Button();
            btn_ulasim = new Button();
            btn_yvmb = new Button();
            btn_genelduyurular = new Button();
            btn_harita = new Button();
            btn_kütüpanesistemi = new Button();
            btn_kariyermerkezi = new Button();
            btn_ogrencikulupleri = new Button();
            btn_ak = new Button();
            btn_msj = new Button();
            btn_dpvm = new Button();
            btn_oibs = new Button();
            btn_ebs = new Button();
            btn_eds = new Button();
            btn_obs = new Button();
            mesajTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(1021, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(1021, 181);
            Close_btn.Margin = new Padding(3, 2, 3, 2);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(109, 22);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "çıkış yap";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btn_otrm_kapat);
            panel1.Controls.Add(lbl_profil);
            panel1.Controls.Add(btn_profil);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(arama);
            panel1.Controls.Add(arama_cubugu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(arama_textbox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Close_btn);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 207);
            panel1.TabIndex = 2;
            // 
            // btn_otrm_kapat
            // 
            btn_otrm_kapat.Location = new Point(1021, 154);
            btn_otrm_kapat.Margin = new Padding(3, 2, 3, 2);
            btn_otrm_kapat.Name = "btn_otrm_kapat";
            btn_otrm_kapat.Size = new Size(109, 22);
            btn_otrm_kapat.TabIndex = 9;
            btn_otrm_kapat.Text = "oturmu kapat";
            btn_otrm_kapat.UseVisualStyleBackColor = true;
            btn_otrm_kapat.Click += btn_otrm_kapat_Click;
            // 
            // lbl_profil
            // 
            lbl_profil.Location = new Point(1021, 94);
            lbl_profil.Name = "lbl_profil";
            lbl_profil.Size = new Size(109, 19);
            lbl_profil.TabIndex = 8;
            lbl_profil.Text = "label2";
            lbl_profil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_profil
            // 
            btn_profil.Location = new Point(1021, 125);
            btn_profil.Margin = new Padding(3, 2, 3, 2);
            btn_profil.Name = "btn_profil";
            btn_profil.Size = new Size(109, 25);
            btn_profil.TabIndex = 7;
            btn_profil.Text = "profil";
            btn_profil.UseVisualStyleBackColor = true;
            btn_profil.Click += btn_profil_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoEN;
            pictureBox2.Location = new Point(3, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // arama
            // 
            arama.Location = new Point(513, 62);
            arama.Margin = new Padding(3, 2, 3, 2);
            arama.Name = "arama";
            arama.Size = new Size(82, 22);
            arama.TabIndex = 5;
            arama.Text = "arama yap";
            arama.UseVisualStyleBackColor = true;
            arama.Click += arama_Click;
            // 
            // arama_cubugu
            // 
            arama_cubugu.FormattingEnabled = true;
            arama_cubugu.ItemHeight = 15;
            arama_cubugu.Location = new Point(403, 94);
            arama_cubugu.Margin = new Padding(3, 2, 3, 2);
            arama_cubugu.Name = "arama_cubugu";
            arama_cubugu.Size = new Size(308, 79);
            arama_cubugu.TabIndex = 4;
            arama_cubugu.MouseDoubleClick += arama_cubugu_MouseDoubleClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(403, 6);
            label1.Name = "label1";
            label1.Size = new Size(308, 23);
            label1.TabIndex = 3;
            label1.Text = "arama çubuğu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // arama_textbox
            // 
            arama_textbox.Location = new Point(403, 32);
            arama_textbox.Margin = new Padding(3, 2, 3, 2);
            arama_textbox.Name = "arama_textbox";
            arama_textbox.Size = new Size(308, 23);
            arama_textbox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(btn_makale);
            panel2.Controls.Add(btn_ulasim);
            panel2.Controls.Add(btn_yvmb);
            panel2.Controls.Add(btn_genelduyurular);
            panel2.Controls.Add(btn_harita);
            panel2.Controls.Add(btn_kütüpanesistemi);
            panel2.Controls.Add(btn_kariyermerkezi);
            panel2.Controls.Add(btn_ogrencikulupleri);
            panel2.Controls.Add(btn_ak);
            panel2.Controls.Add(btn_msj);
            panel2.Controls.Add(btn_dpvm);
            panel2.Controls.Add(btn_oibs);
            panel2.Controls.Add(btn_ebs);
            panel2.Controls.Add(btn_eds);
            panel2.Controls.Add(btn_obs);
            panel2.Location = new Point(0, 208);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 274);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btn_makale
            // 
            btn_makale.BackColor = Color.Beige;
            btn_makale.Location = new Point(270, 196);
            btn_makale.Margin = new Padding(3, 2, 3, 2);
            btn_makale.Name = "btn_makale";
            btn_makale.Size = new Size(170, 71);
            btn_makale.TabIndex = 14;
            btn_makale.Text = "Makale Ve Dergiler";
            btn_makale.UseVisualStyleBackColor = false;
            // 
            // btn_ulasim
            // 
            btn_ulasim.BackColor = Color.Beige;
            btn_ulasim.Location = new Point(960, 107);
            btn_ulasim.Margin = new Padding(3, 2, 3, 2);
            btn_ulasim.Name = "btn_ulasim";
            btn_ulasim.Size = new Size(170, 71);
            btn_ulasim.TabIndex = 13;
            btn_ulasim.Text = "Kampüse Ulaşım";
            btn_ulasim.UseVisualStyleBackColor = false;
            btn_ulasim.Click += btn_ulasim_Click;
            // 
            // btn_yvmb
            // 
            btn_yvmb.BackColor = Color.Beige;
            btn_yvmb.Location = new Point(960, 196);
            btn_yvmb.Margin = new Padding(3, 2, 3, 2);
            btn_yvmb.Name = "btn_yvmb";
            btn_yvmb.Size = new Size(170, 71);
            btn_yvmb.TabIndex = 11;
            btn_yvmb.Text = "Yemekhane Ve Menü Bilgisi";
            btn_yvmb.UseVisualStyleBackColor = false;
            btn_yvmb.Click += btn_yvmb_Click;
            // 
            // btn_genelduyurular
            // 
            btn_genelduyurular.BackColor = Color.Beige;
            btn_genelduyurular.Location = new Point(513, 107);
            btn_genelduyurular.Margin = new Padding(3, 2, 3, 2);
            btn_genelduyurular.Name = "btn_genelduyurular";
            btn_genelduyurular.Size = new Size(170, 71);
            btn_genelduyurular.TabIndex = 10;
            btn_genelduyurular.Text = "Genel Duyurular";
            btn_genelduyurular.UseVisualStyleBackColor = false;
            // 
            // btn_harita
            // 
            btn_harita.BackColor = Color.Beige;
            btn_harita.Location = new Point(28, 14);
            btn_harita.Margin = new Padding(3, 2, 3, 2);
            btn_harita.Name = "btn_harita";
            btn_harita.Size = new Size(170, 71);
            btn_harita.TabIndex = 12;
            btn_harita.Text = "Kampüs Haritası Ve Rehber";
            btn_harita.UseVisualStyleBackColor = false;
            // 
            // btn_kütüpanesistemi
            // 
            btn_kütüpanesistemi.BackColor = Color.Beige;
            btn_kütüpanesistemi.Location = new Point(733, 14);
            btn_kütüpanesistemi.Margin = new Padding(3, 2, 3, 2);
            btn_kütüpanesistemi.Name = "btn_kütüpanesistemi";
            btn_kütüpanesistemi.Size = new Size(170, 71);
            btn_kütüpanesistemi.TabIndex = 9;
            btn_kütüpanesistemi.Text = "Kütüphane Sistemi";
            btn_kütüpanesistemi.UseVisualStyleBackColor = false;
            btn_kütüpanesistemi.Click += btn_kütüpanesistemi_Click;
            // 
            // btn_kariyermerkezi
            // 
            btn_kariyermerkezi.BackColor = Color.Beige;
            btn_kariyermerkezi.Location = new Point(733, 196);
            btn_kariyermerkezi.Margin = new Padding(3, 2, 3, 2);
            btn_kariyermerkezi.Name = "btn_kariyermerkezi";
            btn_kariyermerkezi.Size = new Size(170, 71);
            btn_kariyermerkezi.TabIndex = 8;
            btn_kariyermerkezi.Text = "Kariyer Merkezi";
            btn_kariyermerkezi.UseVisualStyleBackColor = false;
            btn_kariyermerkezi.Click += btn_kariyermerkezi_Click;
            // 
            // btn_ogrencikulupleri
            // 
            btn_ogrencikulupleri.BackColor = Color.Beige;
            btn_ogrencikulupleri.Location = new Point(513, 196);
            btn_ogrencikulupleri.Margin = new Padding(3, 2, 3, 2);
            btn_ogrencikulupleri.Name = "btn_ogrencikulupleri";
            btn_ogrencikulupleri.Size = new Size(170, 71);
            btn_ogrencikulupleri.TabIndex = 6;
            btn_ogrencikulupleri.Text = "Öğrenci Kulüpleri";
            btn_ogrencikulupleri.UseVisualStyleBackColor = false;
            btn_ogrencikulupleri.Click += btn_ogrencikulupleri_Click;
            // 
            // btn_ak
            // 
            btn_ak.BackColor = Color.Beige;
            btn_ak.Location = new Point(513, 14);
            btn_ak.Margin = new Padding(3, 2, 3, 2);
            btn_ak.Name = "btn_ak";
            btn_ak.Size = new Size(170, 71);
            btn_ak.TabIndex = 5;
            btn_ak.Text = "Akademik Kadro";
            btn_ak.UseVisualStyleBackColor = false;
            btn_ak.Click += btn_ak_Click;
            // 
            // btn_msj
            // 
            btn_msj.BackColor = Color.Beige;
            btn_msj.Location = new Point(960, 14);
            btn_msj.Margin = new Padding(3, 2, 3, 2);
            btn_msj.Name = "btn_msj";
            btn_msj.Size = new Size(170, 71);
            btn_msj.TabIndex = 7;
            btn_msj.Text = "Mesaj sistemi";
            btn_msj.UseVisualStyleBackColor = false;
            btn_msj.Click += btn_edp_Click;
            // 
            // btn_dpvm
            // 
            btn_dpvm.BackColor = Color.Beige;
            btn_dpvm.Location = new Point(270, 107);
            btn_dpvm.Margin = new Padding(3, 2, 3, 2);
            btn_dpvm.Name = "btn_dpvm";
            btn_dpvm.Size = new Size(170, 71);
            btn_dpvm.TabIndex = 4;
            btn_dpvm.Text = "şikayet ve öneri ";
            btn_dpvm.UseVisualStyleBackColor = false;
            // 
            // btn_oibs
            // 
            btn_oibs.BackColor = Color.Beige;
            btn_oibs.Location = new Point(270, 14);
            btn_oibs.Margin = new Padding(3, 2, 3, 2);
            btn_oibs.Name = "btn_oibs";
            btn_oibs.Size = new Size(170, 71);
            btn_oibs.TabIndex = 3;
            btn_oibs.Text = "Öğrenci İşleri Bilgi Sistemi";
            btn_oibs.UseVisualStyleBackColor = false;
            // 
            // btn_ebs
            // 
            btn_ebs.BackColor = Color.Beige;
            btn_ebs.Location = new Point(28, 196);
            btn_ebs.Margin = new Padding(3, 2, 3, 2);
            btn_ebs.Name = "btn_ebs";
            btn_ebs.Size = new Size(170, 71);
            btn_ebs.TabIndex = 2;
            btn_ebs.Text = "Erasmus Bilgi Sistemi";
            btn_ebs.UseVisualStyleBackColor = false;
            // 
            // btn_eds
            // 
            btn_eds.BackColor = Color.Beige;
            btn_eds.Location = new Point(28, 107);
            btn_eds.Margin = new Padding(3, 2, 3, 2);
            btn_eds.Name = "btn_eds";
            btn_eds.Size = new Size(170, 71);
            btn_eds.TabIndex = 1;
            btn_eds.Text = "Eğitim Destek Sistemi";
            btn_eds.UseVisualStyleBackColor = false;
            // 
            // btn_obs
            // 
            btn_obs.BackColor = Color.Beige;
            btn_obs.Location = new Point(733, 107);
            btn_obs.Margin = new Padding(3, 2, 3, 2);
            btn_obs.Name = "btn_obs";
            btn_obs.Size = new Size(170, 71);
            btn_obs.TabIndex = 0;
            btn_obs.Text = "Öğrenci Bilgi Sistemi";
            btn_obs.UseVisualStyleBackColor = false;
            btn_obs.Click += button1_Click;
            // 
            // mesajTimer
            // 
            mesajTimer.Tick += timer1_Tick;
            // 
            // Ana_sayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ana_sayfa";
            Text = "Ana_sayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Close_btn;
        private Panel panel1;
        private Button arama;
        private ListBox arama_cubugu;
        private Label label1;
        private TextBox arama_textbox;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btn_obs;
        private Button btn_dpvm;
        private Button btn_oibs;
        private Button btn_eds;
        private Button btn_kariyermerkezi;
        private Button btn_msj;
        private Button btn_ogrencikulupleri;
        private Button btn_ak;
        private Button btn_harita;
        private Button btn_yvmb;
        private Button btn_genelduyurular;
        private Button btn_kütüpanesistemi;
        private Button btn_makale;
        private Button btn_ulasim;
        private Label lbl_profil;
        private Button btn_profil;
        private Button btn_otrm_kapat;
        private Button btn_ebs;
        private System.Windows.Forms.Timer mesajTimer;
    }
}