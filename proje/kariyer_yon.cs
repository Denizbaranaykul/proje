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
using com.itextpdf.text.pdf;
using System.Diagnostics;
namespace proje
{
    public partial class kariyer_yon : Form
    {
        public kariyer_yon()
        {
            InitializeComponent();
            ListeleAynıŞirketeBaşvurular(Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["tc"]), listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn.Open();
            string query = "INSERT INTO kariyer (sirket_ismi,gereksinimler,teknik_beklentiler,no,pozisyon_adi)VALUES(@isim,@gereksinim,@teknik,@no,@pozisyon)";

            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isim", richTextBox_sirket_isim.Text);
            cmd.Parameters.AddWithValue("@pozisyon", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@gereksinim", richTextBox_gereksinimler.Text);
            cmd.Parameters.AddWithValue("@teknik", richTextBox_beklentiler.Text);
            cmd.Parameters.AddWithValue("@no", GlobalDatabase.Dt.Rows[0]["tc"]);
            cmd.ExecuteNonQuery();
            GlobalDatabase.Conn.Close();
            MessageBox.Show("ilan başarı ile eklendi");

        }
        static void ListeleAynıŞirketeBaşvurular(int ilanNo, ListBox listBox)
        {
            string query = @"
        SELECT b.isim, b.pozisyon, b.cv_pdf
        FROM başvurular b
        JOIN kariyer k ON b.is_ilani_id = k.id
        WHERE k.no = @no";

            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@no", ilanNo);  // Burada 'ilanNo' parametresini ekliyoruz

            try
            {
                GlobalDatabase.Conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Başvuruları listelemek için ListBox kullanıyoruz
                listBox.Items.Clear(); // Mevcut öğeleri temizle
                while (reader.Read())
                {
                    string isim = reader["isim"].ToString();
                    string pozisyon = reader["pozisyon"].ToString();
                    byte[] cv_pdf = (byte[])reader["cv_pdf"];

                    // Başvuruyu listeye ekleyelim
                    string listItem = $"{isim} - {pozisyon}";
                    listBox.Items.Add(listItem);

                    // PDF verisini 'Tag' olarak saklıyoruz
                    listBox.Items[listBox.Items.Count - 1] = new KeyValuePair<string, byte[]>(listItem, cv_pdf);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Seçili öğe
            if (listBox1.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<string, byte[]>)listBox1.SelectedItem;

                // PDF verisi
                byte[] pdfData = selectedItem.Value;

                // PDF dosyasını kaydetmek
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "cv.pdf");

                try
                {
                    // PDF verisini dosyaya yazalım
                    File.WriteAllBytes(filePath, pdfData);

                    // Dosya var mı diye kontrol edelim
                    if (File.Exists(filePath))
                    {
                        // WPS Office ile açmak için uygulama yolunu belirleyelim
                        string wpsPath = @"C:\Users\ders\AppData\Local\Kingsoft\WPS Office\ksolaunch.exe";

                        // WPS Office'in yeri farklıysa burayı güncelleyebilirsiniz
                        if (File.Exists(wpsPath))
                        {
                            // PDF dosyasını WPS Office ile açalım
                            Process.Start(wpsPath, filePath);
                        }
                        else
                        {
                            MessageBox.Show("WPS Office uygulaması bulunamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("PDF dosyası kaydedilemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF açılırken hata oluştu: " + ex.Message);
                }
            }
        }


    }
}
