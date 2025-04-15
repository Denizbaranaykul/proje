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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace proje
{
    public partial class mesaj_form : Form
    {
        public mesaj_form()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            
        }

        private void KisiListesiniYukle(string query)
        {
            try
            {
                
                GlobalDatabase.Conn.Open();
                

                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["isim"].ToString());
                }

                reader.Close();
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "";
                int ogrenciId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);
                GlobalDatabase.Conn.Open();
                if(radioButton1.Checked)
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_ogrenci_id,baslik,mesaj_metni)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni)";
                }
                else
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_yonetici_id,baslik,mesaj_metni)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni)";

                }


                MySqlCommand cmd = new MySqlCommand(sorgu, GlobalDatabase.Conn);
               cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@gonderen_id",ogrenciId);

                
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query;
            comboBox1.Items.Clear();
            if(radioButton1.Checked)
            {
                query = "SELECT isim FROM ogrenci_bilgi";
                KisiListesiniYukle(query);
                
            }
            else if(radioButton2.Checked)
            {
                query = "SELECT isim FROM yonetici_bilgi";
                KisiListesiniYukle(query);
            }
        }
    }
}
