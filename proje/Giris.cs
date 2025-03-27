namespace proje
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                if (Convert.ToInt64(maskedTextBox1.Text) == 12345 && Convert.ToInt32(maskedTextBox2.Text) == 12345)
                {
                    Ana_sayfa ana_Sayfa = new Ana_sayfa();
                    this.Hide();
                    ana_Sayfa.Show();
                }
                else
                {
                    MessageBox.Show("kullanýcý adý veya þifre yanlýþ");
                }
            }
            else 
            {
                MessageBox.Show("kullanýcý adý veya þifre boþ");
            }
        }
    }
}
