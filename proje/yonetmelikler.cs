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
    public partial class yonetmelikler : Form
    {
        public yonetmelikler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DosyaIndir("yonergeler", "yonerge.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DosyaIndir("yonetmelikler", "yonetmelik.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyaIndir("akademik_takvim", "akademik_takvim.pdf");

        }
        private void DosyaIndir(string kolonAdi, string varsayilanDosyaAdi)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "PDF Dosyasını Kaydet";
                saveFileDialog.Filter = "PDF Dosyaları|*.pdf";
                saveFileDialog.FileName = varsayilanDosyaAdi;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        GlobalDatabase.Conn.Open();

                        string query = $"SELECT {kolonAdi} FROM universite_bilgisi WHERE id = 1";
                        using (MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                byte[] pdfVerisi = (byte[])reader[0];
                                File.WriteAllBytes(saveFileDialog.FileName, pdfVerisi);
                                MessageBox.Show("PDF başarıyla indirildi.");
                            }
                            else
                            {
                                MessageBox.Show("Dosya bulunamadı veya içerik boş.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        GlobalDatabase.Conn.Close(); // bağlantıyı kapatmayı unutma
                    }
                }


            }
        }
    }
}

