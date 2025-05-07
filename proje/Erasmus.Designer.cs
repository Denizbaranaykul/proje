namespace proje
{
    partial class Erasmus
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
            panel2 = new Panel();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            lbl_soru = new Label();
            btn_Geri = new Button();
            btn_Ileri = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(rb5);
            panel2.Controls.Add(rb4);
            panel2.Controls.Add(rb3);
            panel2.Controls.Add(rb2);
            panel2.Controls.Add(rb1);
            panel2.Location = new Point(22, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 105);
            panel2.TabIndex = 1;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(359, 33);
            rb5.Name = "rb5";
            rb5.Size = new Size(38, 24);
            rb5.TabIndex = 4;
            rb5.TabStop = true;
            rb5.Text = "E";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(281, 33);
            rb4.Name = "rb4";
            rb4.Size = new Size(41, 24);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "D";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(195, 33);
            rb3.Name = "rb3";
            rb3.Size = new Size(39, 24);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "C";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(102, 33);
            rb2.Name = "rb2";
            rb2.Size = new Size(39, 24);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "B";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(25, 33);
            rb1.Name = "rb1";
            rb1.Size = new Size(40, 24);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "A";
            rb1.UseVisualStyleBackColor = true;
            // 
            // lbl_soru
            // 
            lbl_soru.Location = new Point(12, 9);
            lbl_soru.Name = "lbl_soru";
            lbl_soru.Size = new Size(725, 292);
            lbl_soru.TabIndex = 2;
            lbl_soru.Text = "label1";
            // 
            // btn_Geri
            // 
            btn_Geri.Location = new Point(473, 353);
            btn_Geri.Name = "btn_Geri";
            btn_Geri.Size = new Size(94, 105);
            btn_Geri.TabIndex = 3;
            btn_Geri.Text = "geri";
            btn_Geri.UseVisualStyleBackColor = true;
            btn_Geri.Click += button1_Click;
            // 
            // btn_Ileri
            // 
            btn_Ileri.Location = new Point(597, 353);
            btn_Ileri.Name = "btn_Ileri";
            btn_Ileri.Size = new Size(140, 105);
            btn_Ileri.TabIndex = 4;
            btn_Ileri.Text = "ileri";
            btn_Ileri.UseVisualStyleBackColor = true;
            btn_Ileri.Click += btn_Ileri_Click;
            // 
            // button1
            // 
            button1.Location = new Point(766, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 105);
            button1.TabIndex = 5;
            button1.Text = "bitir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Erasmus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 587);
            Controls.Add(button1);
            Controls.Add(btn_Ileri);
            Controls.Add(btn_Geri);
            Controls.Add(lbl_soru);
            Controls.Add(panel2);
            Name = "Erasmus";
            Text = "Erasmus";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private RadioButton rb2;
        private RadioButton rb1;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private Label lbl_soru;
        private Button btn_Geri;
        private Button btn_Ileri;
        private Button button1;
    }
}