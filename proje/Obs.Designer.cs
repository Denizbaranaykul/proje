﻿namespace proje
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
            lbl_bolum = new Label();
            btn_onay = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_bolum);
            panel1.Controls.Add(btn_onay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Location = new Point(-5, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 550);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Location = new Point(374, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 547);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(361, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 557);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(112, 414);
            button1.Name = "button1";
            button1.Size = new Size(176, 68);
            button1.TabIndex = 0;
            button1.Text = "Yenile";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(324, 304);
            listBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(32, 18);
            label3.Name = "label3";
            label3.Size = new Size(324, 30);
            label3.TabIndex = 3;
            label3.Text = "Ders Notları";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Obs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 546);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Obs";
            Text = "Obs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btn_onay;
        private Label lbl_bolum;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private ListBox listBox1;
        private Button button1;
    }
}