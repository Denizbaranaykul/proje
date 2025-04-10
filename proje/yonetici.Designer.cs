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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_profil
            // 
            lbl_profil.Location = new Point(1189, 126);
            lbl_profil.Name = "lbl_profil";
            lbl_profil.Size = new Size(125, 25);
            lbl_profil.TabIndex = 12;
            lbl_profil.Text = "label2";
            lbl_profil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_profil
            // 
            btn_profil.Location = new Point(1189, 164);
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
            pictureBox1.Location = new Point(1189, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(1189, 202);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(125, 29);
            Close_btn.TabIndex = 10;
            Close_btn.Text = "çıkış yap";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 728);
            Controls.Add(lbl_profil);
            Controls.Add(btn_profil);
            Controls.Add(pictureBox1);
            Controls.Add(Close_btn);
            Name = "yonetici";
            Text = "yonetici";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_profil;
        private Button btn_profil;
        private PictureBox pictureBox1;
        private Button Close_btn;
    }
}