namespace proje
{
    partial class makale_ekle
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
            txt_yazar = new TextBox();
            txt_baslik = new TextBox();
            txt_dergi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_kaydet = new Button();
            SuspendLayout();
            // 
            // txt_yazar
            // 
            txt_yazar.Location = new Point(57, 50);
            txt_yazar.Name = "txt_yazar";
            txt_yazar.Size = new Size(183, 27);
            txt_yazar.TabIndex = 0;
            // 
            // txt_baslik
            // 
            txt_baslik.Location = new Point(57, 126);
            txt_baslik.Name = "txt_baslik";
            txt_baslik.Size = new Size(183, 27);
            txt_baslik.TabIndex = 1;
            // 
            // txt_dergi
            // 
            txt_dergi.Location = new Point(57, 212);
            txt_dergi.Name = "txt_dergi";
            txt_dergi.Size = new Size(183, 27);
            txt_dergi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "yazarın adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 103);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "makalenin başlığı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 189);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "yayın evi";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(83, 268);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(125, 67);
            btn_kaydet.TabIndex = 6;
            btn_kaydet.Text = "makaleyi yükle";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // makale_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 396);
            Controls.Add(btn_kaydet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_dergi);
            Controls.Add(txt_baslik);
            Controls.Add(txt_yazar);
            Name = "makale_ekle";
            Text = "makale_ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_yazar;
        private TextBox txt_baslik;
        private TextBox txt_dergi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_kaydet;
    }
}