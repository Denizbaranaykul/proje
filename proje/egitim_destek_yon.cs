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
    public partial class egitim_destek_yon : Form
    {
        public static int ogretimElemaniId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);
        public egitim_destek_yon()
        {
            InitializeComponent();
           LoadDersler(ogretimElemaniId);
        }

        private void LoadDersler(int ogretimElemaniId)
        {
            try
            {
                // Öğretim elemanına ait dersleri alıyoruz
                string query = "SELECT ders FROM dersler WHERE ogretimElemaniId = @ogretimElemaniId";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@ogretimElemaniId", ogretimElemaniId);
                GlobalDatabase.Conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string ders = reader.GetString("ders");
                    comboBoxDersler.Items.Add(ders); // ComboBox'a dersleri ekle
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dersler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                GlobalDatabase.Conn.Close();
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Desteklenen Dosyalar|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx|PDF Dosyaları|*.pdf|Word Belgeleri|*.doc;*.docx|Excel Belgeleri|*.xls;*.xlsx|PowerPoint Sunuları|*.ppt;*.pptx";


            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                byte[] pdfBytes = File.ReadAllBytes(dosyaSec.FileName);
                string baslik = txt_baslik.Text;
                int hafta = Convert.ToInt32(box_week.Text);
                string adi = comboBoxDersler.Text.ToString();

                GlobalDatabase.Conn.Open();
                string query = "INSERT INTO eds (baslik,    adi,hafta,pdf) VALUES (@b, @y, @d, @pdf)";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@b", baslik);
                cmd.Parameters.AddWithValue("@y", adi);
                cmd.Parameters.AddWithValue("@d", hafta);
                cmd.Parameters.Add("@pdf", MySqlDbType.Blob).Value = pdfBytes;
                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();

                MessageBox.Show("Ders Materyali eklendi.");
            }
        }
    }
}
