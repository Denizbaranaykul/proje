namespace proje
{
    partial class kutuphane_form
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            btn_ara = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            lbl_arama = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_sure = new Label();
            lbl_borc = new Label();
            lbl_sahip = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(458, 188);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 1;
            label1.Text = "fiziksel kitaplar listesi";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(568, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(442, 188);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(568, 9);
            label2.Name = "label2";
            label2.Size = new Size(253, 46);
            label2.TabIndex = 3;
            label2.Text = "E-kitaplar listesi";
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(3, 129);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(238, 65);
            btn_ara.TabIndex = 4;
            btn_ara.Text = "ara";
            btn_ara.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(lbl_arama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_ara);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 207);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(195, 46);
            label3.TabIndex = 7;
            label3.Text = "kitap arama";
            // 
            // lbl_arama
            // 
            lbl_arama.Location = new Point(262, 31);
            lbl_arama.Name = "lbl_arama";
            lbl_arama.Size = new Size(172, 134);
            lbl_arama.TabIndex = 8;
            lbl_arama.Text = "a";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(lbl_sahip);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lbl_borc);
            panel2.Controls.Add(lbl_sure);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(568, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 207);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(172, 32);
            label4.TabIndex = 8;
            label4.Text = "kalan süresi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(307, 23);
            label5.TabIndex = 7;
            label5.Text = "ödünç aldığım kitaplar ve kalan süreleri";
            // 
            // label6
            // 
            label6.Location = new Point(12, 129);
            label6.Name = "label6";
            label6.Size = new Size(172, 32);
            label6.TabIndex = 9;
            label6.Text = "borcum";
            // 
            // lbl_sure
            // 
            lbl_sure.Location = new Point(12, 83);
            lbl_sure.Name = "lbl_sure";
            lbl_sure.Size = new Size(172, 32);
            lbl_sure.TabIndex = 10;
            // 
            // lbl_borc
            // 
            lbl_borc.Location = new Point(12, 162);
            lbl_borc.Name = "lbl_borc";
            lbl_borc.Size = new Size(172, 32);
            lbl_borc.TabIndex = 11;
            // 
            // lbl_sahip
            // 
            lbl_sahip.Location = new Point(257, 83);
            lbl_sahip.Name = "lbl_sahip";
            lbl_sahip.Size = new Size(172, 32);
            lbl_sahip.TabIndex = 13;
            // 
            // label10
            // 
            label10.Location = new Point(257, 51);
            label10.Name = "label10";
            label10.Size = new Size(172, 32);
            label10.TabIndex = 12;
            label10.Text = "sahip olduklarım";
            // 
            // kutuphane_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 639);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "kutuphane_form";
            Text = "kutuphane_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private Button btn_ara;
        private TextBox textBox1;
        private Panel panel1;
        private Label lbl_arama;
        private Label label3;
        private Panel panel2;
        private Label lbl_sure;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label lbl_sahip;
        private Label label10;
        private Label lbl_borc;
    }
}