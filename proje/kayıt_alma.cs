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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace proje
{
    public partial class kayıt_alma : Form
    {
        public kayıt_alma()
        {
            InitializeComponent();
        }

        private void btn_picture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pctr_profil.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "Lütfen sınav sonuç belgenizi yükleyiniz";
            dosyaSec.Filter = "PDF Dosyaları (*.pdf)|*.pdf";

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                MessageBox.Show("Seçilen dosya: " + dosyaYolu);

                // Örnek: Seçilen dosyayı bir klasöre kopyala (Proje klasörü altında "uploads" klasörü oluşturulmuş varsayılır)
                string hedefKlasor = Path.Combine(Application.StartupPath, "uploads");
                Directory.CreateDirectory(hedefKlasor); // Klasör yoksa oluştur
                string hedefYol = Path.Combine(hedefKlasor, Path.GetFileName(dosyaYolu));

                File.Copy(dosyaYolu, hedefYol, true); // overwrite: true
                byte[] dosyaVerisi = File.ReadAllBytes(dosyaYolu);

                // Veritabanı bağlantısını kontrol et
                if (GlobalDatabase.Conn == null || GlobalDatabase.Conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        // Bağlantıyı aç
                        GlobalDatabase.Conn = new MySqlConnection("Server=localhost;Database=paü_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
                        GlobalDatabase.Conn.Open();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Veritabanı bağlantısı sağlanamadı: " + ex.Message);
                        return;
                    }
                }
                string query = "INSERT INTO belgeler (dosya_adi, dosya_icerik,profil_foto,e_mail) VALUES (@ad, @icerik,@profil,@email)";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                if (pctr_profil.Image != null && !string.IsNullOrWhiteSpace(txt_mail.Text))
                {
                    cmd.Parameters.AddWithValue("@ad", Path.GetFileName(dosyaYolu));
                    cmd.Parameters.Add("@icerik", MySqlDbType.Blob).Value = dosyaVerisi;

                    byte[] profilFotoVerisi;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pctr_profil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // veya JPEG
                        profilFotoVerisi = ms.ToArray();
                    }
                    cmd.Parameters.Add("@profil", MySqlDbType.Blob).Value = profilFotoVerisi;
                    cmd.Parameters.AddWithValue("@email", txt_mail.Text);
                }
                else
                {
                    MessageBox.Show("Profil Fotoğrafı veya e-mail kısmı");
                    return;
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başvuru başarı ile tamamlandı");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Dosya yüklenirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapat
                    GlobalDatabase.Conn.Close();
                }

            }
        }
    }
}
