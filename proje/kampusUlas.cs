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
    public partial class kampusUlas : Form
    {
        public kampusUlas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resim(115);
        }
        private void resim(int hat)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\90551\OneDrive\Masaüstü\dbb\" + hat + ".png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resim(110);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resim(320);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resim(120);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resim(130);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resim(150);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resim(190);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resim(250);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resim(930);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resim(340);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resim(350);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resim(430);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resim(450);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resim(510);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string durak = comboBox1.Text;
            switch (durak)
            {
                case "bağbaşı":
                    lbl_durak.Text = "110,115,130,190";
                    break;
                case "çınar":
                    lbl_durak.Text = "130 ve 190";
                    break;
                case "servergazi":
                    lbl_durak.Text = "130";
                    break;
                case "teleferik":
                    lbl_durak.Text = "130";
                    break;
                case "otogar":
                    lbl_durak.Text = "110,120,430";
                    break;
                case "cevat akşit kyk":
                    lbl_durak.Text = "115 ve 110";
                    break;
                case "çamlık":
                    lbl_durak.Text = "115 ve 110";
                    break;
                case "bayramyeri":
                    lbl_durak.Text = "110,120,430";
                    break;
                case "üçler":
                    lbl_durak.Text = "300 ve 340";
                    break;


                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resim(930);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resim(300);
        }
    }
}
