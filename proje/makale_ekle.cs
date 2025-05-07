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
    public partial class makale_ekle : Form
    {
        public makale_ekle()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "PDF Dosyaları (*.pdf)|*.pdf";

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                byte[] pdfBytes = File.ReadAllBytes(dosyaSec.FileName);
                string baslik = txt_baslik.Text;
                string yazar = txt_yazar.Text;
                string dergi = txt_dergi.Text;

                GlobalDatabase.Conn.Open();
                string query = "INSERT INTO makaleler (baslik, yazar, dergi, pdf_icerik) VALUES (@b, @y, @d, @pdf)";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@b", baslik);
                cmd.Parameters.AddWithValue("@y", yazar);
                cmd.Parameters.AddWithValue("@d", dergi);
                cmd.Parameters.Add("@pdf", MySqlDbType.Blob).Value = pdfBytes;
                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();

                MessageBox.Show("Makale eklendi.");
            }
        }
    }
}
