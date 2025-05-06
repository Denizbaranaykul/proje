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
    public partial class toplu_mesaj : Form
    {
        public toplu_mesaj()
        {
            InitializeComponent();
        }
        static int ogrenciId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);
        private void btn_gndr_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalDatabase.Conn.Open();

                string sorguInsert = "";
                string sorguSelect = "";

                if (radioButton1.Checked && mesaj == 1)
                {
                    sorguInsert = "INSERT INTO mesajlar (gonderen_ogrenci_id, alici_ogrenci_id, baslik, mesaj_metni, gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorguSelect = "SELECT id FROM ogrenci_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else if (radioButton2.Checked && mesaj == 1)
                {
                    sorguInsert = "INSERT INTO mesajlar (gonderen_ogrenci_id, alici_yonetici_id, baslik, mesaj_metni, gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorguSelect = "SELECT id FROM yonetici_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else if (radioButton1.Checked && mesaj == 2)
                {
                    sorguInsert = "INSERT INTO mesajlar (gonderen_yonetici_id, alici_ogrenci_id, baslik, mesaj_metni, gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorguSelect = "SELECT id FROM ogrenci_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }
                else
                {
                    sorguInsert = "INSERT INTO mesajlar (gonderen_yonetici_id, alici_yonetici_id, baslik, mesaj_metni, gonderen) VALUES (@gonderen_id, @alici_id, @baslik, @mesaj_metni, @gonderen)";
                    sorguSelect = "SELECT id FROM yonetici_bilgi WHERE isim=@isim AND soy_isim=@soy_isim";
                }

                string tam_isim = GlobalDatabase.Dt.Rows[0]["isim"].ToString() + " " + GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string secilen = item.ToString();
                    string[] parcalar = secilen.Split(' ');
                    if (parcalar.Length < 2) continue;

                    string isim = string.Join(" ", parcalar.Take(parcalar.Length - 1));
                    string soy_isim = parcalar[parcalar.Length - 1];

                    // Alıcı id'sini al
                    MySqlCommand aliciCmd = new MySqlCommand(sorguSelect, GlobalDatabase.Conn);
                    aliciCmd.Parameters.Clear();
                    aliciCmd.Parameters.AddWithValue("@isim", isim);
                    aliciCmd.Parameters.AddWithValue("@soy_isim", soy_isim);

                    object result = aliciCmd.ExecuteScalar();
                    if (result == null) continue;

                    int aliciId = Convert.ToInt32(result);

                    // Mesajı gönder
                    MySqlCommand insertCmd = new MySqlCommand(sorguInsert, GlobalDatabase.Conn);
                    insertCmd.Parameters.AddWithValue("@gonderen_id", ogrenciId);
                    insertCmd.Parameters.AddWithValue("@alici_id", aliciId);
                    insertCmd.Parameters.AddWithValue("@baslik", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@mesaj_metni", richTextBox1.Text);
                    insertCmd.Parameters.AddWithValue("@gonderen", tam_isim);
                    insertCmd.ExecuteNonQuery();
                }

                GlobalDatabase.Conn.Close();
                MessageBox.Show("Toplu mesaj gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                GlobalDatabase.Conn.Close();
            }
        }
        public static void KisiListesiniYukle(CheckedListBox listBox, string query, string reader1, string reader2, string bosluk)
        {
            try
            {
                listBox.Items.Clear();
                GlobalDatabase.Conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string adSoyad = reader[reader1].ToString() + bosluk + reader[reader2].ToString();
                    listBox.Items.Add(adSoyad);
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
            if (radioButton1.Checked)
            {
                string query = "SELECT isim,soy_isim FROM ogrenci_bilgi";
                KisiListesiniYukle(checkedListBox1, query, "isim", "soy_isim", " ");
            }
            else if (radioButton2.Checked)
            {
                string query = "SELECT isim,soy_isim FROM yonetici_bilgi";
                KisiListesiniYukle(checkedListBox1, query, "isim", "soy_isim", " ");
            }
        }
    }
}
