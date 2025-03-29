namespace proje
{
    partial class profil
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
            label1 = new Label();
            lbl_Tc = new Label();
            label3 = new Label();
            sifre_text_box = new MaskedTextBox();
            lbl_bolum = new Label();
            label5 = new Label();
            lbl_isim = new Label();
            label7 = new Label();
            lbl_soy_isim = new Label();
            label9 = new Label();
            btn_degistir = new Button();
            geri = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(186, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(103, 304);
            label1.Name = "label1";
            label1.Size = new Size(333, 28);
            label1.TabIndex = 1;
            label1.Text = "T.C";
            // 
            // lbl_Tc
            // 
            lbl_Tc.Location = new Point(103, 332);
            lbl_Tc.Name = "lbl_Tc";
            lbl_Tc.Size = new Size(333, 28);
            lbl_Tc.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(103, 374);
            label3.Name = "label3";
            label3.Size = new Size(333, 20);
            label3.TabIndex = 3;
            label3.Text = "şifre";
            // 
            // sifre_text_box
            // 
            sifre_text_box.Location = new Point(103, 397);
            sifre_text_box.Mask = "00000";
            sifre_text_box.Name = "sifre_text_box";
            sifre_text_box.Size = new Size(333, 23);
            sifre_text_box.TabIndex = 4;
            sifre_text_box.ValidatingType = typeof(int);
            // 
            // lbl_bolum
            // 
            lbl_bolum.Location = new Point(103, 462);
            lbl_bolum.Name = "lbl_bolum";
            lbl_bolum.Size = new Size(333, 28);
            lbl_bolum.TabIndex = 6;
            // 
            // label5
            // 
            label5.Location = new Point(103, 434);
            label5.Name = "label5";
            label5.Size = new Size(333, 28);
            label5.TabIndex = 5;
            label5.Text = "bölüm";
            // 
            // lbl_isim
            // 
            lbl_isim.Location = new Point(103, 221);
            lbl_isim.Name = "lbl_isim";
            lbl_isim.Size = new Size(333, 28);
            lbl_isim.TabIndex = 8;
            // 
            // label7
            // 
            label7.Location = new Point(103, 193);
            label7.Name = "label7";
            label7.Size = new Size(333, 28);
            label7.TabIndex = 7;
            label7.Text = "isim";
            // 
            // lbl_soy_isim
            // 
            lbl_soy_isim.Location = new Point(103, 277);
            lbl_soy_isim.Name = "lbl_soy_isim";
            lbl_soy_isim.Size = new Size(333, 28);
            lbl_soy_isim.TabIndex = 10;
            // 
            // label9
            // 
            label9.Location = new Point(103, 249);
            label9.Name = "label9";
            label9.Size = new Size(333, 28);
            label9.TabIndex = 9;
            label9.Text = "soyisim";
            // 
            // btn_degistir
            // 
            btn_degistir.Location = new Point(186, 493);
            btn_degistir.Name = "btn_degistir";
            btn_degistir.Size = new Size(169, 51);
            btn_degistir.TabIndex = 11;
            btn_degistir.Text = "değiştir";
            btn_degistir.UseVisualStyleBackColor = true;
            btn_degistir.Click += btn_degis;
            // 
            // geri
            // 
            geri.Location = new Point(186, 561);
            geri.Name = "geri";
            geri.Size = new Size(169, 33);
            geri.TabIndex = 12;
            geri.Text = "geri";
            geri.UseVisualStyleBackColor = true;
            geri.Click += btn_geriye;
            // 
            // profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 606);
            Controls.Add(geri);
            Controls.Add(btn_degistir);
            Controls.Add(lbl_soy_isim);
            Controls.Add(label9);
            Controls.Add(lbl_isim);
            Controls.Add(label7);
            Controls.Add(lbl_bolum);
            Controls.Add(label5);
            Controls.Add(sifre_text_box);
            Controls.Add(label3);
            Controls.Add(lbl_Tc);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "profil";
            Text = "profil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_Tc;
        private Label label3;
        private MaskedTextBox sifre_text_box;
        private Label lbl_bolum;
        private Label label5;
        private Label lbl_isim;
        private Label label7;
        private Label lbl_soy_isim;
        private Label label9;
        private Button btn_degistir;
        private Button geri;
    }
}