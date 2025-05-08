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
using MySql.Data.MySqlClient;
namespace proje
{
    public partial class akademik_kadro : Form
    {
        public akademik_kadro()
        {
            InitializeComponent();
            listele();
        }
        private void listele()
        {
            string query = "SELECT isim,soy_isim,pozisyon FROM yonetici_bilgi WHERE yetki=5";
            MySqlDataAdapter da = new MySqlDataAdapter(query, GlobalDatabase.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btn_ara_Click(object sender, EventArgs e)
        {
            string aranan_kelime=textBox1.Text.Trim();
            if (string.IsNullOrEmpty(aranan_kelime))
            {
                listele();  
            }
            else
            {
                string queryNormal = "SELECT isim, soy_isim, pozisyon FROM yonetici_bilgi WHERE yetki=5 AND (isim LIKE @title OR soy_isim LIKE @title)";
                MySqlDataAdapter daNormal = new MySqlDataAdapter(queryNormal, GlobalDatabase.Conn);
                daNormal.SelectCommand.Parameters.AddWithValue("@title", "%" + aranan_kelime + "%");
                DataTable dtNormal = new DataTable();
                daNormal.Fill(dtNormal);
                dataGridView1.DataSource = dtNormal;
            }

        }
    }
}
