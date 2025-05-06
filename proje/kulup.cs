
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
using static proje.mesaj_form;
namespace proje
{
    public partial class kulup : Form
    {
        public kulup()
        {
            InitializeComponent();
            string query = "SELECT isim,soy_isim FROM yonetici_bilgi";
            KisiListesiniYukle(comboBox1, query, "isim", "soy_isim"," ");
            OnayliTopluluklariListele();
        }


        private void OnayliTopluluklariListele()
        {
            listBox1.Items.Clear();

            string query = "SELECT topluluk_adi FROM topluluklar WHERE onay_durumu = 'Onaylandı'";

            try
            {
                GlobalDatabase.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["topluluk_adi"].ToString());
                }

                reader.Close();
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnayliTopluluklariListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananKelime = textBoxArama.Text.Trim(); // arama çubuğunun adı

            listBox1.Items.Clear();

            string query = "SELECT topluluk_adi FROM topluluklar WHERE onay_durumu = 'Onaylandı' AND topluluk_adi LIKE @aranan";

            try
            {
                GlobalDatabase.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@aranan", "%" + arananKelime + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["topluluk_adi"].ToString());
                }

                reader.Close();
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn.Open();
            string query = "INSERT INTO topluluklar(topluluk_adi,danisman_hoca) VALUES(@isim,@hoca)";
            MySqlCommand cmd = new MySqlCommand(query,GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@isim",textBox1.Text);
            cmd.Parameters.AddWithValue("@hoca",comboBox1.Text);
            cmd.ExecuteNonQuery();
            GlobalDatabase.Conn.Close();
            MessageBox.Show("Başvuru başarı ile yapıldı");
        }
    }
}