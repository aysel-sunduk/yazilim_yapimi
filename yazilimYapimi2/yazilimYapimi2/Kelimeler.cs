using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimYapimi2
{
    public class Kelimeler
    {
        public string secilenkelime = "";
        public List<string> ingilizceKelimeler = new List<string>();
        public List<string> secilenIngilizceKelimeler = new List<string>(); // Kullanıcının girdiği İngilizce kelimelerin listesi
        private Random random = new Random();
       

        public void KelimeleriGetir(string kullaniciID)
        {
            try
            {
                secilenIngilizceKelimeler.Clear();//aynı kelimeler listenin içinde kalmasın diye
                ingilizceKelimeler.Clear();

                ServerBaglantisi.baglanti.Open();
                DateTime today = DateTime.Now.Date;

                // Tüm ingilizce kelimeleri çekmek için olan komut.
                SqlCommand komutkelime = new SqlCommand($"SELECT EngWord FROM kelimeler{kullaniciID}", ServerBaglantisi.baglanti);
                SqlDataReader readerkelime = komutkelime.ExecuteReader();

                while (readerkelime.Read())
                {
                    ingilizceKelimeler.Add(readerkelime["EngWord"].ToString());
                }

                readerkelime.Close();

                // Sorulacak ingilizce kelimeleri çekmek için olan komut.
                SqlCommand secilenkomut = new SqlCommand($"SELECT EngWord FROM kelimeler{kullaniciID} WHERE SorulacakTarih IS NULL OR SorulacakTarih <= @Today", ServerBaglantisi.baglanti);
                secilenkomut.Parameters.AddWithValue("@Today", today);
                SqlDataReader secilenreader = secilenkomut.ExecuteReader();

                while (secilenreader.Read())
                {
                    secilenIngilizceKelimeler.Add(secilenreader["EngWord"].ToString());
                }

                secilenreader.Close();


                GenerateSecilenKelime();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından kelimeleri alma hatası: " + ex.Message);
            }
            finally
            {
                ServerBaglantisi.baglanti.Close();
            }
        }

        private void GenerateSecilenKelime()
        {
            //Rastgele bir ingilizce kelime seç.
            this.secilenkelime = secilenIngilizceKelimeler[random.Next(secilenIngilizceKelimeler.Count)];
            Console.WriteLine(this.secilenkelime);//kontrol

        }

    }

}
