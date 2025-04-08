using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
namespace proje
{
    public partial class Giris : Form
    {
            
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pa�_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public static int taban = 0;
        public Giris()
        {
            InitializeComponent();
        }

        public static class GlobalDatabase
        {
            // Global olarak eri�ilebilen veritaban� bile�enleri
            public static MySqlConnection Conn { get; set; }
            public static MySqlCommand Cmd { get; set; }
            public static MySqlDataAdapter Adapter { get; set; }
            public static DataTable Dt { get; set; }
        }
        private void girmek(string sql)
        {
            try
            {
                conn.Open();

                // SQL sorgusu: ogrenci_bilgi tablosundan girilen T.C ve sifre de�erlerine sahip kayd� bul.
                
                cmd = new MySqlCommand(sql, conn);

                // Parametreleri kullanarak sorguda SQL enjeksiyonunu engelliyoruz.
                cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(maskedTextBox1.Text));
                cmd.Parameters.AddWithValue("@sifre", maskedTextBox2.Text);

                // DataAdapter ile sorgu sonucunu DataTable i�ine dolduruyoruz.
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    // S�tun adlar�n� kullanarak eri�im:
                    int id = Convert.ToInt32(row["id"]);
                    long tc = Convert.ToInt64(row["Tc"]);
                    string isim = row["isim"].ToString();
                    string soyIsim = row["soy_isim"].ToString();
                    // Di�er s�tunlar i�in de benzer �ekilde eri�ebilirsiniz.

                    // Elde edilen de�erleri kullanabilirsiniz:
                    Console.WriteLine($"ID: {id}, TC: {tc}, �sim: {isim}, Soy �sim: {soyIsim}");
                }

                // E�er sorgudan en az bir sat�r d�nd�yse kullan�c� bulundu demektir.
                if (dt.Rows.Count > 0)
                {
                    // giri� yap�yoz
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;


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

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(maskedTextBox2.Text))
                {
                    string sql = "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";
                    girmek(sql);
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre bo�");
                }
            }
            else if (radioButton2.Checked) 
            {
                string sql2 = "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giri� tipini se�memi�siniz");
            }
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            taban = 10;
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            this.Hide();
            ana_Sayfa.Show();
        }
    }

}
