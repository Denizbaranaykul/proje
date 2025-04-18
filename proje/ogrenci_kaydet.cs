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
    public partial class ogrenci_kaydet : Form
    {
        public ogrenci_kaydet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DosyaIndirVeSil();
        }

        private void DosyaIndirVeSil()
        {
            try
            {
                // Bağlantı açık değilse aç
                if (GlobalDatabase.Conn == null || GlobalDatabase.Conn.State == ConnectionState.Closed)
                {
                    GlobalDatabase.Conn = new MySqlConnection("Server=localhost;Database=paü_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
                    GlobalDatabase.Conn.Open();
                }

                // En eski dosyayı al (örnek olarak ID'si en küçük olan)
                string query = "SELECT id, dosya_adi, dosya_icerik FROM belgeler ORDER BY id ASC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int dosyaId = Convert.ToInt32(reader["id"]);
                    string dosyaAdi = reader["dosya_adi"].ToString();
                    byte[] dosyaVerisi = (byte[])reader["dosya_icerik"];

                    reader.Close(); // Reader açıkken DELETE yapılamaz

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
                    saveFileDialog.FileName = dosyaAdi;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, dosyaVerisi);
                        MessageBox.Show("Dosya başarıyla indirildi.");

                        // Dosya indirildikten sonra veritabanından sil
                        string deleteQuery = "DELETE FROM belgeler WHERE id = @id";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, GlobalDatabase.Conn);
                        deleteCmd.Parameters.AddWithValue("@id", dosyaId);
                        deleteCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("İndirilecek dosya bulunamadı.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                if (GlobalDatabase.Conn != null && GlobalDatabase.Conn.State == ConnectionState.Open)
                {
                    GlobalDatabase.Conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn.Open();
            string sorgu = "insert into ogrenci_bilgi (Tc,isim,soy_isim,bolum,email,sifre) VALUES(@tc,@isim,@soy_isim,@bolum,@email,@sifre)";

            MySqlCommand cmd = new MySqlCommand(sorgu,GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@tc",maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soy_isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@bolum", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("öğrenci başarı ile eklendi");

        }
    }
}
