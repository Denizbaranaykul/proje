using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
namespace proje
{
    public partial class Giris : Form
    {
            
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=paü_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
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
            // Global olarak eriþilebilen veritabaný bileþenleri
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

                // SQL sorgusu: ogrenci_bilgi tablosundan girilen T.C ve sifre deðerlerine sahip kaydý bul.
                
                cmd = new MySqlCommand(sql, conn);

                // Parametreleri kullanarak sorguda SQL enjeksiyonunu engelliyoruz.
                cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(maskedTextBox1.Text));
                cmd.Parameters.AddWithValue("@sifre", maskedTextBox2.Text);

                // DataAdapter ile sorgu sonucunu DataTable içine dolduruyoruz.
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    // Sütun adlarýný kullanarak eriþim:
                    int id = Convert.ToInt32(row["id"]);
                    long tc = Convert.ToInt64(row["Tc"]);
                    string isim = row["isim"].ToString();
                    string soyIsim = row["soy_isim"].ToString();
                    // Diðer sütunlar için de benzer þekilde eriþebilirsiniz.

                    // Elde edilen deðerleri kullanabilirsiniz:
                    Console.WriteLine($"ID: {id}, TC: {tc}, Ýsim: {isim}, Soy Ýsim: {soyIsim}");
                }

                // Eðer sorgudan en az bir satýr döndüyse kullanýcý bulundu demektir.
                if (dt.Rows.Count > 0)
                {
                    // giriþ yapýyoz
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
                    MessageBox.Show("Kullanýcý adý veya þifre yanlýþ");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
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
                    MessageBox.Show("Kullanýcý adý veya þifre boþ");
                }
            }
            else if (radioButton2.Checked) 
            {
                string sql2 = "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giriþ tipini seçmemiþsiniz");
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
