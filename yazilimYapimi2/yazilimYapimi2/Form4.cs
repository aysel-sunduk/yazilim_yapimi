using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimi2
{
    public partial class Form4 : Form
    {
        string kullaniciID;


        private void Form4_Load(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            KullaniciBilgileriniGetir();

        }


        public Form4(string kullaniciID)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.cmbBoxKelimeSayi.SelectedIndex = 0;
            CreateKelimelerTable();
            LoadWordData();
        }


        private void CreateKelimelerTable()
        {
            try
            {
                ServerBaglantisi.baglanti.Open();

                // Kullanıcıya özel kelime tablosunu kontrol et
                SqlCommand tableCheckCommand = new SqlCommand($"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'kelimeler{kullaniciID}') CREATE TABLE kelimeler{kullaniciID} (ID INT PRIMARY KEY IDENTITY, EngWord NVARCHAR(100), TurWord NVARCHAR(100), OrnCumle NVARCHAR(255), OrnCumle2 NVARCHAR(255),Resim  NVARCHAR(255), BilinmeSikligi INT DEFAULT 0, SorulacakTarih DATE DEFAULT NULL)", ServerBaglantisi.baglanti);
                tableCheckCommand.ExecuteNonQuery();
                ServerBaglantisi.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtBoxIng.Clear();
            txtBoxTurk.Clear();
            txtBoxCumle.Clear();
            txtBoxCumle2.Clear();
            pictureBoxResim.Image = null;
        }

        private void tbPageKelimeEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnKelimeKayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxIng.Text) || string.IsNullOrWhiteSpace(txtBoxTurk.Text) || string.IsNullOrWhiteSpace(txtBoxCumle.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ServerBaglantisi.baglanti.Open();

                    // Eklenmek istenen kelimenin veritabanında olup olmadığını kontrol et
                    SqlCommand kontrolKomut = new SqlCommand($"SELECT COUNT(*) FROM kelimeler{kullaniciID} WHERE EngWord = @ingkelime", ServerBaglantisi.baglanti);
                    kontrolKomut.Parameters.AddWithValue("@ingkelime", txtBoxIng.Text);
                    int kelimeSayisi = (int)kontrolKomut.ExecuteScalar();

                    if (kelimeSayisi > 0)
                    {
                        MessageBox.Show("Bu kelime zaten veritabanında mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Eğer kelime veritabanında yoksa, yeni kelimeyi ekleyebiliriz
                        SqlCommand komut = new SqlCommand($"INSERT INTO kelimeler{kullaniciID} (EngWord, TurWord, OrnCumle,OrnCumle2,Resim) VALUES (@ingkelime, @turkcesi, @orncumle,@orncumle2,@Resim)", ServerBaglantisi.baglanti);
                        komut.Parameters.AddWithValue("@ingkelime", txtBoxIng.Text);
                        komut.Parameters.AddWithValue("@turkcesi", txtBoxTurk.Text);
                        komut.Parameters.AddWithValue("@orncumle", txtBoxCumle.Text);
                        komut.Parameters.AddWithValue("@orncumle2", txtBoxCumle2.Text);
                        komut.Parameters.AddWithValue("@Resim", pictureBoxResim.ImageLocation);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kelime başarıyla kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }


                    LoadWordData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ServerBaglantisi.baglanti.Close();

                }

            }

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResim.ImageLocation = openFileDialog.FileName;
            }


        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {

            //sınav ekranına gider.
            Form5 form5 = new Form5(kullaniciID, cmbBoxKelimeSayi);
            form5.ShowDialog();
            LoadWordData();


            // Sınav sonucu bilgilerini al
            int dogruCevapSayisi = form5.GetDogruCevapSayisi();
            int toplamSoru = form5.GetToplamSoru();
            if (toplamSoru > 0)
            {
                double basariYuzdesi = (double)dogruCevapSayisi / toplamSoru * 100;
                lblBasariYuzdesi.Text = "Sınav Başarı Yüzdesi: " + basariYuzdesi.ToString("0.00") + "%";
                prBarBasariYuzde.Value = (int)Math.Round(basariYuzdesi);
            }


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Zaten açık olan Form1'i al
            form1.Show();   // Form1'i göster

            this.Close();

        }


        private void cmbBoxKelimeSayi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadWordData()
        {
            try
            {


                // Kelimeleri, bilinme sıklıklarını ve bilinme oranlarını al
                SqlCommand komut = new SqlCommand($"SELECT EngWord, BilinmeSikligi, CAST(((CAST(BilinmeSikligi AS FLOAT) / 6)*100) AS FLOAT) AS BilinmeOrani FROM kelimeler{kullaniciID}", ServerBaglantisi.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);



                // Bilinme Oranı sütununu formatla
                foreach (DataRow row in dt.Rows)
                {
                    double bilinmeOrani = Convert.ToDouble(row["BilinmeOrani"]);
                    row["BilinmeOrani"] = bilinmeOrani.ToString("0.00");
                }




                // Veriyi DataGridView'e bağla
                dataGridView1.DataSource = dt;

                // DataGridView sütun başlıklarını düzenle
                dataGridView1.Columns["EngWord"].HeaderText = "Kelime";
                dataGridView1.Columns["BilinmeSikligi"].HeaderText = "Bilinme Sıklığı";
                dataGridView1.Columns["BilinmeOrani"].HeaderText = "Bilinme Oranı (%)";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                ServerBaglantisi.baglanti.Close();
            }

            try
            {
                ServerBaglantisi.baglanti.Open();

                // Kullanıcı kelime tablosundan gerekli olan sutunları seçer.
                SqlCommand komut = new SqlCommand($"SELECT EngWord, TurWord, OrnCumle, OrnCumle2 FROM kelimeler{kullaniciID}", ServerBaglantisi.baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);



                // DataGridView e veriyi eşitler.
                dataGridView2.DataSource = dt;

                //DataGridView deki sutun başlıklarını belirler.
                dataGridView2.Columns["EngWord"].HeaderText = "Kelime";
                dataGridView2.Columns["TurWord"].HeaderText = "Türkçesi";
                dataGridView2.Columns["OrnCumle"].HeaderText = "Örnek Cümle 1";
                dataGridView2.Columns["OrnCumle2"].HeaderText = "Örnek Cümle 2";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                ServerBaglantisi.baglanti.Close();
            }
        }


        private void KullaniciBilgileriniGetir()
        {

        }

        private void prBarBasariYuzde_Click(object sender, EventArgs e)
        {
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void lblBasariYuzdesi_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Yazı tiplerini ve düzeni ayarlar
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Regular);
            Font contentFont = new Font("Arial", 10, FontStyle.Regular);
            float yPos = e.MarginBounds.Top;
            float xPos = e.MarginBounds.Left;
            float lineHeight = contentFont.GetHeight(e.Graphics);

            // Kullanıcı bilgilerini yazdırır
            e.Graphics.DrawString("KULLANICI ID: " + kullaniciID, headerFont, Brushes.Black, xPos, yPos);
            yPos += 2 * lineHeight;

            // Başarı yüzdesini yazdırır
            e.Graphics.DrawString(lblBasariYuzdesi.Text, headerFont, Brushes.Black, xPos, yPos);
            yPos += lineHeight * 2;

            // Tablo başlıklarını yazdırır
            e.Graphics.DrawString("Kelime", headerFont, Brushes.Black, xPos, yPos);
            e.Graphics.DrawString("Türkçe", headerFont, Brushes.Black, xPos + 150, yPos);
            e.Graphics.DrawString("Bilinme Sıklığı", headerFont, Brushes.Black, xPos + 300, yPos);
            yPos += 2 * lineHeight;

            // Kelimeleri veritabanından çeker
            List<(string EngWord, string TurWord, int BilinmeSikligi)> kelimeler = new List<(string, string, int)>();
            try
            {
                ServerBaglantisi.baglanti.Open();
                SqlCommand command = new SqlCommand($"SELECT EngWord, TurWord, BilinmeSikligi FROM kelimeler{kullaniciID}", ServerBaglantisi.baglanti);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kelimeler.Add((reader["EngWord"].ToString(), reader["TurWord"].ToString(), Convert.ToInt32(reader["BilinmeSikligi"])));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ServerBaglantisi.baglanti.Close();

            }
            // Kelimeleri yazdırır
            foreach (var kelime in kelimeler)
            {
                e.Graphics.DrawString(kelime.EngWord, contentFont, Brushes.Black, xPos, yPos);
                e.Graphics.DrawString(kelime.TurWord, contentFont, Brushes.Black, xPos + 150, yPos);
                e.Graphics.DrawString(kelime.BilinmeSikligi.ToString(), contentFont, Brushes.Black, xPos + 300, yPos);
                yPos += lineHeight;
            }
        }
    }
}