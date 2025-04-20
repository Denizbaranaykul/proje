using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
namespace proje
{

    public partial class Giris : Form
    {
        public static Ana_sayfa anaSayfaForm;
        public static Giris girisFormu;
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=paü_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public static int taban = 0;
        public Giris()
        {

            InitializeComponent();
            girisFormu = this;

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

                // SQL sorgusu: ogrenci_bilgi tablosundan veya yonetici_bilgi tablosundan girilen T.C ve sifre deðerlerine sahip kaydý bul.

                cmd = new MySqlCommand(sql, conn);


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
                    // sütunlara eriþme



                }

                //coutnlar0 dan büyükse böyle bir kullanýcý bulunmuþ olur tc zaten uniqe 
                //öðrenci giriþi
                if (dt.Rows.Count > 0 && sql == "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre")
                {
                    // giriþ yapýyoz
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;



                    if (anaSayfaForm == null || anaSayfaForm.IsDisposed)
                    {
                        anaSayfaForm = new Ana_sayfa();
                    }
                    anaSayfaForm.Show();
                    this.Hide();

                }
                //yönetici bilgi sistemine giriþ
                else if (dt.Rows.Count > 0 && sql == "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre")
                {
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;

                    yonetici yonetici = new yonetici();
                    this.Hide();
                    yonetici.Show();
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
                    conn.Close();//sql sorgusunu kapatýyoz
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//öðrenci giriþi tikliyse çalýþsýn
            {
                if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(maskedTextBox2.Text))//textboxlar boþ veya null deðilse çalýþsýn
                {
                    string sql = "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";//öðrenci bilgi için sorgu komutu
                    girmek(sql);
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre boþ");
                }
            }
            else if (radioButton2.Checked) //yönetici giriþi tikliyse çalýþsýn
            {
                string sql2 = "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";// yönetici bilgi için sorgu komutu
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giriþ tipini seçmemiþsiniz");
            }

        }

        //veritabaný baðlantýsý saðlanamadýðýnda girmek için
        private void button2_Click(object sender, EventArgs e)
        {
            taban = 10;
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            this.Hide();
            ana_Sayfa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "Lütfen sýnav sonuç belgenizi yükleyiniz";
            dosyaSec.Filter = "PDF Dosyalarý (*.pdf)|*.pdf";

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                MessageBox.Show("Seçilen dosya: " + dosyaYolu);

                // Örnek: Seçilen dosyayý bir klasöre kopyala (Proje klasörü altýnda "uploads" klasörü oluþturulmuþ varsayýlýr)
                string hedefKlasor = Path.Combine(Application.StartupPath, "uploads");
                Directory.CreateDirectory(hedefKlasor); // Klasör yoksa oluþtur
                string hedefYol = Path.Combine(hedefKlasor, Path.GetFileName(dosyaYolu));

                File.Copy(dosyaYolu, hedefYol, true); // overwrite: true
                byte[] dosyaVerisi = File.ReadAllBytes(dosyaYolu);

                // Veritabaný baðlantýsýný kontrol et
                if (GlobalDatabase.Conn == null || GlobalDatabase.Conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        // Baðlantýyý aç
                        GlobalDatabase.Conn = new MySqlConnection("Server=localhost;Database=paü_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
                        GlobalDatabase.Conn.Open();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Veritabaný baðlantýsý saðlanamadý: " + ex.Message);
                        return;
                    }
                }

                string query = "INSERT INTO belgeler (dosya_adi, dosya_icerik) VALUES (@ad, @icerik)";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@ad", Path.GetFileName(dosyaYolu));
                cmd.Parameters.Add("@icerik", MySqlDbType.Blob).Value = dosyaVerisi;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dosya baþarýyla yüklendi.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Dosya yüklenirken hata oluþtu: " + ex.Message);
                }
                finally
                {
                    // Baðlantýyý kapat
                    GlobalDatabase.Conn.Close();
                }
            }
        }

    }

}
