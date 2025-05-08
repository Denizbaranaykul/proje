using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static proje.Giris;
namespace proje
{
    public partial class yon_yonetmelikler : Form
    {
        public yon_yonetmelikler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnYonetmelikYukle_Click("yonetmelikler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnYonetmelikYukle_Click("yonergeler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnYonetmelikYukle_Click("akademik_takvim");
        }
        static void btnYonetmelikYukle_Click(string code)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Yönetmelik Dosyasını Seç";
                openFileDialog.Filter = "PDF Dosyaları|*.pdf|Tüm Dosyalar|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = openFileDialog.FileName;
                    byte[] dosyaVerisi = File.ReadAllBytes(dosyaYolu);

                    try
                    {

                        GlobalDatabase.Conn.Open();

                        string query = "UPDATE universite_bilgisi SET "+code+" = @veri WHERE id = 1";

                        MySqlCommand cmd= new MySqlCommand(query,GlobalDatabase.Conn);
                        
                            cmd.Parameters.Add("@veri", MySqlDbType.MediumBlob).Value = dosyaVerisi;
                            cmd.ExecuteNonQuery();
                        


                        MessageBox.Show("Yönetmelik başarıyla güncellendi.");
                        GlobalDatabase.Conn.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
        }

    }
}
