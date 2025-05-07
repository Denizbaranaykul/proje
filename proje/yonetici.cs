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
namespace proje
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
            if (taban == 0)
            {
                lbl_profil.Text = Convert.ToString(GlobalDatabase.Dt.Rows[0]["isim"]) + " " + GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();
            }

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();// kill him
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            Yon_Profilcs profil = new Yon_Profilcs();
            profil.Show();
        }

        private void btn_ogrenci_ekle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 9 || Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 3 || Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 6)
            {
                ogrenci_kaydet ogrenci_Kaydet = new ogrenci_kaydet();
                ogrenci_Kaydet.Show();
            }
            else
            {
                MessageBox.Show("bu özelliği kullanma yetkiniz yoktur");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 9 || Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 3 || Convert.ToInt32(GlobalDatabase.Dt.Rows[0]["yetki"]) == 6)
            {
                yon_ekle yon_Ekle = new yon_ekle();
                yon_Ekle.Show();
            }
            else
            {
                MessageBox.Show("bu özelliği kullanma yetkiniz yoktur");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yonetici_kütüphane kutup = new yonetici_kütüphane();
            kutup.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yemekhane_yon yemekhane = new yemekhane_yon();
            yemekhane.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kariyer_yon kariyer_Yon = new kariyer_yon();
            kariyer_Yon.Show();
        }

        private void btn_oturum_Click(object sender, EventArgs e)
        {

            this.Close();
            Giris.girisFormu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mesaj_form msj = new mesaj_form();
            msj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            not_ekleme not = new not_ekleme();
            not.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplu_mesaj toplu_mesaj = new toplu_mesaj();
            toplu_mesaj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kulup_basvuru kulup_Basvuru = new Kulup_basvuru();
            kulup_Basvuru.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            makale_ekle ekle = new makale_ekle();
            ekle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            egitim_destek_yon edss = new egitim_destek_yon();
            edss.Show();
        }
    }
}
