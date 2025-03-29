namespace proje
{
    partial class Obs
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
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            btn_yenile = new Button();
            btn_onay = new Button();
            label2 = new Label();
            label1 = new Label();
            lbl_bolum = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(38, 132);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(291, 220);
            checkedListBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lbl_bolum);
            panel1.Controls.Add(btn_yenile);
            panel1.Controls.Add(btn_onay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Location = new Point(-5, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 550);
            panel1.TabIndex = 2;
            // 
            // btn_yenile
            // 
            btn_yenile.Location = new Point(150, 370);
            btn_yenile.Margin = new Padding(3, 2, 3, 2);
            btn_yenile.Name = "btn_yenile";
            btn_yenile.Size = new Size(82, 22);
            btn_yenile.TabIndex = 5;
            btn_yenile.Text = "yenile";
            btn_yenile.UseVisualStyleBackColor = true;
            btn_yenile.Click += btn_yenile_Click;
            // 
            // btn_onay
            // 
            btn_onay.Location = new Point(78, 414);
            btn_onay.Margin = new Padding(3, 2, 3, 2);
            btn_onay.Name = "btn_onay";
            btn_onay.Size = new Size(225, 68);
            btn_onay.TabIndex = 4;
            btn_onay.Text = "onayla";
            btn_onay.UseVisualStyleBackColor = true;
            btn_onay.Click += btn_onay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "bölümünüzü seçin";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(78, 18);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 2;
            label1.Text = " Ders kayıt işlemleri";
            // 
            // lbl_bolum
            // 
            lbl_bolum.BackColor = SystemColors.ButtonHighlight;
            lbl_bolum.Font = new Font("Segoe UI", 12F);
            lbl_bolum.Location = new Point(38, 98);
            lbl_bolum.Name = "lbl_bolum";
            lbl_bolum.Size = new Size(291, 22);
            lbl_bolum.TabIndex = 6;
            lbl_bolum.Text = "label3";
            // 
            // Obs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 546);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Obs";
            Text = "Obs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btn_yenile;
        private Button btn_onay;
        private Label lbl_bolum;
    }
}