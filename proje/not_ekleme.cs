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
    public partial class not_ekleme : Form
    {
       public static int ogretimElemaniId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]); // Öğretim elemanı ID'sini almak için

        public not_ekleme()
        {
            InitializeComponent();

            LoadDersler(ogretimElemaniId);
        }

        public void ders_yuklee(int ogretimElemani)
        {
            LoadDersler(ogretimElemani);
        }
        private void LoadDersler(int ogretimElemaniId)
        {
            try
            {
                // Öğretim elemanına ait dersleri alıyoruz
                string query = "SELECT ders FROM dersler WHERE ogretimElemaniId = @ogretimElemaniId";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@ogretimElemaniId", ogretimElemaniId);
                GlobalDatabase.Conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string ders = reader.GetString("ders");
                    comboBoxDersler.Items.Add(ders); // ComboBox'a dersleri ekle
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dersler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            string dersAdi = comboBoxDersler.SelectedItem.ToString(); // Seçilen dersi al
            string ogrenciAdi = comboBox1.SelectedItem.ToString(); // Seçilen öğrenciyi al
            int vizeNotu = Convert.ToInt32(txtVize.Text); // Vize notunu al
            int finalNotu = Convert.ToInt32(txtFinal.Text); // Final notunu al

            try
            {
                // Öğrencinin ID'sini al
                string ogrenciQuery = "SELECT ogrenciId FROM ders_notlari WHERE ogrenciAdi = @ogrenciAdi";
                MySqlCommand ogrenciCmd = new MySqlCommand(ogrenciQuery, GlobalDatabase.Conn);
                ogrenciCmd.Parameters.AddWithValue("@ogrenciAdi", ogrenciAdi);
                GlobalDatabase.Conn.Open();
                int ogrenciId = Convert.ToInt32(ogrenciCmd.ExecuteScalar());
                GlobalDatabase.Conn.Close();

                // Ders notlarını güncelleyelim
                string query = "UPDATE ders_notlari " +
               "SET VizeNotu = @VizeNotu, FinalNotu = @FinalNotu " +
               "WHERE OgrenciId = @OgrenciId AND DersAdi = @DersAdi";

                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@VizeNotu", vizeNotu);
                cmd.Parameters.AddWithValue("@FinalNotu", finalNotu);
                cmd.Parameters.AddWithValue("@OgrenciId", ogrenciId);
                cmd.Parameters.AddWithValue("@DersAdi", dersAdi);

                GlobalDatabase.Conn.Open();
                int affectedRows = cmd.ExecuteNonQuery(); // Kaç satır güncellendiğini kontrol ederiz

                if (affectedRows > 0)
                {
                    MessageBox.Show("Notlar başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Not güncelleme başarısız oldu. Lütfen seçilen öğrenci ve ders bilgilerinin doğru olduğundan emin olun.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not güncellerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

        private void LoadOgrenciler(string dersAdi)
        {
            try
            {
                // Dersin öğrencilerini alıyoruz
                string query = "SELECT ogrenciId, ogrenciAdi FROM ders_notlari WHERE dersAdi = @dersAdi";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@dersAdi", dersAdi);
                GlobalDatabase.Conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                comboBox1.Items.Clear(); // Önceki öğrencileri temizle
                while (reader.Read())
                {
                    string ogrenci = reader.GetString("ogrenciAdi");
                    comboBox1.Items.Add(ogrenci); // Öğrencileri ComboBox'a ekle
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenciler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

        private void comboBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dersAdi = comboBoxDersler.SelectedItem.ToString();
            LoadOgrenciler(dersAdi);
        }
    }
}
