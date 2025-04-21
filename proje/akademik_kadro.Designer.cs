namespace proje
{
    partial class akademik_kadro
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
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "toplam öğrenci sayisi", "erkek öğrenci sayisi", "kız öğrenci sayisi", "mezun sayisi ", "akademik personel sayisi", "idari personel sayisi", "öğretim üyesi sayisi", "araştırma gorevlisi sayisi", "öğretim görevlisi sayisi", "prof. dr. sayisi", "doç. dr. sayisi", "dr. öğr. üyesi sayisi" });
            comboBox1.Location = new Point(41, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(417, 85);
            button1.Name = "button1";
            button1.Size = new Size(120, 28);
            button1.TabIndex = 5;
            button1.Text = "göster";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 56);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "sonuç";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 132);
            panel1.TabIndex = 7;
            // 
            // akademik_kadro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "akademik_kadro";
            Text = "akademik_kadro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Panel panel1;
    }
}