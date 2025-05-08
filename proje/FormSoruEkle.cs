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





        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            // 1. Boş kontrolü
            if (string.IsNullOrWhiteSpace(txt_soru.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek1.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek2.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek3.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek4.Text) ||
                string.IsNullOrWhiteSpace(txt_secenek5.Text) ||
                cmb_dogruSecenek.SelectedIndex == -1 ||
                cmb_numara.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                int secilenId = Convert.ToInt32(cmb_numara.SelectedItem);

                GlobalDatabase.Conn.Open();

                string query = @"UPDATE sorular SET 
                         soru = @soru, 
                         secenek1 = @s1, 
                         secenek2 = @s2, 
                         secenek3 = @s3, 
                         secenek4 = @s4, 
                         secenek5 = @s5, 
                         dogru = @dogru 
                         WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@soru", txt_soru.Text);
                cmd.Parameters.AddWithValue("@s1", txt_secenek1.Text);
                cmd.Parameters.AddWithValue("@s2", txt_secenek2.Text);
                cmd.Parameters.AddWithValue("@s3", txt_secenek3.Text);
                cmd.Parameters.AddWithValue("@s4", txt_secenek4.Text);
                cmd.Parameters.AddWithValue("@s5", txt_secenek5.Text);
                cmd.Parameters.AddWithValue("@dogru", cmb_dogruSecenek.SelectedIndex); // A=0, B=1...
                cmd.Parameters.AddWithValue("@id", secilenId); // hangi ID'li kayıt güncellenecek

                int rowsAffected = cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();

                if (rowsAffected > 0)
                    MessageBox.Show("Soru başarıyla güncellendi!");
                else
                    MessageBox.Show("Belirtilen ID ile eşleşen kayıt bulunamadı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

    }
}
