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
    public partial class egitim_destek_ogrnci : Form
    {
        public egitim_destek_ogrnci()
        {
            InitializeComponent();
            string query = "SELECT id,adi,baslik,hafta FROM eds";
            ListeleMakalelerVeEds(query);
        }
        public void ListeleMakalelerVeEds(string query)
        {
            try
            {
                GlobalDatabase.Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, GlobalDatabase.Conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                GlobalDatabase.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }
        

       
          

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                try
                {
                    GlobalDatabase.Conn.Open();
                    string query = "SELECT baslik, pdf FROM eds WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, GlobalDatabase.Conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] pdfBytes = (byte[])reader["pdf"];
                        string baslik = reader["baslik"].ToString();

                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
                        sfd.FileName = baslik + ".pdf";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(sfd.FileName, pdfBytes);
                            MessageBox.Show("PDF başarıyla indirildi.");
                        }
                    }

                    reader.Close();
                    GlobalDatabase.Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF indirme hatası: " + ex.Message);
                }
            }
        }
    
    }
}
