namespace proje
{
    partial class Ana_sayfa
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
            pictureBox1 = new PictureBox();
            Close_btn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            arama = new Button();
            arama_cubugu = new ListBox();
            label1 = new Label();
            arama_textbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_User_Icon;
            pictureBox1.Location = new Point(939, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(1167, 201);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(125, 29);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "çıkış yap";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(arama);
            panel1.Controls.Add(arama_cubugu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(arama_textbox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Close_btn);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 276);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoEN;
            pictureBox2.Location = new Point(3, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // arama
            // 
            arama.Location = new Point(586, 83);
            arama.Name = "arama";
            arama.Size = new Size(94, 29);
            arama.TabIndex = 5;
            arama.Text = "arama yap";
            arama.UseVisualStyleBackColor = true;
            arama.Click += arama_Click;
            // 
            // arama_cubugu
            // 
            arama_cubugu.FormattingEnabled = true;
            arama_cubugu.Location = new Point(461, 126);
            arama_cubugu.Name = "arama_cubugu";
            arama_cubugu.Size = new Size(352, 104);
            arama_cubugu.TabIndex = 4;
            arama_cubugu.MouseDoubleClick += arama_cubugu_MouseDoubleClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(461, 8);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 3;
            label1.Text = "arama çubuğu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // arama_textbox
            // 
            arama_textbox.Location = new Point(461, 42);
            arama_textbox.Name = "arama_textbox";
            arama_textbox.Size = new Size(352, 27);
            arama_textbox.TabIndex = 2;
            // 
            // Ana_sayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 752);
            Controls.Add(panel1);
            Name = "Ana_sayfa";
            Text = "Ana_sayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Close_btn;
        private Panel panel1;
        private Button arama;
        private ListBox arama_cubugu;
        private Label label1;
        private TextBox arama_textbox;
        private PictureBox pictureBox2;
    }
}