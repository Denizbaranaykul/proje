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
    public partial class kutuphane_form : Form
    {
        public kutuphane_form()
        {
            InitializeComponent();
            EKitaplariYukle();
            KitaplariYukle();
        }
        private void EKitaplariYukle()
        {
            string query = "SELECT  title, author FROM books WHERE is_ebook = 1";
            MySqlDataAdapter da = new MySqlDataAdapter(query, GlobalDatabase.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void KitaplariYukle()
        {
            string query = "SELECT  title, author FROM books WHERE is_ebook = 0";
            MySqlDataAdapter da = new MySqlDataAdapter(query, GlobalDatabase.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string filePath = dataGridView2.Rows[e.RowIndex].Cells["file_path"].Value.ToString();

                if (!string.IsNullOrEmpty(filePath))
                {
                    // Kullanıcıdan nereye kaydedeceğini sor
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.FileName = System.IO.Path.GetFileName(filePath);

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            System.IO.File.Copy(filePath, saveDialog.FileName, true);
                            MessageBox.Show("E-kitap başarıyla indirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string arananKelime = textBox1.Text.Trim(); // txt_ara, bir TextBox olduğunu varsayıyorum
            if (string.IsNullOrEmpty(arananKelime))
            {
                // Eğer arama kutusu boşsa, tüm kitapları tekrar yükle
                KitaplariYukle();
                EKitaplariYukle();
            }
            else
            {
                // Normal kitaplar için arama
                string queryNormal = "SELECT  title, author FROM books WHERE is_ebook = 0 AND title LIKE @title";
                MySqlDataAdapter daNormal = new MySqlDataAdapter(queryNormal, GlobalDatabase.Conn);
                daNormal.SelectCommand.Parameters.AddWithValue("@title", "%" + arananKelime + "%");
                DataTable dtNormal = new DataTable();
                daNormal.Fill(dtNormal);
                dataGridView1.DataSource = dtNormal;

                // E-kitaplar için arama
                string queryEkitap = "SELECT title, author FROM books WHERE is_ebook = 1 AND title LIKE @title";
                MySqlDataAdapter daEkitap = new MySqlDataAdapter(queryEkitap, GlobalDatabase.Conn);
                daEkitap.SelectCommand.Parameters.AddWithValue("@title", "%" + arananKelime + "%");
                DataTable dtEkitap = new DataTable();
                daEkitap.Fill(dtEkitap);
                dataGridView2.DataSource = dtEkitap;
            }
        }
    }
}
