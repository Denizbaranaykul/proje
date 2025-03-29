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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(167, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(198, 64);
            button1.TabIndex = 0;
            button1.Text = "giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(82, 125);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(372, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(82, 183);
            maskedTextBox2.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(372, 23);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoEN;
            pictureBox1.Location = new Point(192, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 108);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "T.C numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 166);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "şifre";
            // 
            // button2
            // 
            button2.Location = new Point(423, 225);
            button2.Name = "button2";
            button2.Size = new Size(97, 64);
            button2.TabIndex = 6;
            button2.Text = "geliştirici girişi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 338);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
