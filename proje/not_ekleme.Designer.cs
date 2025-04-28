namespace proje
{
    partial class not_ekleme
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
            comboBoxDersler = new ComboBox();
            txtVize = new MaskedTextBox();
            txtFinal = new MaskedTextBox();
            btnNotEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxDersler
            // 
            comboBoxDersler.FormattingEnabled = true;
            comboBoxDersler.Location = new Point(69, 67);
            comboBoxDersler.Name = "comboBoxDersler";
            comboBoxDersler.Size = new Size(121, 23);
            comboBoxDersler.TabIndex = 0;
            comboBoxDersler.SelectedIndexChanged += comboBoxDersler_SelectedIndexChanged;
            // 
            // txtVize
            // 
            txtVize.Location = new Point(69, 167);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(121, 23);
            txtVize.TabIndex = 1;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(69, 225);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(121, 23);
            txtFinal.TabIndex = 2;
            // 
            // btnNotEkle
            // 
            btnNotEkle.Location = new Point(69, 273);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(121, 47);
            btnNotEkle.TabIndex = 3;
            btnNotEkle.Text = "button1";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(69, 143);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 4;
            label1.Text = "vize";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 201);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 5;
            label2.Text = "final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(69, 43);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 6;
            label3.Text = "ders seçimi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(69, 93);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 8;
            label4.Text = "öğrenci seçimi";
            // 
            // not_ekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNotEkle);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(comboBoxDersler);
            Name = "not_ekleme";
            Text = "not_ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDersler;
        private MaskedTextBox txtVize;
        private MaskedTextBox txtFinal;
        private Button btnNotEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}