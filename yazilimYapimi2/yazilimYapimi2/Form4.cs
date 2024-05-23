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
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-3FN5IOBA;Initial Catalog=proje1;Integrated Security=True");
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
                baglan.Open();

                // Kullanıcıya özel kelime tablosunu kontrol et
                SqlCommand tableCheckCommand = new SqlCommand($"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'kelimeler{kullaniciID}') CREATE TABLE kelimeler{kullaniciID} (ID INT PRIMARY KEY IDENTITY, EngWord NVARCHAR(100), TurWord NVARCHAR(100), OrnCumle NVARCHAR(255), OrnCumle2 NVARCHAR(255),Resim  NVARCHAR(255), BilinmeSikligi INT DEFAULT 0, SorulacakTarih DATE DEFAULT NULL)", baglan);
                tableCheckCommand.ExecuteNonQuery();

                baglan.Close();
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
                    baglan.Open();

                    // Eklenmek istenen kelimenin veritabanında olup olmadığını kontrol et
                    SqlCommand kontrolKomut = new SqlCommand($"SELECT COUNT(*) FROM kelimeler{kullaniciID} WHERE EngWord = @ingkelime", baglan);
                    kontrolKomut.Parameters.AddWithValue("@ingkelime", txtBoxIng.Text);
                    int kelimeSayisi = (int)kontrolKomut.ExecuteScalar();

                    if (kelimeSayisi > 0)
                    {
                        MessageBox.Show("Bu kelime zaten veritabanında mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Eğer kelime veritabanında yoksa, yeni kelimeyi ekleyebiliriz
                        SqlCommand komut = new SqlCommand($"INSERT INTO kelimeler{kullaniciID} (EngWord, TurWord, OrnCumle,OrnCumle2,Resim) VALUES (@ingkelime, @turkcesi, @orncumle,@orncumle2,@Resim)", baglan);
                        komut.Parameters.AddWithValue("@ingkelime", txtBoxIng.Text);
                        komut.Parameters.AddWithValue("@turkcesi", txtBoxTurk.Text);
                        komut.Parameters.AddWithValue("@orncumle", txtBoxCumle.Text);
                        komut.Parameters.AddWithValue("@orncumle2", txtBoxCumle2.Text);
                        komut.Parameters.AddWithValue("@Resim", pictureBoxResim.ImageLocation);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kelime başarıyla kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }

                    baglan.Close();
                    LoadWordData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                baglan.Open();

                // Kelimeleri, bilinme sıklıklarını ve bilinme oranlarını al
                SqlCommand komut = new SqlCommand($"SELECT EngWord, BilinmeSikligi, CAST(((CAST(BilinmeSikligi AS FLOAT) / 6)*100) AS FLOAT) AS BilinmeOrani FROM kelimeler{kullaniciID}", baglan);
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

                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }

            
            try
            {
                baglan.Open();

                // Select the required columns from the user's words table
                SqlCommand komut = new SqlCommand($"SELECT EngWord, TurWord, OrnCumle, OrnCumle2 FROM kelimeler{kullaniciID}", baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

             

                // Bind the data to the DataGridView
                dataGridView2.DataSource = dt;

                // Configure DataGridView column headers
                dataGridView2.Columns["EngWord"].HeaderText = "Kelime";
                dataGridView2.Columns["TurWord"].HeaderText = "Türkçesi";
                dataGridView2.Columns["OrnCumle"].HeaderText = "Örnek Cümle 1";
                dataGridView2.Columns["OrnCumle2"].HeaderText = "Örnek Cümle 2";
               
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
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
                // Yazı tiplerini ve düzeni ayarla
                Font headerFont = new Font("Arial", 14, FontStyle.Bold);
                Font subHeaderFont = new Font("Arial", 12, FontStyle.Regular);
                Font contentFont = new Font("Arial", 10, FontStyle.Regular);
                float yPos = e.MarginBounds.Top;
                float xPos = e.MarginBounds.Left;
                float lineHeight = contentFont.GetHeight(e.Graphics);

                // Kullanıcı bilgilerini yazdır
                e.Graphics.DrawString("KULLANICI ID: " + kullaniciID, headerFont, Brushes.Black, xPos, yPos);
                yPos +=2* lineHeight;
              
                // Başarı yüzdesini yazdır
                e.Graphics.DrawString(lblBasariYuzdesi.Text, headerFont, Brushes.Black, xPos, yPos);
                yPos += lineHeight * 2;

                // Tablo başlıklarını yazdır
                e.Graphics.DrawString("Kelime", headerFont, Brushes.Black, xPos, yPos);
                e.Graphics.DrawString("Türkçe", headerFont, Brushes.Black, xPos + 150, yPos);
                e.Graphics.DrawString("Bilinme Sıklığı", headerFont, Brushes.Black, xPos + 300, yPos);
                yPos += 2 * lineHeight;

                // Kelimeleri veritabanından çek
                List<(string EngWord, string TurWord, int BilinmeSikligi)> kelimeler = new List<(string, string, int)>();
                try
                {
                    baglan.Open();
                    SqlCommand command = new SqlCommand($"SELECT EngWord, TurWord, BilinmeSikligi FROM kelimeler{kullaniciID}", baglan);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        kelimeler.Add((reader["EngWord"].ToString(), reader["TurWord"].ToString(), Convert.ToInt32(reader["BilinmeSikligi"])));
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Kelimeleri yazdır
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










/*





// PrintPreviewDialog göster
            //  printPreviewDialog1.Document = printDocument1;
            //  if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            // {
            // Yazdırma işlemini başlat
            // printDocument1.Print();
            //  }

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }


            // PrintDialog göster
            //  if (printDialog1.ShowDialog() == DialogResult.OK)
            // {
            // Yazdırma işlemini başlat
            //   printDocument1.Print();
            // }













    //sınav ekranına gider.
    Form5 form5 = new Form5(kullaniciID, cmbBoxKelimeSayi);


    // Sınav sonucu bilgilerini al
    int dogruCevapSayisi = form5.GetDogruCevapSayisi();
    int toplamSoru = form5.GetToplamSoru();

    // Başarı oranını yazdır
    double basariYuzdesi = (double)dogruCevapSayisi / toplamSoru * 100;
    string basariOrani = "Sınav Başarı Yüzdesi: " + basariYuzdesi.ToString("0.00") + "%";
    e.Graphics.DrawString(basariOrani, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 50));

    // DataGridView başlıklarını yazdır
    int startX = 50;
    int startY = 100;
    int cellWidth = 100;
    int cellHeight = 25;
    for (int i = 0; i < dataGridView1.Columns.Count; i++)
    {
        e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Rectangle(startX + i * cellWidth, startY, cellWidth, cellHeight));
    }

    // DataGridView içeriğini yazdır
    startY += cellHeight;
    for (int i = 0; i < dataGridView1.Rows.Count; i++)
    {
        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        {
            if (dataGridView1[j, i].Value != null)
            {
                e.Graphics.DrawString(dataGridView1[j, i].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Rectangle(startX + j * cellWidth, startY + i * cellHeight, cellWidth, cellHeight));
            }
        }
    }










    // Yazdırılacak içerik burada belirlenir
    int dogruCevapSayisi = 0; // Örnek veri
    int toplamSoru = 10; // Örnek veri
    double basariYuzdesi = (double)dogruCevapSayisi / toplamSoru * 100;

    string rapor = $"Kullanıcı ID: {kullaniciID}\n" +
                   $"Toplam Soru: {toplamSoru}\n" +
                   $"Doğru Cevap Sayısı: {dogruCevapSayisi}\n" +
                   $"Başarı Yüzdesi: {basariYuzdesi.ToString("0.00")}%";

    // Yazdırma alanına yazdırılacak metni ekle
    e.Graphics.DrawString(rapor, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));













  try
    {
        baglan.Open();

        // Kelimelerin bilinme sıklığını ve yüzdesel oranını al
        SqlCommand command = new SqlCommand($"SELECT EngWord, BilinmeSikligi FROM kelimeler{kullaniciID}", baglan);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable table = new DataTable();
        adapter.Fill(table);

        // Var olan "Yüzdesel Oran" sütununu kaldır
        if (dataGridView1.Columns.Contains("YuzdeselOran"))
        {
            dataGridView1.Columns.Remove("YuzdeselOran");
        }

        // Tabloya İngilizce kelimeleri ve bilinme sıklıklarını ekle
        dataGridView1.DataSource = table;

        // Bilinme sıklığına göre yüzdesel oranı hesapla ve yeni bir sütun olarak ekle
        DataGridViewColumn column = new DataGridViewColumn();
        column.HeaderText = "Yüzdesel Oran";
        column.Name = "YuzdeselOran";
        column.CellTemplate = new DataGridViewTextBoxCell();
        dataGridView1.Columns.Add(column);

        double totalWordCount = dataGridView1.RowCount;
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            int bilinmeSikligi = Convert.ToInt32(row.Cells["BilinmeSikligi"].Value);
            double yuzdeselOran = (bilinmeSikligi / totalWordCount) * 100;
            row.Cells["YuzdeselOran"].Value = $"{yuzdeselOran:F2}%";
        }

        baglan.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }















 try
    {
        baglan.Open();

        // Kelimelerin bilinme sıklığını, sorulma sayısını ve doğru cevaplama sayısını al
        SqlCommand command = new SqlCommand($"SELECT EngWord, BilinmeSikligi, SorulmaSayisi, DogruCevaplamaSayisi FROM kelimeler{kullaniciID}", baglan);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable table = new DataTable();
        adapter.Fill(table);

        // Var olan "Yüzdesel Oran" sütununu kaldır
        if (dataGridView1.Columns.Contains("YuzdeselOran"))
        {
            dataGridView1.Columns.Remove("YuzdeselOran");
        }

        // Tabloya İngilizce kelimeleri, bilinme sıklıklarını, sorulma sayısını ve doğru cevaplama sayısını ekle
        dataGridView1.DataSource = table;

        // Bilinme sıklığına ve doğru cevaplama sayısına göre yüzdesel oranı hesapla ve yeni bir sütun olarak ekle
        DataGridViewColumn column = new DataGridViewColumn();
        column.HeaderText = "Yüzdesel Oran";
        column.Name = "YuzdeselOran";
        column.CellTemplate = new DataGridViewTextBoxCell();
        dataGridView1.Columns.Add(column);

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            int bilinmeSikligi = Convert.ToInt32(row.Cells["BilinmeSikligi"].Value);
            int sorulmaSayisi = Convert.ToInt32(row.Cells["SorulmaSayisi"].Value);
            int dogruCevaplamaSayisi = Convert.ToInt32(row.Cells["DogruCevaplamaSayisi"].Value);

            // Eğer hiç sorulmamışsa yüzdesel oranı sıfır yap
            double yuzdeselOran = sorulmaSayisi == 0 ? 0 : ((double)dogruCevaplamaSayisi / sorulmaSayisi) * 100;

            row.Cells["YuzdeselOran"].Value = $"{yuzdeselOran:F2}%";
        }

        baglan.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

*/







/*
try
{
    baglan.Open();

    // Kelimelerin bilinme sıklığını ve yüzdesel oranını al
    SqlCommand command = new SqlCommand($"SELECT EngWord, BilinmeSikligi FROM kelimeler{kullaniciID}", baglan);
    SqlDataAdapter adapter = new SqlDataAdapter(command);
    DataTable table = new DataTable();
    adapter.Fill(table);

    // Tabloya İngilizce kelimeleri ve bilinme sıklıklarını ekle
    dataGridView1.DataSource = table;

    // Bilinme sıklığına göre yüzdesel oranı hesapla ve yeni bir sütun olarak ekle
    DataGridViewColumn column = new DataGridViewColumn();
    column.HeaderText = "Yüzdesel Oran";
    column.Name = "YuzdeselOran";
    column.CellTemplate = new DataGridViewTextBoxCell();
    dataGridView1.Columns.Add(column);

    double totalWordCount = dataGridView1.RowCount;
    foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        int bilinmeSikligi = Convert.ToInt32(row.Cells["BilinmeSikligi"].Value);
        double yuzdeselOran = (bilinmeSikligi / totalWordCount) * 100;
        row.Cells["YuzdeselOran"].Value = $"{yuzdeselOran:F2}%";
    }

    baglan.Close();
}
catch (Exception ex)
{
    MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
}   */

