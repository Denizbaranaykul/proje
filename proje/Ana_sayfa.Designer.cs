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
            pictureBox1 = new PictureBox();
            Close_btn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            arama = new Button();
            arama_cubugu = new ListBox();
            label1 = new Label();
            arama_textbox = new TextBox();
            panel2 = new Panel();
            btn_obs = new Button();
            btn_eds = new Button();
            btn_ebs = new Button();
            btn_oibs = new Button();
            btn_dpvm = new Button();
            btn_ak = new Button();
            btn_ogrencikulupleri = new Button();
            btn_edp = new Button();
            btn_kariyermerkezi = new Button();
            btn_kütüpanesistemi = new Button();
            btn_genelduyurular = new Button();
            btn_yvmb = new Button();
            btn_harita = new Button();
            btn_ulasim = new Button();
            btn_makale = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(1167, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(1167, 201);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(125, 29);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "çıkış yap";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(arama);
            panel1.Controls.Add(arama_cubugu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(arama_textbox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Close_btn);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 276);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoEN;
            pictureBox2.Location = new Point(3, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // arama
            // 
            arama.Location = new Point(586, 83);
            arama.Name = "arama";
            arama.Size = new Size(94, 29);
            arama.TabIndex = 5;
            arama.Text = "arama yap";
            arama.UseVisualStyleBackColor = true;
            arama.Click += arama_Click;
            // 
            // arama_cubugu
            // 
            arama_cubugu.FormattingEnabled = true;
            arama_cubugu.Location = new Point(461, 126);
            arama_cubugu.Name = "arama_cubugu";
            arama_cubugu.Size = new Size(352, 104);
            arama_cubugu.TabIndex = 4;
            arama_cubugu.MouseDoubleClick += arama_cubugu_MouseDoubleClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(461, 8);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 3;
            label1.Text = "arama çubuğu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // arama_textbox
            // 
            arama_textbox.Location = new Point(461, 42);
            arama_textbox.Name = "arama_textbox";
            arama_textbox.Size = new Size(352, 27);
            arama_textbox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(btn_makale);
            panel2.Controls.Add(btn_ulasim);
            panel2.Controls.Add(btn_harita);
            panel2.Controls.Add(btn_yvmb);
            panel2.Controls.Add(btn_genelduyurular);
            panel2.Controls.Add(btn_kütüpanesistemi);
            panel2.Controls.Add(btn_kariyermerkezi);
            panel2.Controls.Add(btn_edp);
            panel2.Controls.Add(btn_ogrencikulupleri);
            panel2.Controls.Add(btn_ak);
            panel2.Controls.Add(btn_dpvm);
            panel2.Controls.Add(btn_oibs);
            panel2.Controls.Add(btn_ebs);
            panel2.Controls.Add(btn_eds);
            panel2.Controls.Add(btn_obs);
            panel2.Location = new Point(0, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(1320, 365);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btn_obs
            // 
            btn_obs.Location = new Point(32, 18);
            btn_obs.Name = "btn_obs";
            btn_obs.Size = new Size(194, 95);
            btn_obs.TabIndex = 0;
            btn_obs.Text = "Öğrenci Bilgi Sistemi";
            btn_obs.UseVisualStyleBackColor = true;
            btn_obs.Click += button1_Click;
            // 
            // btn_eds
            // 
            btn_eds.Location = new Point(32, 143);
            btn_eds.Name = "btn_eds";
            btn_eds.Size = new Size(194, 95);
            btn_eds.TabIndex = 1;
            btn_eds.Text = "Eğitim Destek Sistemi";
            btn_eds.UseVisualStyleBackColor = true;
            // 
            // btn_ebs
            // 
            btn_ebs.Location = new Point(32, 261);
            btn_ebs.Name = "btn_ebs";
            btn_ebs.Size = new Size(194, 95);
            btn_ebs.TabIndex = 2;
            btn_ebs.Text = "Erasmus Bilgi Sistemi";
            btn_ebs.UseVisualStyleBackColor = true;
            // 
            // btn_oibs
            // 
            btn_oibs.Location = new Point(308, 18);
            btn_oibs.Name = "btn_oibs";
            btn_oibs.Size = new Size(194, 95);
            btn_oibs.TabIndex = 3;
            btn_oibs.Text = "Öğrenci İşleri Bilgi Sistemi";
            btn_oibs.UseVisualStyleBackColor = true;
            // 
            // btn_dpvm
            // 
            btn_dpvm.Location = new Point(308, 143);
            btn_dpvm.Name = "btn_dpvm";
            btn_dpvm.Size = new Size(194, 95);
            btn_dpvm.TabIndex = 4;
            btn_dpvm.Text = "Ders Programı Ve Müfredat";
            btn_dpvm.UseVisualStyleBackColor = true;
            // 
            // btn_ak
            // 
            btn_ak.Location = new Point(308, 261);
            btn_ak.Name = "btn_ak";
            btn_ak.Size = new Size(194, 95);
            btn_ak.TabIndex = 5;
            btn_ak.Text = "Akademik Kadro";
            btn_ak.UseVisualStyleBackColor = true;
            // 
            // btn_ogrencikulupleri
            // 
            btn_ogrencikulupleri.Location = new Point(586, 18);
            btn_ogrencikulupleri.Name = "btn_ogrencikulupleri";
            btn_ogrencikulupleri.Size = new Size(194, 95);
            btn_ogrencikulupleri.TabIndex = 6;
            btn_ogrencikulupleri.Text = "Öğrenci Kulüpleri";
            btn_ogrencikulupleri.UseVisualStyleBackColor = true;
            // 
            // btn_edp
            // 
            btn_edp.Location = new Point(586, 143);
            btn_edp.Name = "btn_edp";
            btn_edp.Size = new Size(194, 95);
            btn_edp.TabIndex = 7;
            btn_edp.Text = "Erasmus Değişim Programı";
            btn_edp.UseVisualStyleBackColor = true;
            btn_edp.Click += btn_edp_Click;
            // 
            // btn_kariyermerkezi
            // 
            btn_kariyermerkezi.Location = new Point(586, 261);
            btn_kariyermerkezi.Name = "btn_kariyermerkezi";
            btn_kariyermerkezi.Size = new Size(194, 95);
            btn_kariyermerkezi.TabIndex = 8;
            btn_kariyermerkezi.Text = "Kariyer Merkezi";
            btn_kariyermerkezi.UseVisualStyleBackColor = true;
            // 
            // btn_kütüpanesistemi
            // 
            btn_kütüpanesistemi.Location = new Point(838, 18);
            btn_kütüpanesistemi.Name = "btn_kütüpanesistemi";
            btn_kütüpanesistemi.Size = new Size(194, 95);
            btn_kütüpanesistemi.TabIndex = 9;
            btn_kütüpanesistemi.Text = "Kütüphane Sistemi";
            btn_kütüpanesistemi.UseVisualStyleBackColor = true;
            // 
            // btn_genelduyurular
            // 
            btn_genelduyurular.Location = new Point(838, 143);
            btn_genelduyurular.Name = "btn_genelduyurular";
            btn_genelduyurular.Size = new Size(194, 95);
            btn_genelduyurular.TabIndex = 10;
            btn_genelduyurular.Text = "Genel Duyurular";
            btn_genelduyurular.UseVisualStyleBackColor = true;
            // 
            // btn_yvmb
            // 
            btn_yvmb.Location = new Point(838, 261);
            btn_yvmb.Name = "btn_yvmb";
            btn_yvmb.Size = new Size(194, 95);
            btn_yvmb.TabIndex = 11;
            btn_yvmb.Text = "Yemekhane Ve Menü Bilgisi";
            btn_yvmb.UseVisualStyleBackColor = true;
            // 
            // btn_harita
            // 
            btn_harita.Location = new Point(1108, 18);
            btn_harita.Name = "btn_harita";
            btn_harita.Size = new Size(194, 95);
            btn_harita.TabIndex = 12;
            btn_harita.Text = "Kampüs Haritası Ve Rehber";
            btn_harita.UseVisualStyleBackColor = true;
            // 
            // btn_ulasim
            // 
            btn_ulasim.Location = new Point(1108, 143);
            btn_ulasim.Name = "btn_ulasim";
            btn_ulasim.Size = new Size(194, 95);
            btn_ulasim.TabIndex = 13;
            btn_ulasim.Text = "Kampüse Ulaşım";
            btn_ulasim.UseVisualStyleBackColor = true;
            // 
            // btn_makale
            // 
            btn_makale.Location = new Point(1108, 261);
            btn_makale.Name = "btn_makale";
            btn_makale.Size = new Size(194, 95);
            btn_makale.TabIndex = 14;
            btn_makale.Text = "Makale Ve Dergiler";
            btn_makale.UseVisualStyleBackColor = true;
            // 
            // Ana_sayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 752);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Button btn_ebs;
        private Button btn_eds;
        private Button btn_kariyermerkezi;
        private Button btn_edp;
        private Button btn_ogrencikulupleri;
        private Button btn_ak;
        private Button btn_harita;
        private Button btn_yvmb;
        private Button btn_genelduyurular;
        private Button btn_kütüpanesistemi;
        private Button btn_makale;
        private Button btn_ulasim;
    }
}