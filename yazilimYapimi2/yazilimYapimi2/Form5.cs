using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazilimYapimi2
{
    public partial class Form5 : Form
    {
        private Random random = new Random();
        private SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-3FN5IOBA;Initial Catalog=proje1;Integrated Security=True"); // Veritabanı bağlantı dizesi buraya gelecek
        Kelimeler kelimeler = new Kelimeler();
        Rule6 rule6 = new Rule6();
        string kullaniciID;
        System.Windows.Forms.ComboBox comboBox;



        private int dogruCevapSayisi = 0;
        private int toplamSoru = 0;


        public int GetDogruCevapSayisi()
        {
            return dogruCevapSayisi;
        }

        public int GetToplamSoru()
        {
            return toplamSoru;
        }




            public Form5(string kullaniciID, System.Windows.Forms.ComboBox comboBox)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;//Hangi kullanıcjnın girdiğini bilmek için.
            this.comboBox = comboBox;//form4 ten comboboxu al
      
        }

        private string GetTurkishEquivalent(string ingilizceKelime)
        {
            string turkceKarsilik = "";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand($"SELECT TurWord  FROM kelimeler{kullaniciID} WHERE EngWord = @ingilizceKelime", baglanti);
                komut.Parameters.AddWithValue("@ingilizceKelime", ingilizceKelime);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    turkceKarsilik = reader["TurWord"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından kelime alınırken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            return turkceKarsilik;
        }

        private void SoruOlustur()
        {
            if (kelimeler.ingilizceKelimeler.Count <= 4)
            {
                MessageBox.Show("Veritabanında soru üretmek için yeterli kelime yok!");
                return;
            }
            //
            string secilenKelime = kelimeler.secilenkelime;

            // Soruyu TextBox'a göster
            lblSoru.Text = "What is the Turkish equivalent of the word '" + secilenKelime + "'?";

            // Doğru cevabı belirle
            string dogruCevap = GetTurkishEquivalent(secilenKelime);

            // Yanlış cevapları belirle
            List<string> yanlisCevaplar = new List<string>();

            // Rastgele üç yanlış cevap seçme
            while (yanlisCevaplar.Count < 3)
            {
                string yanlisCevap = GetRandomWrongAnswer();
                if (yanlisCevap != dogruCevap && !yanlisCevaplar.Contains(yanlisCevap)) //yanlış cevap doğru cevaba eşit değilse ve seçilen ing kelime zaten listeye eklenmemişse
                    yanlisCevaplar.Add(yanlisCevap);
            }

            // Doğru ve yanlış cevapları butonlara karışık bir şekilde ayarla
            List<string> cevaplar = new List<string> { dogruCevap };
            cevaplar.AddRange(yanlisCevaplar);
            cevaplar = cevaplar.OrderBy(x => random.Next()).ToList();

            btnA.Text = cevaplar[0];
            btnB.Text = cevaplar[1];
            btnC.Text = cevaplar[2];
            btnD.Text = cevaplar[3];
        }

        private string GetRandomWrongAnswer()
        {
            // Rastgele bir İngilizce kelime seç
            string secilenKelime = kelimeler.ingilizceKelimeler[random.Next(kelimeler.ingilizceKelimeler.Count)];

            // İngilizce kelimenin Türkçe karşılığını döndür
            return GetTurkishEquivalent(secilenKelime);
        }

        private bool CheckAnswer(string selectedAnswer)
        {
            // Retrieve the correct Turkish equivalent for the displayed English word
            string correctTurkishEquivalent = GetTurkishEquivalent(kelimeler.secilenkelime);

            // Check if the selected answer matches the correct Turkish equivalent
            return selectedAnswer == correctTurkishEquivalent;
        }

        private void SetButtonEnabled(bool enabled)
        {
            btnA.Enabled = enabled;
            btnB.Enabled = enabled;
            btnC.Enabled = enabled;
            btnD.Enabled = enabled;
        }




        private void Form5_Load(object sender, EventArgs e)
        {
            lblSoru.Text= "";
           
        }



        
        private void btnSinavKapat_Click_1(object sender, EventArgs e)
        { 
            this.Close(); // Form5'i kapat(sınav ekranını kapatır.)
        }



     


        private void btnA_Click(object sender, EventArgs e)
        {


            toplamSoru++;
            // Check if the answer is correct when button 1 is clicked
            bool isCorrect = CheckAnswer(btnA.Text);

            // Display feedback to the user based on correctness
            if (isCorrect)
            {
                dogruCevapSayisi++;
                rule6._Rule6(baglanti, kelimeler, kullaniciID,true);//truefalse ifadeleri iscorrect ile değiştirilebilir
                MessageBox.Show("Correct answer!");
                // You can perform additional actions here for correct answers
            }
            else
            {
              
                rule6._Rule6(baglanti, kelimeler, kullaniciID, false);
                MessageBox.Show("Wrong answer. Try again!");
                // You can perform additional actions here for wrong answers
            }


            // Tüm butonların tıklanabilirliğini tekrar false yap
            SetButtonEnabled(false);

            // Sonraki butonu tıklanabilir hale getir
            btnA.Enabled = true;

        }

        private void btnB_Click(object sender, EventArgs e)
        {

            toplamSoru++;
            bool isCorrect = CheckAnswer(btnB.Text);

            if (isCorrect)
            {
                dogruCevapSayisi++;
                rule6._Rule6(baglanti, kelimeler, kullaniciID,true);
                MessageBox.Show("Correct answer!");
            }
            else
            {
               
                rule6._Rule6(baglanti, kelimeler, kullaniciID, false);
                MessageBox.Show("Wrong answer. Try again!");
            }

            SetButtonEnabled(false);

            btnB.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            toplamSoru++;
          
            bool isCorrect = CheckAnswer(btnC.Text);

            if (isCorrect)
            {
                dogruCevapSayisi++;
                rule6._Rule6(baglanti, kelimeler, kullaniciID, true);
                MessageBox.Show("Correct answer!");
            }
            else
            {
              
                rule6._Rule6(baglanti, kelimeler, kullaniciID, false);
                MessageBox.Show("Wrong answer. Try again!");
            }

            SetButtonEnabled(false);

            btnC.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            toplamSoru++;
           
            bool isCorrect = CheckAnswer(btnD.Text);

            if (isCorrect)
            {
                dogruCevapSayisi++;
                rule6._Rule6(baglanti, kelimeler, kullaniciID, true);
                MessageBox.Show("Correct answer!");
            }
            else
            {
               
                rule6._Rule6(baglanti, kelimeler, kullaniciID, false);
                MessageBox.Show("Wrong answer. Try again!");
            }
         
            SetButtonEnabled(false);

            btnD.Enabled = true;
        }






        int sayac = 0;
        private void btnSonraki_Click(object sender, EventArgs e) //kelime kalmadığında durduracak fonksiyon bulunacak.
        {
            sayac++;
            label5.Text = sayac.ToString();
            btnSonraki.Text = "SONRAKİ";
            kelimeler.KelimeleriGetir(kullaniciID); // Veritabanından kelimeleri al

            if (kelimeler.secilenIngilizceKelimeler.Count > 1)//buna farklı bir yol bul 1 kelime kalıyor yoksa
            {
                SoruOlustur(); // İlk soruyu oluştur

                // Tüm butonları tıklanabilir hale getir
                SetButtonEnabled(true);

                if (comboBox.Items[comboBox.SelectedIndex].ToString().Equals("Default"))
                {
                    //does nothing
                }
                else
                {
                    string selectedItem = comboBox.Items[comboBox.SelectedIndex].ToString();
                    int sorusayisi = Int32.Parse(selectedItem);
                    if (sayac == (sorusayisi + 1))
                    {
                        btnSonraki.Enabled = false;
                        SetButtonEnabled(false);
                        MessageBox.Show("Sınavınız bitmiştir.", "Son", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                btnSonraki.Enabled = false;
                SetButtonEnabled(false);
                MessageBox.Show("Sınavınız bitmiştir.", "Son", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
       

    }
}



