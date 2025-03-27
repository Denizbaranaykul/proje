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
    public partial class Ana_sayfa : Form
    {
        public string[] arama_dizi = { "çıkış yap" };
        public Ana_sayfa()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapatma fonksiyonu

        }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_edp_Click(object sender, EventArgs e)
        {

        }
    }
}
