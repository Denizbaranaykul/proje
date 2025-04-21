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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalDatabase.Conn.Open();
            string query = "INSERT INTO yemek_listesi (tarih,yemek1,yemek2,yemek3,yemek4,saati) VALUES(@tarih,@y1,@y2,@y3,@y4,@saat)";
            MySqlCommand command = new MySqlCommand(query);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@y1", textBox1.Text);
            command.Parameters.AddWithValue("@y2", textBox2.Text);
            command.Parameters.AddWithValue("@y3", textBox2.Text);
            command.Parameters.AddWithValue("@y4", textBox2.Text);
            command.Parameters.AddWithValue("@saat", comboBox1.Text);

            command.ExecuteNonQuery();
            GlobalDatabase.Conn.Close();
            MessageBox.Show("başarı ile yemek listesi eklenmiştir");
        }
    }
}
