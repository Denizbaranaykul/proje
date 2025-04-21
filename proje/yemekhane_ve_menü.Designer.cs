namespace proje
{
    partial class yemekhane_ve_menü
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
            components = new System.ComponentModel.Container();
            lbl_saat = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            lbl_tarih = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_saat
            // 
            lbl_saat.AutoSize = true;
            lbl_saat.Font = new Font("Segoe UI", 12F);
            lbl_saat.Location = new Point(12, 9);
            lbl_saat.Name = "lbl_saat";
            lbl_saat.Size = new Size(86, 28);
            lbl_saat.TabIndex = 0;
            lbl_saat.Text = "00:00:00";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "beyaz salon (oğrenci)", "kırmızı salon (personel)", "morfoloji (öğrenci)", "teknik bilimler myo", "-------", "acıpayam myo", "çameli myo", "sarayköy myo", "serinhisar myo", "honaz myo", "çal myo", "çardak organize sanayi bölgesi myo", "bozkurt myo", "kale myo", "çivril atasay kemer myo", "tavas myo", "tavas sağlık hizmetleri myo", "bekilli myo", "buldan myo" });
            comboBox1.Location = new Point(26, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 1;
            // 
            // lbl_tarih
            // 
            lbl_tarih.AutoSize = true;
            lbl_tarih.Font = new Font("Segoe UI", 10F);
            lbl_tarih.Location = new Point(103, 166);
            lbl_tarih.Name = "lbl_tarih";
            lbl_tarih.Size = new Size(74, 23);
            lbl_tarih.TabIndex = 2;
            lbl_tarih.Text = "tarih seç";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(362, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 353);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(103, 77);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 6;
            label1.Text = "konum seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 30);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "öğlen menüsü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 30);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 1;
            label3.Text = "akşam menüsü";
            // 
            // panel2
            // 
            panel2.Location = new Point(28, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 130);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(206, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 130);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(28, 264);
            button1.Name = "button1";
            button1.Size = new Size(153, 48);
            button1.TabIndex = 4;
            button1.Text = "öğlen rezervasyonu ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(206, 264);
            button2.Name = "button2";
            button2.Size = new Size(153, 48);
            button2.TabIndex = 5;
            button2.Text = "akşam rezervasyonu ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // yemekhane_ve_menü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(lbl_tarih);
            Controls.Add(comboBox1);
            Controls.Add(lbl_saat);
            Name = "yemekhane_ve_menü";
            Text = "yemekhane_ve_menü";
            Load += yemekhane_ve_menü_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ComboBox comboBox1;
        private Label lbl_tarih;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
    }
}