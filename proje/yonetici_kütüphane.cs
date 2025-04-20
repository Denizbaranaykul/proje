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
    public partial class yonetici_kütüphane : Form
    {
        public yonetici_kütüphane()
        {
            InitializeComponent();
        }
        private void ogrenci_listele()
        {
            // Üyeleri getir
            MySqlDataAdapter daUyeler = new MySqlDataAdapter("SELECT id, isim FROM ogrenci_bilgi", GlobalDatabase.Conn);
            DataTable dtUyeler = new DataTable();
            daUyeler.Fill(dtUyeler);
            cmbUyeler.DataSource = dtUyeler;
            cmbUyeler.DisplayMember = "isim";
            cmbUyeler.ValueMember = "id";
        }
        private void yonetici_kütüphane_Load(object sender, EventArgs e)
        {

            ogrenci_listele();
            kitap_getir();
        }
        private void kitap_getir()
        {
            // Kitapları getir (yalnızca fiziksel ve stokta varsa)
            MySqlDataAdapter daKitaplar = new MySqlDataAdapter("SELECT id, title FROM books WHERE is_ebook = 0", GlobalDatabase.Conn);
            DataTable dtKitaplar = new DataTable();
            daKitaplar.Fill(dtKitaplar);
            cmbKitaplar.DataSource = dtKitaplar;
            cmbKitaplar.DisplayMember = "title";
            cmbKitaplar.ValueMember = "id";

            dtBorrowDate.Value = DateTime.Today;
            dtDueDate.Value = DateTime.Today.AddDays(15); // varsayılan 15 gün
        }
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(cmbUyeler.SelectedValue);
            int bookId = Convert.ToInt32(cmbKitaplar.SelectedValue);
            DateTime borrowDate = dtBorrowDate.Value.Date;
            DateTime dueDate = dtDueDate.Value.Date;

            string kontrolQuery = "SELECT COUNT(*) FROM borrowed_books WHERE book_id = @book_id AND returned = 0";
            MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, GlobalDatabase.Conn);
            kontrolCmd.Parameters.AddWithValue("@book_id", bookId);

            GlobalDatabase.Conn.Open();
            int aktifOduncSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());
            GlobalDatabase.Conn.Close();

            if (aktifOduncSayisi > 0)
            {
                MessageBox.Show("Bu kitap zaten ödünç verilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO borrowed_books (user_id, book_id, borrow_date, due_date) VALUES (@user_id, @book_id, @borrow_date, @due_date)";

            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.AddWithValue("@book_id", bookId);
            cmd.Parameters.AddWithValue("@borrow_date", borrowDate);
            cmd.Parameters.AddWithValue("@due_date", dueDate);

            try
            {
                GlobalDatabase.Conn.Open();
                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();
                MessageBox.Show("Kitap başarıyla ödünç verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GlobalDatabase.Conn.Close();
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(cmbUyeler.SelectedValue);
            int bookId = Convert.ToInt32(cmbKitaplar.SelectedValue);

            string query = "SELECT id, due_date FROM borrowed_books WHERE user_id = @user_id AND book_id = @book_id AND returned = 0";
            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.AddWithValue("@book_id", bookId);

            GlobalDatabase.Conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int borrowId = reader.GetInt32("id");
                DateTime dueDate = reader.GetDateTime("due_date");
                reader.Close();

                DateTime today = DateTime.Today;
                double gecikmeGun = (today - dueDate).TotalDays;
                double borc = 0;

                if (gecikmeGun > 0)
                    borc = gecikmeGun * 10;

                string updateQuery = "UPDATE borrowed_books SET returned = 1 WHERE id = @id";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, GlobalDatabase.Conn);
                updateCmd.Parameters.AddWithValue("@id", borrowId);
                updateCmd.ExecuteNonQuery();

                GlobalDatabase.Conn.Close();

                MessageBox.Show("Kitap teslim alındı.\n" +
                                (borc > 0 ? $"Gecikme borcunuz: {borc} TL" : "Gecikme yok."),
                                "Teslim Alındı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GlobalDatabase.Conn.Close();
                MessageBox.Show("Bu kullanıcıya ait aktif bir ödünç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int e_kitap;
            string query = "INSERT INTO books(title,author,is_ebook,file_path) VALUES(@baslik,@yazar,@ekitap_mı,@yol)";
            if(radioButton1.Checked)
            {
               e_kitap = 1;
            }
            else
            {
                e_kitap = 0;

            }
            GlobalDatabase.Conn.Open();

            MySqlCommand cmd= new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@baslik",textBox1.Text);
            cmd.Parameters.AddWithValue("@yazar", textBox2.Text);
            cmd.Parameters.AddWithValue("@ekitap_mı",e_kitap);
            cmd.Parameters.AddWithValue("@yol", textBox3.Text);
            cmd.ExecuteNonQuery();
            GlobalDatabase.Conn.Close();
            MessageBox.Show("başarı ile kaydedildi");
            kitap_getir();
        }
    }
}
