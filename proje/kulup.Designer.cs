namespace proje
{
    partial class kulup
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
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 30);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(531, 356);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(578, 103);
            button1.Name = "button1";
            button1.Size = new Size(158, 63);
            button1.TabIndex = 1;
            button1.Text = "kaydol";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(578, 197);
            button3.Name = "button3";
            button3.Size = new Size(158, 63);
            button3.TabIndex = 4;
            button3.Text = "başvuru yap";
            button3.UseVisualStyleBackColor = true;
            // 
            // kulup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 432);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "kulup";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button3;
    }
}