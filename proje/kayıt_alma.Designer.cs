namespace proje
{
    partial class kayıt_alma
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
            btn_picture = new Button();
            pctr_profil = new PictureBox();
            btn_kayıt = new Button();
            txt_mail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctr_profil).BeginInit();
            SuspendLayout();
            // 
            // btn_picture
            // 
            btn_picture.Location = new Point(59, 213);
            btn_picture.Name = "btn_picture";
            btn_picture.Size = new Size(132, 75);
            btn_picture.TabIndex = 0;
            btn_picture.Text = "profil fotoğrafı yükle";
            btn_picture.UseVisualStyleBackColor = true;
            btn_picture.Click += btn_picture_Click;
            // 
            // pctr_profil
            // 
            pctr_profil.Location = new Point(59, 78);
            pctr_profil.Name = "pctr_profil";
            pctr_profil.Size = new Size(132, 103);
            pctr_profil.TabIndex = 1;
            pctr_profil.TabStop = false;
            // 
            // btn_kayıt
            // 
            btn_kayıt.Location = new Point(59, 398);
            btn_kayıt.Name = "btn_kayıt";
            btn_kayıt.Size = new Size(132, 75);
            btn_kayıt.TabIndex = 2;
            btn_kayıt.Text = "yerleşme belgenizi yükleyiniz";
            btn_kayıt.UseVisualStyleBackColor = true;
            btn_kayıt.Click += btn_kayıt_Click;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(26, 344);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(217, 27);
            txt_mail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 308);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 4;
            label1.Text = "Lütfen E-mailinizi Giriniz";
            // 
            // kayıt_alma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 512);
            Controls.Add(label1);
            Controls.Add(txt_mail);
            Controls.Add(btn_kayıt);
            Controls.Add(pctr_profil);
            Controls.Add(btn_picture);
            Name = "kayıt_alma";
            Text = "kayıt_alma";
            ((System.ComponentModel.ISupportInitialize)pctr_profil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_picture;
        private PictureBox pctr_profil;
        private Button btn_kayıt;
        private TextBox txt_mail;
        private Label label1;
    }
}