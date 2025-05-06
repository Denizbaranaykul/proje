namespace proje
{
    partial class Kulup_basvuru
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 52);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(475, 400);
            checkedListBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 35);
            label1.TabIndex = 1;
            label1.Text = "Bekleyen Başvurular";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(527, 114);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Onayla";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(527, 156);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Red et";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(527, 204);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 4;
            button1.Text = "onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(516, 52);
            label2.Name = "label2";
            label2.Size = new Size(198, 35);
            label2.TabIndex = 5;
            label2.Text = "seçili başvuruları";
            // 
            // Kulup_basvuru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 473);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Name = "Kulup_basvuru";
            Text = "Kulup_basvuru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label2;
    }
}