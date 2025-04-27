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
            lbl_arama = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lbl_sahip = new Label();
            label10 = new Label();
            lbl_borc = new Label();
            lbl_sure = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 48);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(401, 171);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(31, 7);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 1;
            label1.Text = "fiziksel kitaplar listesi";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(497, 48);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(401, 171);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(497, 7);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 3;
            label2.Text = "E-kitaplar listesi";
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(3, 97);
            btn_ara.Margin = new Padding(3, 2, 3, 2);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(208, 49);
            btn_ara.TabIndex = 4;
            btn_ara.Text = "ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 56);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(lbl_arama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_ara);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(10, 245);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 155);
            panel1.TabIndex = 6;
            // 
            // lbl_arama
            // 
            lbl_arama.Location = new Point(229, 23);
            lbl_arama.Name = "lbl_arama";
            lbl_arama.Size = new Size(150, 100);
            lbl_arama.TabIndex = 8;
            lbl_arama.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 7;
            label3.Text = "kitap arama";
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
            panel2.Location = new Point(497, 245);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 155);
            panel2.TabIndex = 7;
            // 
            // lbl_sahip
            // 
            lbl_sahip.Location = new Point(225, 62);
            lbl_sahip.Name = "lbl_sahip";
            lbl_sahip.Size = new Size(150, 24);
            lbl_sahip.TabIndex = 13;
            // 
            // label10
            // 
            label10.Location = new Point(225, 38);
            label10.Name = "label10";
            label10.Size = new Size(150, 24);
            label10.TabIndex = 12;
            label10.Text = "sahip olduklarım";
            // 
            // lbl_borc
            // 
            lbl_borc.Location = new Point(10, 122);
            lbl_borc.Name = "lbl_borc";
            lbl_borc.Size = new Size(150, 24);
            lbl_borc.TabIndex = 11;
            // 
            // lbl_sure
            // 
            lbl_sure.Location = new Point(10, 73);
            lbl_sure.Name = "lbl_sure";
            lbl_sure.Size = new Size(150, 24);
            lbl_sure.TabIndex = 10;
            // 
            // label6
            // 
            label6.Location = new Point(10, 97);
            label6.Name = "label6";
            label6.Size = new Size(150, 24);
            label6.TabIndex = 9;
            label6.Text = "borcum";
            // 
            // label4
            // 
            label4.Location = new Point(10, 38);
            label4.Name = "label4";
            label4.Size = new Size(150, 24);
            label4.TabIndex = 8;
            label4.Text = "kalan süresi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(10, 8);
            label5.Name = "label5";
            label5.Size = new Size(246, 19);
            label5.TabIndex = 7;
            label5.Text = "ödünç aldığım kitaplar ve kalan süreleri";
            // 
            // kutuphane_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 421);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
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