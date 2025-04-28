using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proje.Giris;

namespace proje
{
    public partial class Obs : Form
    {
        public List<string> secilen = new List<string>();

        public static List<string> derslers = new List<string>();

        public List<string> derslersecilen = new List<string>();

        public string[] dersIsletme = { "İşletme", "Maliye", "Pazarlama", "Ekonomi", "Exel", "Tarih", "İngilizce", "Matematik" };
        public string[] dersYbs = { "İşletme", "Maliye", "Pazarlama", "Hukuk", "Programlama", "Tarih", "İngilizce", "Matematik" };
        public string[] dersBilgisayar = { "İşletme", "Mühendisliğe giriş", "Kimya", "Fizik", "Programlama", "Tarih", "İngilizce", "Matematik" };

        public static void Okuma(List<string> a, string query, string get, int x)
        {
            GlobalDatabase.Conn.Open();

            MySqlCommand komut = new MySqlCommand(query, GlobalDatabase.Conn);
            using (MySqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (x == 1)
                    {
                        string ders = reader.GetString(get);
                        a.Add(ders);
                    }
                    else
                    {
                        int vize = reader["VizeNotu"] == DBNull.Value ? 0 : Convert.ToInt32(reader["VizeNotu"]);
                        int final = reader["FinalNotu"] == DBNull.Value ? 0 : Convert.ToInt32(reader["FinalNotu"]);
                        string satir = $"{reader["dersAdi"]} - Vize: {vize} Final: {final}";
                        a.Add(satir);
                    }
                }
            }
            GlobalDatabase.Conn.Close();
        }
        public int ogren = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);
        public Obs()
        {
            InitializeComponent();
            if (Giris.taban == 0)//geliştirici girişi mi diye kontrrol
            {


                lbl_bolum.Text = GlobalDatabase.Dt.Rows[0]["bolum"].ToString();//bölüm kısmını data base den çekme
                string query = "SELECT ders FROM dersler";//dersleri yazdırmak için sql komutu
                Okuma(derslers, query, "ders", 1);
                string query2 = "SELECT dersAdi,VizeNotu,FinalNotu FROM ders_notlari";//dersleri ve notları tablo şeklinde yazdırma
                Okuma(derslersecilen, query2, "dersAdi", 2);


            }
            switch (lbl_bolum.Text)
            {
                case "İşletme":
                    checkedListBox1.Items.AddRange(dersIsletme);
                    break;

                case "Yönetim Bilişim Sistemleri":
                    foreach (string item in derslers)
                    {
                        checkedListBox1.Items.Add(item);
                    }

                    break;

                case "Bilgisayar Mühendisliği":
                    checkedListBox1.Items.AddRange(dersBilgisayar);
                    break;

                default:
                    MessageBox.Show("Lütfen geçerli bir bölüm seçiniz.");
                    break;
            }

        }
        //dersleri veri tabanına ekleme fonksiyonu
        private void btn_onay_Click(object sender, EventArgs e)
        {
            secilen.Clear();



            try
            {
                GlobalDatabase.Conn.Open();//sorguyu aç
                string sorgu = "INSERT INTO ders_notlari (OgrenciId,DersAdi) VALUES(@OgrenciId,@DersAdi)";//sorgu
                MySqlCommand mySqlCommand = new MySqlCommand(sorgu, GlobalDatabase.Conn);
                int ogrenciId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);//id yi çek

                int kredi = 0;
                string insertSorgu = "INSERT INTO ders_notlari (OgrenciId, DersAdi) VALUES(@OgrenciId, @DersAdi)";//sorgu 2
                MySqlCommand insertCommand = new MySqlCommand(insertSorgu, GlobalDatabase.Conn);
                foreach (var item in checkedListBox1.CheckedItems)//kredi kontrol sorgusu
                {
                    string dersAdi = item.ToString();

                    string krediSorgu = "SELECT kredi FROM dersler WHERE ders = @dersAdi";
                    MySqlCommand krediCmd = new MySqlCommand(krediSorgu, GlobalDatabase.Conn);
                    krediCmd.Parameters.AddWithValue("@dersAdi", dersAdi);

                    object sonuc = krediCmd.ExecuteScalar();
                    if (sonuc != null)
                    {
                        int kredi_gecici = Convert.ToInt32(sonuc);
                        kredi += kredi_gecici;
                    }
                }



                if (kredi <= 30)
                {
                    foreach (var item in checkedListBox1.CheckedItems)//dersleri ekleme döngüsü
                    {

                        mySqlCommand.Parameters.Clear();
                        mySqlCommand.Parameters.AddWithValue("@OgrenciId", ogrenciId);
                        mySqlCommand.Parameters.AddWithValue("@DersAdi", item.ToString());

                        mySqlCommand.ExecuteNonQuery();//sorgu çalıştırma
                    }
                    MessageBox.Show("Seçilen dersler başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Toplam kredi 30'u geçemez! Seçilen krediler: " + kredi);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ders ismi eklenirken bir hata oluştu : " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazma(ogren);

        }
        private void Yazma(int ogrenciId)
        {
            string query = "SELECT dersAdi, VizeNotu, FinalNotu FROM ders_notlari WHERE OgrenciId = @ogrenciId";
            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private double GanoHesapla(int ogrenciId)
        {
            try
            {
                double toplamNot = 0;
                double toplamKredi = 0;

                GlobalDatabase.Conn.Open(); // <-- bağlantıyı açtık

                string query = "SELECT dersAdi, VizeNotu, FinalNotu, kredi FROM ders_notlari " +
                               "INNER JOIN dersler ON ders_notlari.DersAdi = dersler.ders WHERE OgrenciId = @ogrenciId";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@ogrenciId", ogrenciId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dersAdi = reader.GetString("dersAdi");
                    int vizeNotu = reader["VizeNotu"] == DBNull.Value ? 0 : reader.GetInt32("VizeNotu");
                    int finalNotu = reader["FinalNotu"] == DBNull.Value ? 0 : reader.GetInt32("FinalNotu");
                    int kredi = reader["kredi"] == DBNull.Value ? 0 : reader.GetInt32("kredi");

                    double dersNotu = (vizeNotu * 0.4) + (finalNotu * 0.6);

                    toplamNot += dersNotu * kredi;
                    toplamKredi += kredi;
                }

                reader.Close();
                GlobalDatabase.Conn.Close(); // <-- bağlantıyı kapattık

                if (toplamKredi == 0)
                {
                    return 0;
                }
                    

                return (toplamNot / toplamKredi)/25;
            }
            catch (Exception ex)
            {
                MessageBox.Show("GANO hesaplanırken bir hata oluştu: " + ex.Message);
                GlobalDatabase.Conn.Close(); // Hata olursa da bağlantıyı kapat
                return 0;
            }
        }



        private void btn_GanoHesapla_Click(object sender, EventArgs e)
        {
            double gano = GanoHesapla(ogren);
            MessageBox.Show("Gano : " + gano);
        }
    }
}
