using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static proje.Giris;
namespace proje
{
    public partial class yemekhane_yon : Form
    {
        public yemekhane_yon()
        {
            InitializeComponent();
            musteri(1, 1);
            musteri(0, 0);
        }
        private void musteri(int day,int i)
        {
            string query = "SELECT yer,ogrenci_id,saat FROM rezervasyon WHERE tarih = @tarih";
            MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
            DateTime x = DateTime.Now.AddDays(day).Date;
            cmd.Parameters.AddWithValue("@tarih", x);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView2.DataSource = dt;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn.Open();
            string query = "INSERT INTO yemek_listesi (tarih,yemek1,yemek2,yemek3,yemek4,saati) VALUES(@tarih,@y1,@y2,@y3,@y4,@saat)";
            MySqlCommand command = new MySqlCommand(query, GlobalDatabase.Conn);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@y1", textBox1.Text);
            command.Parameters.AddWithValue("@y2", textBox2.Text);
            command.Parameters.AddWithValue("@y3", textBox3.Text);
            command.Parameters.AddWithValue("@y4", textBox4.Text);
            command.Parameters.AddWithValue("@saat", comboBox1.Text);

            command.ExecuteNonQuery();
            GlobalDatabase.Conn.Close();
            MessageBox.Show("başarı ile yemek listesi eklenmiştir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri(Convert.ToInt32(maskedTextBox1.Text),0);
        }
    }
}
