namespace proje
{
    partial class toplu_mesaj
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
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_gndr = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 42);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 26;
            label5.Text = "gönderilecek kişi tipini seçiniz";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(238, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "yönetici";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "öğrenci";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btn_gndr
            // 
            btn_gndr.Location = new Point(91, 410);
            btn_gndr.Name = "btn_gndr";
            btn_gndr.Size = new Size(188, 75);
            btn_gndr.TabIndex = 23;
            btn_gndr.Text = "gönder";
            btn_gndr.UseVisualStyleBackColor = true;
            btn_gndr.Click += btn_gndr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 220);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 22;
            label4.Text = "mesajınızı giriniz";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 256);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(309, 94);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 125);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 20;
            label3.Text = "başlık giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 42);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 17;
            label2.Text = "gönderilecek kişileri seçin";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(495, 88);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(475, 554);
            checkedListBox1.TabIndex = 31;
            // 
            // toplu_mesaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 656);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btn_gndr);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "toplu_mesaj";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btn_gndr;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}