using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static proje.mesaj_form;
using static proje.Giris;
namespace proje
{
    public partial class kariyer_merkezi : Form
    {
        static int id;
        static string pozisyon;
        static string sirket_ismi;
        public kariyer_merkezi()
        {
            InitializeComponent();
            string query = "SELECT sirket_ismi,pozisyon_adi FROM kariyer";
            KisiListesiniYukle(comboBox1, query, "pozisyon_adi", "sirket_ismi","-");
            
        }

        private void kariyer_merkezi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv_oluştur cv = new cv_oluştur();
            cv.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                string query = "INSERT INTO başvurular(is_ilani_id, isim, pozisyon, cv_pdf) VALUES(@ilan, @isim, @pozisyon, @pdf)";

                // PDF dosyasını seçmek için OpenFileDialog kullanabilirsiniz.
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] pdfData = File.ReadAllBytes(openFileDialog.FileName);  // PDF dosyasını byte dizisine oku

                    // Kariyer tablosundaki 'id' değerini al
                    string ilanQuery = "SELECT id FROM kariyer WHERE pozisyon_adi = @pozisyon_adi AND sirket_ismi = @sirket_ismi";
                    MySqlCommand ilanCmd = new MySqlCommand(ilanQuery, GlobalDatabase.Conn);
                    ilanCmd.Parameters.AddWithValue("@pozisyon_adi", pozisyon);  // pozisyonunuzu belirtin
                    ilanCmd.Parameters.AddWithValue("@sirket_ismi", sirket_ismi);  // şirket ismini belirtin

                    GlobalDatabase.Conn.Open();
                    var ilanId = ilanCmd.ExecuteScalar();

                    if (ilanId != null)
                    {
                        // Insert komutunu oluştur
                        MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ilan", ilanId);  // @ilan yerine alınan 'id' kullanılır
                        cmd.Parameters.AddWithValue("@isim", GlobalDatabase.Dt.Rows[0]["isim"].ToString() + " " + GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString());
                        cmd.Parameters.AddWithValue("@pozisyon", pozisyon);
                        cmd.Parameters.AddWithValue("@pdf", pdfData);  // PDF verisini byte dizisi olarak parametreye ekle

                        cmd.ExecuteNonQuery();  // Sorguyu çalıştır
                        MessageBox.Show("Başvuru başarıyla kaydedildi!");
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ilan bulunamadı.");
                    }

                    GlobalDatabase.Conn.Close();
                }
                else
                {
                    MessageBox.Show("PDF dosyası seçilmedi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin.");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT gereksinimler, teknik_beklentiler,no FROM kariyer WHERE sirket_ismi = @isim AND pozisyon_adi = @ad";
            label5.Text = comboBox1.Text;

            string selectedItem = comboBox1.Text;

            
            string[] parts = selectedItem.Split('-');

            
            if (parts.Length == 2)
            {
                
                    GlobalDatabase.Conn.Open();  

                    MySqlCommand command = new MySqlCommand(query,GlobalDatabase.Conn);

                    
                    command.Parameters.AddWithValue("@ad", parts[0]);
                    command.Parameters.AddWithValue("@isim", parts[1]);

                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())  
                        {
                            string gereksinim = reader["gereksinimler"].ToString();
                            string teknik = reader["teknik_beklentiler"].ToString();
                            id=Convert.ToInt32(reader["no"]);
                        pozisyon = parts[0];
                        sirket_ismi=parts[1];
                            label6.Text = gereksinim;
                            label7.Text = teknik;
                        }
                    }
                   GlobalDatabase.Conn.Close();
                }
            else
            {
                MessageBox.Show("lütfen  yetkililerle iletişime geçin ilanın isim bilgilerinde - ifadesi geçiyor");
            }
            
            
           
        }



    }
}
