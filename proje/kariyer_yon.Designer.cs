namespace proje
{
    partial class kariyer_yon
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
            panel1 = new Panel();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            richTextBox_sirket_isim = new RichTextBox();
            richTextBox_beklentiler = new RichTextBox();
            richTextBox_gereksinimler = new RichTextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(richTextBox_sirket_isim);
            panel1.Controls.Add(richTextBox_beklentiler);
            panel1.Controls.Add(richTextBox_gereksinimler);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 684);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(33, 168);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 10;
            label6.Text = "pozisyonun adi";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 206);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(382, 33);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(33, 35);
            label4.Name = "label4";
            label4.Size = new Size(359, 59);
            label4.TabIndex = 8;
            label4.Text = "ilan oluşturma";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(33, 397);
            label3.Name = "label3";
            label3.Size = new Size(288, 28);
            label3.TabIndex = 7;
            label3.Text = "İlan İle Alakalı Teknik Beklentiler (Aranan nitelikler, yetkinlikler vs.)";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(163, 627);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 0;
            button1.Text = "ilan oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(33, 259);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 6;
            label2.Text = "Gereksinimler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(33, 94);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 5;
            label1.Text = "şirketin adı";
            // 
            // richTextBox_sirket_isim
            // 
            richTextBox_sirket_isim.Location = new Point(33, 132);
            richTextBox_sirket_isim.Name = "richTextBox_sirket_isim";
            richTextBox_sirket_isim.Size = new Size(382, 33);
            richTextBox_sirket_isim.TabIndex = 2;
            richTextBox_sirket_isim.Text = "";
            // 
            // richTextBox_beklentiler
            // 
            richTextBox_beklentiler.Location = new Point(33, 439);
            richTextBox_beklentiler.Name = "richTextBox_beklentiler";
            richTextBox_beklentiler.Size = new Size(382, 180);
            richTextBox_beklentiler.TabIndex = 4;
            richTextBox_beklentiler.Text = "";
            // 
            // richTextBox_gereksinimler
            // 
            richTextBox_gereksinimler.Location = new Point(33, 293);
            richTextBox_gereksinimler.Name = "richTextBox_gereksinimler";
            richTextBox_gereksinimler.Size = new Size(382, 87);
            richTextBox_gereksinimler.TabIndex = 3;
            richTextBox_gereksinimler.Text = "";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 25F);
            label5.Location = new Point(454, 5);
            label5.Name = "label5";
            label5.Size = new Size(359, 59);
            label5.TabIndex = 9;
            label5.Text = "İlan Listesi";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(454, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(373, 544);
            listBox1.TabIndex = 10;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // kariyer_yon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 685);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "kariyer_yon";
            Text = "kariyer_yon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox_sirket_isim;
        private RichTextBox richTextBox_beklentiler;
        private RichTextBox richTextBox_gereksinimler;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
    }
}