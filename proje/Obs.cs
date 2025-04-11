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

        public string[] dersIsletme = { "İşletme", "Maliye", "Pazarlama", "Ekonomi", "Exel", "Tarih", "İngilizce", "Matematik" };
        public string[] dersYbs = { "İşletme", "Maliye", "Pazarlama", "Hukuk", "Programlama", "Tarih", "İngilizce", "Matematik" };
        public string[] dersBilgisayar = { "İşletme", "Mühendisliğe giriş", "Kimya", "Fizik", "Programlama", "Tarih", "İngilizce", "Matematik" };


        public Obs()
        {
            InitializeComponent();
            if (Giris.taban==0)
            {

            
            lbl_bolum.Text = GlobalDatabase.Dt.Rows[0]["bolum"].ToString();
        }
            switch (lbl_bolum.Text)
            {
                case "İşletme":
                    checkedListBox1.Items.AddRange(dersIsletme);
                    break;
                    
                case "Yönetim Bilişim Sistemleri":
                    checkedListBox1.Items.AddRange(dersYbs);
                    break;

                case "Bilgisayar Mühendisliği":
                    checkedListBox1.Items.AddRange(dersBilgisayar);
                    break;

                default:
                    MessageBox.Show("Lütfen geçerli bir bölüm seçiniz.");
                    break;
            }

        }

        private void btn_onay_Click(object sender, EventArgs e)
        {
            secilen.Clear();

            
            
            try
            {
            GlobalDatabase.Conn.Open();
            string sorgu = "INSERT INTO ders_notlari (OgrenciId,DersAdi) VALUES(@OgrenciId,@DersAdi)";
            MySqlCommand mySqlCommand = new MySqlCommand(sorgu,GlobalDatabase.Conn);
                int ogrenciId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);
            foreach (var item in checkedListBox1.CheckedItems)
            {
                
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.AddWithValue("@OgrenciId", ogrenciId);   
                    mySqlCommand.Parameters.AddWithValue("@DersAdi", item.ToString());
                    mySqlCommand.ExecuteNonQuery();//sorgu çalıştırma
            }
                MessageBox.Show("Seçilen dersler başarıyla eklendi.");
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ders ismi eklenirken bir hata oluştu : "+ex.Message);
            }
        }

        
    }
}
