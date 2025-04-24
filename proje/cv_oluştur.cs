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



using System;




namespace proje
{
    public partial class cv_oluştur : Form
    {
        public cv_oluştur()
        {
            InitializeComponent();
        }

        // Fotoğraf yükle butonunun tıklama olayı
        private void btnfoto_yükle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Fotoğrafı PictureBox'a yerleştir
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // PDF kaydet butonunun tıklama olayı
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan bilgiler
                string adSoyad = txt_ad.Text;
                string telefon = txt_tel.Text;
                string email = txte_posta.Text;
                string adres = txt_adres.Text;

                // PDF kaydetme işlemi
                string pdfPath = "C:\\cv.pdf";  // PDF'in kaydedileceği yol, bu yolu kendi sistemine göre düzenleyebilirsin.

                // Yolun geçerli olduğundan emin olun
                if (string.IsNullOrEmpty(pdfPath) || !Directory.Exists(Path.GetDirectoryName(pdfPath)))
                {
                    MessageBox.Show("Geçersiz dosya yolu.");
                    return;
                }

                // PDF yazıcı ve döküman oluşturuluyor
                using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Arka plan görselini ekle
                    string imgPath = "C:\\cv_sablon.png";  // Arka plan görseli yolu
                    if (File.Exists(imgPath))
                    {
                        // iTextSharp Image kullanımı
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imgPath);
                        img.SetAbsolutePosition(0, 0);  // Arka planın konumu
                        img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);  // Arka planın sayfaya uymasını sağla
                        doc.Add(img);
                    }

                    // Font kullanımında iTextSharp Font sınıfı kullanılmalı
                    iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);

                    // PdfContentByte ile yazı ekle
                    PdfContentByte cb = writer.DirectContent;
                    cb.SetFontAndSize(font.BaseFont, 12);
                    cb.BeginText();
                    cb.ShowTextAligned(Element.ALIGN_LEFT, "Ad Soyad: " + adSoyad, 100, 500, 0);
                    cb.ShowTextAligned(Element.ALIGN_LEFT, "Telefon: " + telefon, 100, 480, 0);
                    cb.ShowTextAligned(Element.ALIGN_LEFT, "Email: " + email, 100, 460, 0);
                    cb.ShowTextAligned(Element.ALIGN_LEFT, "Adres: " + adres, 100, 440, 0);
                    cb.EndText();

                    // Fotoğrafı belirli bir pozisyonda ekle
                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            ms.Seek(0, SeekOrigin.Begin);
                            // Fotoğraf ekleme
                            iTextSharp.text.Image photo = iTextSharp.text.Image.GetInstance(ms);
                            photo.SetAbsolutePosition(100, 300);  // Fotoğrafın pozisyonu
                            photo.ScaleToFit(100, 100);  // Fotoğrafın boyutu
                            doc.Add(photo);
                        }
                    }

                    // PDF'i kaydet
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