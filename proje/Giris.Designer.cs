namespace proje
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 344);
            button1.Name = "button1";
            button1.Size = new Size(226, 85);
            button1.TabIndex = 0;
            button1.Text = "giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(90, 211);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(425, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(90, 288);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(425, 27);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoEN;
            pictureBox1.Location = new Point(219, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 188);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 4;
            label1.Text = "T.C numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 265);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 5;
            label2.Text = "şifre";
            // 
            // button2
            // 
            button2.Location = new Point(479, 344);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 85);
            button2.TabIndex = 6;
            button2.Text = "geliştirici girişi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(127, 161);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "öğrenci girişi";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(313, 161);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "yönetici_girişi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(187, 435);
            button3.Name = "button3";
            button3.Size = new Size(226, 85);
            button3.TabIndex = 9;
            button3.Text = "kaydol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 522);
            Controls.Add(button3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Name = "Giris";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button3;
    }
}
