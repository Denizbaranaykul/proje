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
using static proje.Ana_sayfa;
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
            int mesaj = Giris.mesaj;


        }
        static int ogrenciId = Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["id"]);

        public static void KisiListesiniYukle(ComboBox comboBox, string query,string reader1,string reader2,string bosluk)
        {
            try
            {


                GlobalDatabase.Conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader[reader1].ToString() +bosluk+ reader[reader2].ToString());

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
                string sorgu2;
                
                GlobalDatabase.Conn.Open();

                if (radioButton1.Checked&& mesaj==1)
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_ogrenci_id,baslik,mesaj_metni,gonderen)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni,@gonderen)";
                    sorgu2 = "SELECT * FROM ogrenci_bilgi WHERE isim=@isim and soy_isim=@soy_isim";
                }
                else if (radioButton2.Checked&& mesaj==1) 
                {
                    sorgu = "insert into mesajlar (gonderen_ogrenci_id,alici_yonetici_id,baslik,mesaj_metni,gonderen)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni,@gonderen)";
                    sorgu2 = "SELECT * FROM yonetici_bilgi WHERE isim=@isim and soy_isim=@soy_isim";
                }
                else if(radioButton1.Checked &&  mesaj==2)
                {
                    sorgu = "insert into mesajlar (gonderen_yonetici_id,alici_ogrenci_id,baslik,mesaj_metni,gonderen)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni,@gonderen)";
                    sorgu2 = "SELECT * FROM ogrenci_bilgi WHERE isim=@isim and soy_isim=@soy_isim";
                }
                else
                {
                    sorgu = "insert into mesajlar (gonderen_yonetici_id,alici_yonetici_id,baslik,mesaj_metni,gonderen)VALUES (@gonderen_id,@alici_id,@baslik,@mesaj_metni,@gonderen)";
                    sorgu2 = "SELECT * FROM yonetici_bilgi WHERE isim=@isim and soy_isim=@soy_isim";
                }
                    MySqlCommand alici = new MySqlCommand(sorgu2, GlobalDatabase.Conn);
                alici.Parameters.AddWithValue("@isim", label_isim.Text);
                alici.Parameters.AddWithValue("@soy_isim", label_soy_isim.Text);

                int aliciId = -1;

                using (MySqlDataReader reader = alici.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        aliciId = Convert.ToInt32(reader["id"]);
                    }
                    else
                    {
                        MessageBox.Show("Alıcı bulunamadı.");
                        GlobalDatabase.Conn.Close();
                        return;
                    }
                }
                string tam_isim = GlobalDatabase.Dt.Rows[0]["isim"].ToString();
                tam_isim += " ";
                tam_isim += GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();
                MySqlCommand cmd = new MySqlCommand(sorgu, GlobalDatabase.Conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@gonderen_id", ogrenciId);
                cmd.Parameters.AddWithValue("@alici_id", aliciId);
                cmd.Parameters.AddWithValue("@baslik", textBox1.Text);
                cmd.Parameters.AddWithValue("@mesaj_metni", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@gonderen", tam_isim);
                cmd.ExecuteNonQuery();
                GlobalDatabase.Conn.Close();
                MessageBox.Show("Mesaj başarıyla gönderildi!");
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
            if (radioButton1.Checked)
            {
                query = "SELECT isim,soy_isim FROM ogrenci_bilgi";
                KisiListesiniYukle(comboBox1, query,"isim","soy_isim"," ");

            }
            else if (radioButton2.Checked)
            {
                query = "SELECT isim,soy_isim FROM yonetici_bilgi";
                KisiListesiniYukle(comboBox1, query, "isim", "soy_isim"," ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string secilen = comboBox1.SelectedItem.ToString();
                string[] parcalar = secilen.Split(' ');

                if (parcalar.Length >= 2)
                {
                    // Soyadı son parça
                    label_soy_isim.Text = parcalar[parcalar.Length - 1];

                    // İsmi geri kalan parçaların birleşimi
                    label_isim.Text = string.Join(" ", parcalar.Take(parcalar.Length - 1));
                }
            }
        }
        private void Yazma(int aliciId)
        {
            string query;
            if(mesaj==1)
            {
                query = "SELECT gonderen,baslik,mesaj_metni,gonderim_tarihi FROM mesajlar WHERE alici_ogrenci_id = @alici_ogrenci_id";
            }
            else
            {
                query = "SELECT gonderen,baslik,mesaj_metni,gonderim_tarihi FROM mesajlar WHERE alici_yonetici_id = @alici_ogrenci_id";
            }

            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@alici_ogrenci_id", aliciId);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["mesaj_metni"].Width = 300;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazma(ogrenciId);
        }
    }
}