using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static proje.Giris;

namespace proje
{
    public partial class FormSoruEkle : Form
    {
        public FormSoruEkle()
        {
            InitializeComponent();
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Boş kontrolü
            if (string.IsNullOrWhiteSpace(txt_soru.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek1.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek2.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek3.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek4.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek5.Text) ||
                cmb_dogruSecenek.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                // 2. Veritabanına ekleme
                GlobalDatabase.Conn.Open();

                string query = @"INSERT INTO sorular 
                (soru, secenek1, secenek2, secenek3, secenek4, secenek5, dogru) 
                VALUES (@soru, @s1, @s2, @s3, @s4, @s5, @dogru)";

                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@soru", txt_soru.Text);
                cmd.Parameters.AddWithValue("@s1", txt_secenek1.Text);
                cmd.Parameters.AddWithValue("@s2", txt_secenek2.Text);
                cmd.Parameters.AddWithValue("@s3", txt_secenek3.Text);
                cmd.Parameters.AddWithValue("@s4", txt_secenek4.Text);
                cmd.Parameters.AddWithValue("@s5", txt_secenek5.Text);
                cmd.Parameters.AddWithValue("@dogru", cmb_dogruSecenek.SelectedIndex); // A=0, B=1...

                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();

                MessageBox.Show("Soru başarıyla eklendi!");
                this.Close(); // veya: formu temizlemek için alanları sıfırla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }
    }
}
