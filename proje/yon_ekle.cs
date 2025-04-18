using MySql.Data.MySqlClient;
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
    public partial class yon_ekle : Form
    {
        public yon_ekle()
        {
            InitializeComponent();
            listele();
        }
        private void listele()
        {
            checkedListBox1.Items.Clear();

            string query = "SELECT id, isim, soy_isim FROM yonetici_bilgi";

            try
            {
                GlobalDatabase.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 1;
                while (reader.Read())
                {
                    string fullName = i+"-"+$"{reader["isim"]} {reader["soy_isim"]}";
                    i++;
                    int id = Convert.ToInt32(reader["id"]);

                    checkedListBox1.Items.Add(new ListItem(fullName, id));
                }

                reader.Close();
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into yonetici_bilgi(Tc,isim,soy_isim,pozisyon,yetki,email,sifre)VALUES(@tc,@isim,@soy_isim,@pozisyon,@yetki,@email,@sifre)";
            GlobalDatabase.Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sorgu, GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@tc", tc_textbox.Text);
            cmd.Parameters.AddWithValue("@isim", isim_textbox.Text);
            cmd.Parameters.AddWithValue("@soy_isim", soy_isimtextbox.Text);
            cmd.Parameters.AddWithValue("@pozisyon", comboBox1.Text);
            cmd.Parameters.AddWithValue("@yetki", comboBox2.Text);
            cmd.Parameters.AddWithValue("@email", email_textbox.Text);
            cmd.Parameters.AddWithValue("@sifre",sifre_textbox.Text);
            cmd.ExecuteNonQuery();
            GlobalDatabase.Conn.Close() ;
            MessageBox.Show("başarı ile kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kişileri seçin.");
                return;
            }

            GlobalDatabase.Conn.Open();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                // item: "Ali Yılmaz - 5"
                string satir = item.ToString();
                string[] parcalar = satir.Split('-');

                if (parcalar.Length == 2)
                {
                    int id = Convert.ToInt32(parcalar[0].Trim());

                    string deleteQuery = "DELETE FROM yonetici_bilgi WHERE id = @id";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, GlobalDatabase.Conn);
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    deleteCmd.ExecuteNonQuery();
                }
            }

            GlobalDatabase.Conn.Close();
            MessageBox.Show("Seçilen kişiler silindi.");
            listele();
        }
        public class ListItem
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public ListItem(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

    }
}
