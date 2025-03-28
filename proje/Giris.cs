using MySql.Data.MySqlClient;
using System.Data;
namespace proje
{
    public partial class Giris : Form
    {

        MySqlConnection conn= new MySqlConnection("Server=localhost;Database=pa�_app;Uid=root;Pwd=D3n!Z-25/11/2004?\r\n");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                try
                {
                    conn.Open();

                    // SQL sorgusu: ogrenci_bilgi tablosundan girilen T.C ve sifre de�erlerine sahip kayd� bul.
                    string sql = "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";
                    cmd = new MySqlCommand(sql, conn);

                    // Parametreleri kullanarak sorguda SQL enjeksiyonunu engelliyoruz.
                    cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(maskedTextBox1.Text));
                    cmd.Parameters.AddWithValue("@sifre", maskedTextBox2.Text);

                    // DataAdapter ile sorgu sonucunu DataTable i�ine dolduruyoruz.
                    adapter = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    // E�er sorgudan en az bir sat�r d�nd�yse kullan�c� bulundu demektir.
                    if (dt.Rows.Count > 0)
                    {
                        Ana_sayfa ana_Sayfa = new Ana_sayfa();
                        this.Hide();
                        ana_Sayfa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad� veya �ifre yanl��");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo�");
            }
        }
    }

}
