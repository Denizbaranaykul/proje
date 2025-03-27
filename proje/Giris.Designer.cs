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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(191, 300);
            button1.Name = "button1";
            button1.Size = new Size(226, 86);
            button1.TabIndex = 0;
            button1.Text = "giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(94, 167);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(424, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(94, 244);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(424, 27);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoEN;
            pictureBox1.Location = new Point(220, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 144);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 4;
            label1.Text = "T.C numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 221);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 5;
            label2.Text = "şifre";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
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
    }
}
