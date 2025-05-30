using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
namespace proje
{

    public partial class Giris : Form
    {
        public static Ana_sayfa anaSayfaForm;
        public static yonetici yon;
        public static Giris girisFormu;
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pa�_app;Uid=root;Pwd=D3n!Z-25/11/2004?");
        public MySqlCommand cmd;    
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public static int taban = 0;
        public static int mesaj=0;
        public Giris()
        {

            InitializeComponent();
            girisFormu = this;

        }

        public static class GlobalDatabase
        {
            // Global olarak eri�ilebilen veritaban� bile�enleri
            public static MySqlConnection Conn { get; set; }
            public static MySqlCommand Cmd { get; set; }
            public static MySqlDataAdapter Adapter { get; set; }
            public static DataTable Dt { get; set; }
        }
        private void girmek(string sql)
        {
            try
            {
                conn.Open();

                // SQL sorgusu: ogrenci_bilgi tablosundan veya yonetici_bilgi tablosundan girilen T.C ve sifre de�erlerine sahip kayd� bul.

                cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@tc", Convert.ToInt64(maskedTextBox1.Text));
                cmd.Parameters.AddWithValue("@sifre", maskedTextBox2.Text);

                // DataAdapter ile sorgu sonucunu DataTable i�ine dolduruyoruz.
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    // S�tun adlar�n� kullanarak eri�im:
                    int id = Convert.ToInt32(row["id"]);
                    long tc = Convert.ToInt64(row["Tc"]);
                    string isim = row["isim"].ToString();
                    string soyIsim = row["soy_isim"].ToString();
                    // s�tunlara eri�me



                }

                //coutnlar0 dan b�y�kse b�yle bir kullan�c� bulunmu� olur tc zaten uniqe 
                //��renci giri�i
                if (dt.Rows.Count > 0 && sql == "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre")
                {
                    // giri� yap�yoz
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;



                    if (anaSayfaForm == null || anaSayfaForm.IsDisposed)
                    {
                        anaSayfaForm = new Ana_sayfa();
                    }
                    mesaj = 1;
                    anaSayfaForm.Show();
                    this.Hide();

                }
                //y�netici bilgi sistemine giri�
                else if (dt.Rows.Count > 0 && sql == "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre")
                {
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;

                    yonetici yonetici = new yonetici();
                    mesaj = 2;
                    this.Hide();
                    yonetici.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre yanl��");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();//sql sorgusunu kapat�yoz
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//��renci giri�i tikliyse �al��s�n
            {
                if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrEmpty(maskedTextBox2.Text))//textboxlar bo� veya null de�ilse �al��s�n
                {
                    string sql = "SELECT * FROM ogrenci_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";//��renci bilgi i�in sorgu komutu
                    girmek(sql);
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre bo�");
                }
            }
            else if (radioButton2.Checked) //y�netici giri�i tikliyse �al��s�n
            {
                string sql2 = "SELECT * FROM yonetici_bilgi WHERE `Tc` = @Tc AND sifre = @sifre";// y�netici bilgi i�in sorgu komutu
                girmek(sql2);
            }
            else
            {
                MessageBox.Show("Giri� tipini se�memi�siniz");
            }

        }

        //veritaban� ba�lant�s� sa�lanamad���nda girmek i�in
        private void button2_Click(object sender, EventArgs e)
        {
            taban = 10;
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            this.Hide();
            ana_Sayfa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kay�t_alma kay�t = new kay�t_alma();
            kay�t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            taban = 10;
            yonetici yon= new yonetici();
            this.Hide();
            yon.Show();
        }
    }

}
