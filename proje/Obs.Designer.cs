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
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            btn_yenile = new Button();
            btn_onay = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 28);
            comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(43, 176);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(332, 312);
            checkedListBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btn_yenile);
            panel1.Controls.Add(btn_onay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 734);
            panel1.TabIndex = 2;
            // 
            // btn_yenile
            // 
            btn_yenile.Location = new Point(172, 494);
            btn_yenile.Name = "btn_yenile";
            btn_yenile.Size = new Size(94, 29);
            btn_yenile.TabIndex = 5;
            btn_yenile.Text = "yenile";
            btn_yenile.UseVisualStyleBackColor = true;
            btn_yenile.Click += btn_yenile_Click;
            // 
            // btn_onay
            // 
            btn_onay.Location = new Point(89, 552);
            btn_onay.Name = "btn_onay";
            btn_onay.Size = new Size(257, 90);
            btn_onay.TabIndex = 4;
            btn_onay.Text = "onayla";
            btn_onay.UseVisualStyleBackColor = true;
            btn_onay.Click += btn_onay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "bölümünüzü seçin";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(89, 24);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 2;
            label1.Text = " Ders kayıt işlemleri";
            // 
            // Obs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 728);
            Controls.Add(panel1);
            Name = "Obs";
            Text = "Obs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btn_yenile;
        private Button btn_onay;
    }
}