using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje
{
    public partial class cv_oluştur : Form
    {
        public cv_oluştur()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); 
        }
        private void btnfoto_yükle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void Btncv_kaydet(object sender, EventArgs e)
        {
            try
            {
                // Kaydetme diyaloğu
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "CV'yi Kaydet";
                saveFileDialog.FileName = "cv.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return; 
                }

                string pdfPath = saveFileDialog.FileName;

                if (string.IsNullOrEmpty(pdfPath) || !Directory.Exists(Path.GetDirectoryName(pdfPath)))
                {
                    MessageBox.Show("Geçersiz dosya yolu.");
                    return;
                }
              
                Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(panelBitmap, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));

                using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 0, 0, 0, 0);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        panelBitmap.Save(ms, ImageFormat.Png);
                        ms.Position = 0;
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms);
                        img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                        img.SetAbsolutePosition(0, 0);
                        doc.Add(img);
                    }

                    doc.Close();
                }

                MessageBox.Show("CV başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
