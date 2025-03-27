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
    public partial class Obs : Form
    {
        public List<string> secilen = new List<string>();

        public string[] dersIsletme = { "İşletme", "Maliye", "Pazarlama", "Ekonomi", "Exel", "Tarih", "İngilizce", "Matematik" };
        public string[] dersYbs = { "İşletme", "Maliye", "Pazarlama", "Hukuk", "Programlama", "Tarih", "İngilizce", "Matematik" };
        public string[] dersBilgisayar = { "İşletme", "Mühendisliğe giriş", "Kimya", "Fizik", "Programlama", "Tarih", "İngilizce", "Matematik" };

        
        public Obs()
        {
            InitializeComponent();
        }

        private void btn_onay_Click(object sender, EventArgs e)
        {
            secilen.Clear();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                secilen.Add(item.ToString());
            }
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İşletme");
            comboBox1.Items.Add("Yönetim bilişim sistemleri");
            comboBox1.Items.Add("Bilgisayar Mühendisliği");

            checkedListBox1.Items.Clear();

            switch (comboBox1.Text)
            {
                case "İşletme":
                    checkedListBox1.Items.AddRange(dersIsletme);
                    break;

                case "Yönetim bilişim sistemleri":
                    checkedListBox1.Items.AddRange(dersYbs);
                    break;

                case "Bilgisayar Mühendisliği":
                    checkedListBox1.Items.AddRange(dersBilgisayar);
                    break;

                default:
                    MessageBox.Show("Lütfen geçerli bir bölüm seçiniz.");
                    break;
            }
        }
    }
}
