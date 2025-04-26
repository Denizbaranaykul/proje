using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proje.Giris;
using MySql.Data.MySqlClient;
namespace proje
{
    public partial class Ana_sayfa : Form
    {
        public string[] arama_dizi = { "çıkış yap" };
        public string tam_isim;
        public Ana_sayfa()
        {

            InitializeComponent();
            if (Giris.taban == 0)
            {
                string isim = GlobalDatabase.Dt.Rows[0]["isim"].ToString();//girenk kullanıcının ismi
                string soyisim = GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();//giren kullanıcının soy adı
                lbl_profil.Text = isim + " " + soyisim;


            }
            mesajTimer.Interval = 60000; // 60.000 ms = 60 saniye
            mesajTimer.Tick += timer1_Tick;
            mesajTimer.Start();
            tam_isim = lbl_profil.Text;
        }
        //programı kapatıyor
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();// kill him

        }
        //arama yapmayı başlatıyor
        private void arama_Click(object sender, EventArgs e)
        {
            arama_cubugu.Items.Clear();
            string arama_x = arama_textbox.Text;

            foreach (var ara in arama_dizi)
            {
                if (arama_x.ToLower().Contains(ara))
                {
                    arama_cubugu.Items.Add(ara);
                }

            }

        }
        //arama çubğuna 2 kere tıklanınca olayın çalışmasını sağlıyor
        private void arama_cubugu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string secilen = arama_cubugu.SelectedItem?.ToString();

            switch (secilen)
            {
                case "çıkış yap":
                    Close_btn_Click(sender, e);
                    break;


                default:
                    MessageBox.Show("Geçersiz işlem.");
                    break;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //öğrenci bilgi sistemini açıyor
        private void button1_Click(object sender, EventArgs e)
        {
            Obs obs = new Obs();
            obs.Show();
        }

        private void btn_edp_Click(object sender, EventArgs e)
        {
            mesaj_form msj = new mesaj_form();
            msj.Show();
        }
        //öğrenci profili formunu açıyorr
        private void btn_profil_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
        }

        private void btn_otrm_kapat_Click(object sender, EventArgs e)
        {
            anaSayfaForm.Hide();
            Giris.girisFormu.Show();
        }

        private void btn_ogrencikulupleri_Click(object sender, EventArgs e)
        {
            kulup kulup = new kulup();
            kulup.Show();
        }

        private void btn_ulasim_Click(object sender, EventArgs e)
        {
            kampusUlas ULAS = new kampusUlas();
            ULAS.Show();
        }

        private void btn_kütüpanesistemi_Click(object sender, EventArgs e)
        {
            kutuphane_form kutuphane = new kutuphane_form();
            kutuphane.Show();
        }

        private void btn_ak_Click(object sender, EventArgs e)
        {
            akademik_kadro akademik = new akademik_kadro();
            akademik.Show();
        }

        private void btn_yvmb_Click(object sender, EventArgs e)
        {
            yemekhane_ve_menü yemek = new yemekhane_ve_menü();
            yemek.Show();
        }

        private void btn_makale_Click(object sender, EventArgs e)
        {

        }

        private void btn_kariyermerkezi_Click(object sender, EventArgs e)
        {
            kariyer_merkezi kariyer = new kariyer_merkezi();
            kariyer.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                GlobalDatabase.Conn.Open();
                string query = "SELECT COUNT(*) FROM mesajlar WHERE alici_ogrenci_id = @alici_ogrenci_id AND gonderim_tarihi >= NOW() - INTERVAL 1 MINUTE";
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                cmd.Parameters.AddWithValue("@alici_ogrenci_id", GlobalDatabase.Dt.Rows[0]["id"]);
                int yeniMesajSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                GlobalDatabase.Conn.Close();

                if (yeniMesajSayisi > 0)
                {
                    MessageBox.Show($"Yeni {yeniMesajSayisi} mesajınız var!", "Yeni Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (GlobalDatabase.Conn.State == ConnectionState.Open)
                    GlobalDatabase.Conn.Close();
            }

        }
    }
}