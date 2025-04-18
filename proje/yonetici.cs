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
    }
}
