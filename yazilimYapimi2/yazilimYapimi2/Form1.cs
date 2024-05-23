using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimYapimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            // Hatalı giriş durumunda textbox'ları temizle
            txtBoxEmail.Clear();
            txtBoxPar.Clear();
        }
      

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //textBox tan alınan kullanıcı bilgileri sql de karşılaştırılacak
            //ona göre giriş yapılacak ya da hata mesajı verilecek 
            try
            {
                ServerBaglantisi.baglanti.Open();
                string sql = "Select * from kullanici where email=@emaill AND parola=@parolaa ";
                SqlParameter prm1 = new SqlParameter("emaill", txtBoxEmail.Text.Trim());
                SqlParameter prm2 = new SqlParameter("parolaa", txtBoxPar.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, ServerBaglantisi.baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                ServerBaglantisi.baglanti.Close();
                if (dt.Rows.Count > 0)
                {
                    // Form1'de kullanıcı girişi yapıldıktan sonra kullanıcı kimliği alınıyor
                    string kullaniciID = GetUserIdentifier(txtBoxEmail.Text.Trim(), txtBoxPar.Text.Trim()); // Kullanıcı adı ve şifre ile kimlik doğrulama

                    // Form4'e kullanıcı kimliğiyle birlikte geçiş yapılıyor
                    Form4 form4 = new Form4(kullaniciID);
                    form4.Show();
                    this.Hide(); // Form1'i gizleme

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Temizle();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş!");

            }

        }

    

    private void btnKayit_Click(object sender, EventArgs e)
        {
            //kayıt ol formuna gidiyor.(form2)

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {

            // Şifremi unuttum formuna gidiyor.(form3)

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private string GetUserIdentifier(string email, string parola)
        {
            string kullaniciID = "";
            try
            {
                ServerBaglantisi.baglanti.Open();
                string sql = "SELECT kullaniciID FROM kullanici WHERE email=@emaill AND parola=@parolaa";
                SqlCommand komut = new SqlCommand(sql, ServerBaglantisi.baglanti);
                komut.Parameters.AddWithValue("@emaill", email);
                komut.Parameters.AddWithValue("@parolaa", parola);
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    kullaniciID = reader["kullaniciID"].ToString();
                }
                reader.Close();
                ServerBaglantisi.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return kullaniciID;
        }

    }
}

  