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

        public Form4(string kullaniciID)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.cmbBoxKelimeSayi.SelectedIndex = 0;
            CreateKelimelerTable();
        }

        private void CreateKelimelerTable()
        {
            try
            {
                baglan.Open();

                // Kullanıcıya özel kelime tablosunu kontrol et
                SqlCommand tableCheckCommand = new SqlCommand($"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'kelimeler{kullaniciID}') CREATE TABLE kelimeler{kullaniciID} (ID INT PRIMARY KEY IDENTITY, EngWord NVARCHAR(100), TurWord NVARCHAR(100), OrnCumle NVARCHAR(255), OrnCumle2 NVARCHAR(255), BilinmeSikligi INT DEFAULT 0, SorulacakTarih DATE DEFAULT NULL)", baglan);
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
                        SqlCommand komut = new SqlCommand($"INSERT INTO kelimeler{kullaniciID} (EngWord, TurWord, OrnCumle,OrnCumle2) VALUES (@ingkelime, @turkcesi, @orncumle,@orncumle2)", baglan);
                        komut.Parameters.AddWithValue("@ingkelime", txtBoxIng.Text);
                        komut.Parameters.AddWithValue("@turkcesi", txtBoxTurk.Text);
                        komut.Parameters.AddWithValue("@orncumle", txtBoxCumle.Text);
                        komut.Parameters.AddWithValue("@orncumle2", txtBoxCumle2.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kelime başarıyla kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }

                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {
          
            //sınav ekranına gider.
            Form5 form5 = new Form5(kullaniciID,cmbBoxKelimeSayi);
            form5.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Zaten açık olan Form1'i al
            form1.Show();   // Form1'i göster

            this.Close();

        }

        private void tbPageSinav_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxKelimeSayi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
