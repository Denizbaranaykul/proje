
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
    public partial class yemekhane_ve_menü : Form
    {
        public yemekhane_ve_menü()
        {
            InitializeComponent();
            
        }

        // Form yüklenince timer başlasın
        private void yemekhane_ve_menü_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniyede bir tetiklenir
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        // Timer her tetiklendiğinde (her saniye) saati günceller
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;
            MessageBox.Show("Seçilen tarih: " + secilenTarih.ToShortDateString());
        }
        private void dateTimePicker1_ValueChangedd(object sender, EventArgs e)
        {
            lbl_tarih.Text = dateTimePicker1.Value.ToString("dd MMM yyyy");
        }

        private void yemekhane_ve_menü_Load_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            // DateTimePicker ayarı
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
        }
    }
}
