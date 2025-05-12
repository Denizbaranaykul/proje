using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class kampüs_harita : Form
    {
        public kampüs_harita()
        {
            InitializeComponent();
            haritaa("kuşbakışı_harita");
        }


        private void haritaa(string harita)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Deniz\Desktop\dbb\" + harita + ".png");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string harita = comboBox1.Text;
            switch (harita)
            {
                case "kuşbakışı harita":
                    haritaa("kuşbakışı_harita");
                    break;
                case "uydu harita":
                    haritaa("uydu_harita");
                    break;
                
                default:break;
            }
        }
    }
}
