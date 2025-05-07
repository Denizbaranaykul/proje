using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proje.Giris;
using MySql.Data.MySqlClient;
namespace proje
{
    public partial class Erasmus : Form
    {
        public Erasmus()
        {
            InitializeComponent();
            SorulariYukle();

            if (sorular.Count > 0)
            {
                SoruGoster(0);
            }
            else
            {
                MessageBox.Show("Veritabanında hiç soru bulunamadı.");
                this.Close(); // veya butonları devre dışı bırak
            }
        }

        public class Soru
        {
            public int Id { get; set; }
            public string Metin { get; set; }
            public List<string> Secenekler { get; set; }
            public int DogruSecenek { get; set; }
        }
        List<Soru> sorular = new List<Soru>();
        List<int> kullaniciSecimleri = new List<int>();
        int soruIndex = 0;

        void SorulariYukle()
        {
            sorular.Clear();
            kullaniciSecimleri.Clear();

            string query = "SELECT id, soru, secenek1, secenek2, secenek3, secenek4, secenek5, dogru FROM sorular LIMIT 20";
            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);

            GlobalDatabase.Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sorular.Add(new Soru
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Metin = reader["soru"].ToString(),
                    Secenekler = new List<string>
            {
                reader["secenek1"].ToString(),
                reader["secenek2"].ToString(),
                reader["secenek3"].ToString(),
                reader["secenek4"].ToString(),
                reader["secenek5"].ToString(),
            },
                    DogruSecenek = Convert.ToInt32(reader["dogru"])
                });

                kullaniciSecimleri.Add(-1); // her soru için başlangıçta seçim yok
            }

            GlobalDatabase.Conn.Close();
        }
        void SoruGoster(int index)
        {
            if (index < 0 || index >= sorular.Count) return;

            var soru = sorular[index];
            lbl_soru.Text = $"Soru {index + 1}: {soru.Metin}";
            rb1.Text = soru.Secenekler[0];
            rb2.Text = soru.Secenekler[1];
            rb3.Text = soru.Secenekler[2];
            rb4.Text = soru.Secenekler[3];
            rb5.Text = soru.Secenekler[4];

            // Önceki seçimi geri yükle
            rb1.Checked = kullaniciSecimleri[index] == 0;
            rb2.Checked = kullaniciSecimleri[index] == 1;
            rb3.Checked = kullaniciSecimleri[index] == 2;
            rb4.Checked = kullaniciSecimleri[index] == 3;
            rb5.Checked = kullaniciSecimleri[index] == 4;

            // Butonların durumunu ayarla
            btn_Geri.Enabled = (index > 0);
            btn_Ileri.Text = (index == sorular.Count - 1) ? "Bitir" : "İleri";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KaydetSecim();

            if (soruIndex > 0)
            {
                soruIndex--;
                SoruGoster(soruIndex);
            }
        }
        void KaydetSecim()
        {
            int secim = -1;
            if (rb1.Checked) secim = 0;
            else if (rb2.Checked) secim = 1;
            else if (rb3.Checked) secim = 2;
            else if (rb4.Checked) secim = 3;
            else if (rb5.Checked) secim = 4;

            kullaniciSecimleri[soruIndex] = secim;
        }

        private void btn_Ileri_Click(object sender, EventArgs e)
        {
            KaydetSecim();

            if (soruIndex < sorular.Count - 1)
            {
                soruIndex++;
                SoruGoster(soruIndex);
            }
            
        }
        void TestiBitir()
        {
            int dogruSayisi = 0;
            for (int i = 0; i < sorular.Count; i++)
            {
                if (kullaniciSecimleri[i] == sorular[i].DogruSecenek)
                    dogruSayisi++;
            }

            MessageBox.Show($"Test bitti. Doğru sayısı: {dogruSayisi}");

            try
            {
                GlobalDatabase.Conn.Open();
                string query = "INSERT INTO sonuc (kullanici_id, dogru_sayisi, tarih) VALUES (@kullanici_id, @dogru, @tarih)";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@kullanici_id", GlobalDatabase.Dt.Rows[0]["id"]);
                cmd.Parameters.AddWithValue("@dogru", dogruSayisi);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sonuç kaydı hatası: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KaydetSecim();  // Son sorunun seçimini kaydet
            TestiBitir();
        }
    }
}
