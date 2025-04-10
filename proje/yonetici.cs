using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
