﻿using System;
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
            box();
        }
        private void box()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            string query = "SELECT isim,soy_isim,durum FROM ogrenci_bilgi WHERE silindi=0";
            GlobalDatabase.Conn.Open();

            MySqlCommand komut = new MySqlCommand(query, GlobalDatabase.Conn);
            using (MySqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    string isim = reader.GetString("isim");
                    isim += "-";
                    isim += reader.GetString("soy_isim");
                    checkedListBox1.Items.Add(isim);
                    isim += "-";
                    isim += reader.GetString("durum");
                    checkedListBox2.Items.Add(isim);

                }
            }
            GlobalDatabase.Conn.Close();
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
            string sorgu = "insert into ogrenci_bilgi (Tc,isim,soy_isim,bolum,email,sifre,durum) VALUES(@tc,@isim,@soy_isim,@bolum,@email,@sifre,@durum)";

            MySqlCommand cmd = new MySqlCommand(sorgu, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soy_isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@bolum", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox5.Text);
            cmd.Parameters.AddWithValue("@durum", "aktif");
            cmd.ExecuteNonQuery();
            MessageBox.Show("öğrenci başarı ile eklendi");
            GlobalDatabase.Conn.Close();
            box();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrencileri seçin.");
                return;
            }
            DialogResult result = MessageBox.Show("Seçilen öğrenciler silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            try
            {
                GlobalDatabase.Conn.Open();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string tam_isim = item.ToString();
                    string[] dizi = tam_isim.Split("-");

                    // Ad ve soyadı alıyoruz
                    string ad = dizi[0].Trim();   // isim
                    string soyad = dizi[1].Trim(); // soyisim

                    // Öğrencinin id'sini veritabanından alıyoruz
                    string sqlGetId = "SELECT id FROM ogrenci_bilgi WHERE isim = @isim AND soy_isim = @soyisim AND silindi = 0";
                    using (MySqlCommand komutGetId = new MySqlCommand(sqlGetId, GlobalDatabase.Conn))
                    {
                        komutGetId.Parameters.AddWithValue("@isim", ad);
                        komutGetId.Parameters.AddWithValue("@soyisim", soyad);

                        object resultId = komutGetId.ExecuteScalar();
                        if (resultId != null)
                        {
                            int id = Convert.ToInt32(resultId);

                            // Öğrenciyi silme işlemi (soft delete)
                            string sqlUpdate = "UPDATE ogrenci_bilgi SET silindi = 1 WHERE id = @id";
                            using (MySqlCommand komutUpdate = new MySqlCommand(sqlUpdate, GlobalDatabase.Conn))
                            {
                                komutUpdate.Parameters.AddWithValue("@id", id);
                                komutUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
                GlobalDatabase.Conn.Close();
                MessageBox.Show("Seçilen öğrenciler silindi.");
                box(); // Listeleri güncellemek için yeniden çağırıyoruz.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ogrenci_bilgi SET durum = @durum WHERE isim = @isim and soy_isim=@soy_isim";
            GlobalDatabase.Conn.Open();
            foreach (var item in checkedListBox2.CheckedItems)
            {
                
                string tam_isim = item.ToString();
                string[] dizi = tam_isim.Split("-");

                // Ad ve soyadı alıyoruz
                string ad = dizi[0].Trim();   // isim
                string soyad = dizi[1].Trim(); // soyisim

                MySqlCommand komutQuery = new MySqlCommand(query, GlobalDatabase.Conn);
                komutQuery.Parameters.AddWithValue("@durum", "pasif");
                komutQuery.Parameters.AddWithValue("@isim", dizi[0]);
                komutQuery.Parameters.AddWithValue("@soy_isim", dizi[1]);
                komutQuery.ExecuteNonQuery();
            }
            GlobalDatabase.Conn.Close();
            box();
        }
    }
}
