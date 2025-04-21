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
            comboBox1 = new ComboBox();
            lbl_tarih = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_saat
            // 
            lbl_saat.AutoSize = true;
            lbl_saat.Font = new Font("Segoe UI", 12F);
            lbl_saat.Location = new Point(698, 15);
            lbl_saat.Name = "lbl_saat";
            lbl_saat.Size = new Size(86, 28);
            lbl_saat.TabIndex = 0;
            lbl_saat.Text = "00:00:00";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "beyaz salon (oğrenci)", "kırmızı salon (personel)", "morfoloji (öğrenci)", "teknik bilimler myo", "-------", "acıpayam myo", "çameli myo", "sarayköy myo", "serinhisar myo", "honaz myo", "çal myo", "çardak organize sanayi bölgesi myo", "bozkurt myo", "kale myo", "çivril atasay kemer myo", "tavas myo", "tavas sağlık hizmetleri myo", "bekilli myo", "buldan myo" });
            comboBox1.Location = new Point(32, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 1;
            // 
            // lbl_tarih
            // 
            lbl_tarih.AutoSize = true;
            lbl_tarih.Font = new Font("Segoe UI", 10F);
            lbl_tarih.Location = new Point(109, 171);
            lbl_tarih.Name = "lbl_tarih";
            lbl_tarih.Size = new Size(74, 23);
            lbl_tarih.TabIndex = 2;
            lbl_tarih.Text = "tarih seç";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl_saat);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(356, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 353);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 96);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(51, 228);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(574, 90);
            dataGridView2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(631, 228);
            button2.Name = "button2";
            button2.Size = new Size(153, 66);
            button2.TabIndex = 5;
            button2.Text = "akşam rezervasyonu ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(631, 85);
            button1.Name = "button1";
            button1.Size = new Size(153, 71);
            button1.TabIndex = 4;
            button1.Text = "öğlen rezervasyonu ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(51, 184);
            label3.Name = "label3";
            label3.Size = new Size(216, 41);
            label3.TabIndex = 1;
            label3.Text = "akşam menüsü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(51, 41);
            label2.Name = "label2";
            label2.Size = new Size(208, 41);
            label2.TabIndex = 0;
            label2.Text = "öğlen menüsü";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(33, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(109, 82);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 6;
            label1.Text = "konum seç";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(lbl_tarih);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(351, 350);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(65, 15);
            label4.Name = "label4";
            label4.Size = new Size(208, 67);
            label4.TabIndex = 7;
            label4.Text = "rezervasyon konumu ve saatini seçiniz";
            // 
            // yemekhane_ve_menü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 367);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "yemekhane_ve_menü";
            Text = "yemekhane_ve_menü";
            Load += yemekhane_ve_menü_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Label lbl_tarih;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Label label4;
    }
}