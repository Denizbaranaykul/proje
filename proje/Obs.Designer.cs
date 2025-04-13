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
            panel2 = new Panel();
            lbl_bolum = new Label();
            btn_onay = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(43, 176);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(332, 290);
            checkedListBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_bolum);
            panel1.Controls.Add(btn_onay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 733);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(427, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 729);
            panel2.TabIndex = 3;
            // 
            // lbl_bolum
            // 
            lbl_bolum.BackColor = SystemColors.ButtonHighlight;
            lbl_bolum.Font = new Font("Segoe UI", 12F);
            lbl_bolum.Location = new Point(43, 131);
            lbl_bolum.Name = "lbl_bolum";
            lbl_bolum.Size = new Size(333, 29);
            lbl_bolum.TabIndex = 6;
            lbl_bolum.Text = "label3";
            // 
            // btn_onay
            // 
            btn_onay.Location = new Point(89, 552);
            btn_onay.Name = "btn_onay";
            btn_onay.Size = new Size(257, 91);
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
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(411, 1);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(657, 743);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(179, 24);
            label3.Name = "label3";
            label3.Size = new Size(255, 40);
            label3.TabIndex = 3;
            label3.Text = "Ders Notları";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 18F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(37, 124);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(538, 373);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(179, 552);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(255, 91);
            button1.TabIndex = 0;
            button1.Text = "Yenile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Obs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 728);
            Controls.Add(panel3);
            Controls.Add(panel1);
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