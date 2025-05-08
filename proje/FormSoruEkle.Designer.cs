namespace proje
{
    partial class FormSoruEkle
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
            txt_soru = new TextBox();
            txt_secenek1 = new TextBox();
            txt_secenek3 = new TextBox();
            txt_secenek2 = new TextBox();
            txt_secenek5 = new TextBox();
            txt_secenek4 = new TextBox();
            cmb_dogruSecenek = new ComboBox();
            btn_kaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmb_numara = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txt_soru
            // 
            txt_soru.Location = new Point(30, 34);
            txt_soru.Multiline = true;
            txt_soru.Name = "txt_soru";
            txt_soru.Size = new Size(703, 147);
            txt_soru.TabIndex = 0;
            // 
            // txt_secenek1
            // 
            txt_secenek1.Location = new Point(32, 233);
            txt_secenek1.Name = "txt_secenek1";
            txt_secenek1.Size = new Size(125, 27);
            txt_secenek1.TabIndex = 1;
            // 
            // txt_secenek3
            // 
            txt_secenek3.Location = new Point(345, 233);
            txt_secenek3.Name = "txt_secenek3";
            txt_secenek3.Size = new Size(125, 27);
            txt_secenek3.TabIndex = 3;
            // 
            // txt_secenek2
            // 
            txt_secenek2.Location = new Point(187, 233);
            txt_secenek2.Name = "txt_secenek2";
            txt_secenek2.Size = new Size(125, 27);
            txt_secenek2.TabIndex = 2;
            // 
            // txt_secenek5
            // 
            txt_secenek5.Location = new Point(647, 233);
            txt_secenek5.Name = "txt_secenek5";
            txt_secenek5.Size = new Size(125, 27);
            txt_secenek5.TabIndex = 5;
            // 
            // txt_secenek4
            // 
            txt_secenek4.Location = new Point(498, 233);
            txt_secenek4.Name = "txt_secenek4";
            txt_secenek4.Size = new Size(125, 27);
            txt_secenek4.TabIndex = 4;
            // 
            // cmb_dogruSecenek
            // 
            cmb_dogruSecenek.FormattingEnabled = true;
            cmb_dogruSecenek.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cmb_dogruSecenek.Location = new Point(281, 317);
            cmb_dogruSecenek.Name = "cmb_dogruSecenek";
            cmb_dogruSecenek.Size = new Size(151, 28);
            cmb_dogruSecenek.TabIndex = 6;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(281, 376);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(151, 48);
            btn_kaydet.TabIndex = 7;
            btn_kaydet.Text = "kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 208);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "A şıkkı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 208);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "B şıkkı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 208);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "C şıkkı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 208);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 11;
            label4.Text = "D şıkkı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 208);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "E şıkkı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 276);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 13;
            label6.Text = "doğru şık";
            // 
            // cmb_numara
            // 
            cmb_numara.FormattingEnabled = true;
            cmb_numara.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmb_numara.Location = new Point(37, 317);
            cmb_numara.Name = "cmb_numara";
            cmb_numara.Size = new Size(151, 28);
            cmb_numara.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 276);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 15;
            label7.Text = "sorunun numarasını seçiniz";
            // 
            // FormSoruEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(cmb_numara);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_kaydet);
            Controls.Add(cmb_dogruSecenek);
            Controls.Add(txt_secenek5);
            Controls.Add(txt_secenek4);
            Controls.Add(txt_secenek3);
            Controls.Add(txt_secenek2);
            Controls.Add(txt_secenek1);
            Controls.Add(txt_soru);
            Name = "FormSoruEkle";
            Text = "FormSoruEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_soru;
        private TextBox txt_secenek1;
        private TextBox txt_secenek3;
        private TextBox txt_secenek2;
        private TextBox txt_secenek5;
        private TextBox txt_secenek4;
        private ComboBox cmb_dogruSecenek;
        private Button btn_kaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmb_numara;
        private Label label7;
    }
}