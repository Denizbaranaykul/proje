namespace proje
{
    partial class egitim_destek_yon
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
            comboBoxDersler = new ComboBox();
            label1 = new Label();
            txt_baslik = new TextBox();
            label2 = new Label();
            label3 = new Label();
            box_week = new ComboBox();
            btn_kaydet = new Button();
            SuspendLayout();
            // 
            // comboBoxDersler
            // 
            comboBoxDersler.FormattingEnabled = true;
            comboBoxDersler.Location = new Point(64, 99);
            comboBoxDersler.Name = "comboBoxDersler";
            comboBoxDersler.Size = new Size(235, 28);
            comboBoxDersler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 57);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "dersi seçiniz";
            // 
            // txt_baslik
            // 
            txt_baslik.Location = new Point(64, 184);
            txt_baslik.Name = "txt_baslik";
            txt_baslik.Size = new Size(235, 27);
            txt_baslik.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 161);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "başlığı giriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 239);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "haftayı seçiniz";
            // 
            // box_week
            // 
            box_week.FormattingEnabled = true;
            box_week.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });
            box_week.Location = new Point(64, 281);
            box_week.Name = "box_week";
            box_week.Size = new Size(235, 28);
            box_week.TabIndex = 4;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(64, 339);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(222, 64);
            btn_kaydet.TabIndex = 6;
            btn_kaydet.Text = "pdf veya slayt ekle";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // egitim_destek_yon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(btn_kaydet);
            Controls.Add(label3);
            Controls.Add(box_week);
            Controls.Add(label2);
            Controls.Add(txt_baslik);
            Controls.Add(label1);
            Controls.Add(comboBoxDersler);
            Name = "egitim_destek_yon";
            Text = "egitim_destek_yon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDersler;
        private Label label1;
        private TextBox txt_baslik;
        private Label label2;
        private Label label3;
        private ComboBox box_week;
        private Button btn_kaydet;
    }
}