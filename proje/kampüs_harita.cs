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
        }


        private void harita(int harita)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\90551\OneDrive\Masaüstü\dbb\" + harita + ".png");
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string harita = comboBox1.Text;
            switch (harita)
            {
                case "kuşbakışı harita":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\90551\OneDrive\Masaüstü\dbb\kuşbakışı_harita.png");
                    break;
                case "uydu harita":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\90551\OneDrive\Masaüstü\dbb\uydu_harita.png");
                    break;
                
                default:break;
            }
        }
    }
}
