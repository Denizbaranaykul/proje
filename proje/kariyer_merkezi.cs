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
    public partial class kariyer_merkezi : Form
    {
        public kariyer_merkezi()
        {
            InitializeComponent();
        }

        private void kariyer_merkezi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cv_oluştur cv = new cv_oluştur();
            cv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
