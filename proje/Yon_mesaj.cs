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
    public partial class Yon_mesaj : Form
    {
        public Yon_mesaj()
        {
            InitializeComponent();
        }

        private void btn_gndr_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "";
                string sorgu2;

                if (radioButton1.Checked && mesaj == 1)
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_ogrenci_id,baslik,mesaj_metni,gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorgu2 = "SELECT * FROM ogrenci_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else if (radioButton2.Checked && mesaj == 1)
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_yonetici_id,baslik,mesaj_metni,gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorgu2 = "SELECT * FROM yonetici_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else if (radioButton1.Checked && mesaj == 2)
                {
                    sorgu = "insert into mesajlar (gonderen_yonetici_id,alici_ogrenci_id,baslik,mesaj_metni,gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorgu2 = "SELECT * FROM ogrenci_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else
                {
                    sorgu = "insert into mesajlar (gonderen_yonetici_id,alici_yonetici_id,baslik,mesaj_metni,gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorgu2 = "SELECT * FROM yonetici_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }

                GlobalDatabase.Conn.Open();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string secilen = item.ToString();
                    string[] parcalar = secilen.Split(' ');

                    if (parcalar.Length >= 2)
                    {
                        string isim = string.Join(" ", parcalar.Take(parcalar.Length - 1));
                        string soyisim = parcalar[parcalar.Length - 1];

                        MySqlCommand aliciCmd = new MySqlCommand(sorgu2, GlobalDatabase.Conn);
                        aliciCmd.Parameters.AddWithValue("@isim", isim);
                        aliciCmd.Parameters.AddWithValue("@soy_isim", soyisim);

                        int aliciId = -1;
                        using (MySqlDataReader reader = aliciCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                aliciId = Convert.ToInt32(reader["id"]);
                            }
                        }

                        if (aliciId != -1)
                        {
                            MySqlCommand cmd = new MySqlCommand(sorgu, GlobalDatabase.Conn);
                            //cmd.Parameters.AddWithValue("@gonderen_id", ogrenciId);
                            cmd.Parameters.AddWithValue("@alici_id", aliciId);
                            cmd.Parameters.AddWithValue("@baslik", textBox1.Text);
                            cmd.Parameters.AddWithValue("@mesaj_metni", richTextBox1.Text);

                            string tam_isim = GlobalDatabase.Dt.Rows[0]["isim"].ToString() + " " + GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();
                            cmd.Parameters.AddWithValue("@gonderen", tam_isim);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                GlobalDatabase.Conn.Close();
                MessageBox.Show("Mesaj(lar) başarıyla gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                GlobalDatabase.Conn.Close();
            }
        }
        public static void KisiListesiniYukle2(CheckedListBox checkedListBox, string query, string reader1, string reader2, string bosluk)
        {
            try
            {
                checkedListBox.Items.Clear();
                GlobalDatabase.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    checkedListBox.Items.Add(reader[reader1].ToString() + bosluk + reader[reader2].ToString());
                }

                reader.Close();
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
    if (radioButton1.Checked)
    {
        query = "SELECT isim,soy_isim FROM ogrenci_bilgi";
        KisiListesiniYukle2(checkedListBox1, query, "isim", "soy_isim", " ");
    }
    else if (radioButton2.Checked)
    {
        query = "SELECT isim,soy_isim FROM yonetici_bilgi";
        KisiListesiniYukle2(checkedListBox1, query, "isim", "soy_isim", " ");
    }
        }
    }
}
