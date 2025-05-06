using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static proje.Giris;
using static proje.toplu_mesaj;

namespace proje
{
    public partial class Kulup_basvuru : Form
    {
        public Kulup_basvuru()
        {
            InitializeComponent();
            string query = "SELECT topluluk_adi, danisman_hoca FROM topluluklar WHERE onay_durumu = 'Beklemede'";
            KisiListesiniYukle(checkedListBox1,query, "topluluk_adi", "danisman_hoca","  Hocası ise : ");
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT topluluk_adi, danisman_hoca FROM topluluklar WHERE onay_durumu = 'Beklemede'";
            try
            {
                GlobalDatabase.Conn.Open();

                string durum = radioButton1.Checked ? "Onaylandı" : "Reddedildi";

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string[] parcalar = item.ToString().Split("Hocası ise :");
                    string toplulukAdi = parcalar[0].Trim(); // "Ybs Topluluğu"

                    string query = "UPDATE topluluklar SET onay_durumu=@durum WHERE topluluk_adi=@isim";
                    MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                    cmd.Parameters.AddWithValue("@durum", durum);
                    cmd.Parameters.AddWithValue("@isim", toplulukAdi);
                    cmd.ExecuteNonQuery();
                }

                GlobalDatabase.Conn.Close();
                MessageBox.Show("Seçilen topluluklar güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            KisiListesiniYukle(checkedListBox1, query2, "topluluk_adi", "danisman_hoca", "  Hocası ise : ");
        }
    }
}
