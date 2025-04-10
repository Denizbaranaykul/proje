namespace proje
{
    partial class Yon_Profilcs
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
            geri = new Button();
            btn_degistir = new Button();
            lbl_soy_isim = new Label();
            label9 = new Label();
            lbl_isim = new Label();
            label7 = new Label();
            lbl_bolum = new Label();
            label5 = new Label();
            sifre_text_box = new MaskedTextBox();
            label3 = new Label();
            lbl_Tc = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // geri
            // 
            geri.Location = new Point(217, 749);
            geri.Margin = new Padding(3, 4, 3, 4);
            geri.Name = "geri";
            geri.Size = new Size(193, 44);
            geri.TabIndex = 25;
            geri.Text = "geri";
            geri.UseVisualStyleBackColor = true;
            geri.Click += geri_Click;
            // 
            // btn_degistir
            // 
            btn_degistir.Location = new Point(217, 658);
            btn_degistir.Margin = new Padding(3, 4, 3, 4);
            btn_degistir.Name = "btn_degistir";
            btn_degistir.Size = new Size(193, 68);
            btn_degistir.TabIndex = 24;
            btn_degistir.Text = "değiştir";
            btn_degistir.UseVisualStyleBackColor = true;
            btn_degistir.Click += btn_degistir_Click;
            // 
            // lbl_soy_isim
            // 
            lbl_soy_isim.Location = new Point(122, 370);
            lbl_soy_isim.Name = "lbl_soy_isim";
            lbl_soy_isim.Size = new Size(381, 37);
            lbl_soy_isim.TabIndex = 23;
            // 
            // label9
            // 
            label9.Location = new Point(122, 333);
            label9.Name = "label9";
            label9.Size = new Size(381, 37);
            label9.TabIndex = 22;
            label9.Text = "soyisim";
            // 
            // lbl_isim
            // 
            lbl_isim.Location = new Point(122, 296);
            lbl_isim.Name = "lbl_isim";
            lbl_isim.Size = new Size(381, 37);
            lbl_isim.TabIndex = 21;
            // 
            // label7
            // 
            label7.Location = new Point(122, 258);
            label7.Name = "label7";
            label7.Size = new Size(381, 37);
            label7.TabIndex = 20;
            label7.Text = "isim";
            // 
            // lbl_bolum
            // 
            lbl_bolum.Location = new Point(122, 617);
            lbl_bolum.Name = "lbl_bolum";
            lbl_bolum.Size = new Size(381, 37);
            lbl_bolum.TabIndex = 19;
            // 
            // label5
            // 
            label5.Location = new Point(122, 580);
            label5.Name = "label5";
            label5.Size = new Size(381, 37);
            label5.TabIndex = 18;
            label5.Text = "pozisyon";
            // 
            // sifre_text_box
            // 
            sifre_text_box.Location = new Point(122, 530);
            sifre_text_box.Margin = new Padding(3, 4, 3, 4);
            sifre_text_box.Name = "sifre_text_box";
            sifre_text_box.Size = new Size(380, 27);
            sifre_text_box.TabIndex = 17;
            // 
            // label3
            // 
            label3.Location = new Point(122, 500);
            label3.Name = "label3";
            label3.Size = new Size(381, 27);
            label3.TabIndex = 16;
            label3.Text = "şifre";
            // 
            // lbl_Tc
            // 
            lbl_Tc.Location = new Point(122, 444);
            lbl_Tc.Name = "lbl_Tc";
            lbl_Tc.Size = new Size(381, 37);
            lbl_Tc.TabIndex = 15;
            // 
            // label1
            // 
            label1.Location = new Point(122, 406);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.TabIndex = 14;
            label1.Text = "T.C";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(217, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Yon_Profilcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 829);
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
            Name = "Yon_Profilcs";
            Text = "Yon_Profilcs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button geri;
        private Button btn_degistir;
        private Label lbl_soy_isim;
        private Label label9;
        private Label lbl_isim;
        private Label label7;
        private Label lbl_bolum;
        private Label label5;
        private MaskedTextBox sifre_text_box;
        private Label label3;
        private Label lbl_Tc;
        private Label label1;
        private PictureBox pictureBox1;
    }
}