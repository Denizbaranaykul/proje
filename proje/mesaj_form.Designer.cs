namespace proje
{
    partial class mesaj_form
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 405);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 5);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "gelen kutusu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 355);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 39);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 2;
            label2.Text = "gönderilecek kişiyi seçin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(434, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 112);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "başlık giriniz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(432, 238);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(309, 94);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 201);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 7;
            label4.Text = "mesajınızı giriniz";
            // 
            // button1
            // 
            button1.Location = new Point(500, 362);
            button1.Name = "button1";
            button1.Size = new Size(175, 55);
            button1.TabIndex = 8;
            button1.Text = "gönder";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(74, 438);
            button2.Name = "button2";
            button2.Size = new Size(183, 41);
            button2.TabIndex = 9;
            button2.Text = "gelen kutusunu temizle";
            button2.UseVisualStyleBackColor = true;
            // 
            // mesaj_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "mesaj_form";
            Text = "mesaj_form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}