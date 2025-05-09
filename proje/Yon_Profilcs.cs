﻿using System;
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
    public partial class Yon_Profilcs : Form
    {
        public Yon_Profilcs()
        {
            InitializeComponent();
            lbl_Tc.Text = GlobalDatabase.Dt.Rows[0]["Tc"].ToString();
            lbl_isim.Text = GlobalDatabase.Dt.Rows[0]["isim"].ToString();
            lbl_soy_isim.Text = GlobalDatabase.Dt.Rows[0]["soy_isim"].ToString();
            lbl_bolum.Text = GlobalDatabase.Dt.Rows[0]["pozisyon"].ToString();
            sifre_text_box.Text = GlobalDatabase.Dt.Rows[0]["sifre"].ToString();
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            string sifre = sifre_text_box.Text;
            GlobalDatabase.Cmd.Parameters["@tc"].Value = Convert.ToInt64(lbl_Tc.Text);
            GlobalDatabase.Cmd.Parameters["@sifre"].Value = sifre;

            GlobalDatabase.Cmd.CommandText = "UPDATE yonetici_bilgi SET sifre = @sifre WHERE Tc = @tc";

            if (GlobalDatabase.Conn.State != System.Data.ConnectionState.Open)
                GlobalDatabase.Conn.Open();
            int affectedRows = GlobalDatabase.Cmd.ExecuteNonQuery();



            if (affectedRows > 0)
                MessageBox.Show("Şifre başarıyla güncellendi.");
            else
                MessageBox.Show("Güncelleme sırasında hata oluştu, kayıt bulunamadı.");
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
