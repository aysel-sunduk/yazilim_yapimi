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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace yazilimYapimi2
{
    public partial class Form2 : Form
    {

        //sql connection sağlanır.(Data Source ve Initial Catalog değiştirilecek.)
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-3FN5IOBA;Initial Catalog=proje1;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBoxKayitAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKayitSifre.Text) ||
                string.IsNullOrWhiteSpace(txtBoxKayitEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (EmailExists(txtBoxKayitEmail.Text))
            {
                MessageBox.Show("Email zaten var!", "Geçersiz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //textBox lardan alınan kayıt bilgileri veritabanına kaydedilir.
                KayitBilgileriniAl();
            }


            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Zaten açık olan Form1'i al
            form1.Show(); // Form1'i göster

            this.Close(); // Form2'yi kapat
        }

        private void KayitBilgileriniAl()
        {
            try
            {

                string query = "INSERT INTO kullanici (AdSoyad, parola, email) VALUES (@AdSoyad, @Parola, @Email)";

                using (SqlCommand sqlCommand = new SqlCommand(query, connect))
                {

                    sqlCommand.Parameters.AddWithValue("@AdSoyad", txtBoxKayitAdSoyad.Text);
                    sqlCommand.Parameters.AddWithValue("@Parola", txtBoxKayitSifre.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", txtBoxKayitEmail.Text);
                    sqlCommand.ExecuteNonQuery();
                    connect.Close();
                }


                MessageBox.Show("Kayıt yapıldı!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EmailExists(string email)
        {
            bool exists = false; //dışında olması gerekti :)
            try
            {
                connect.Open();
                string query = "SELECT email FROM kullanici";
                using (SqlCommand sqlCommand = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string existingEmail = reader["email"].ToString();

                            // parametreye koyulan email ile eşleşen var mı diye bakılıyor databasede
                            if (string.Equals(existingEmail, email, StringComparison.OrdinalIgnoreCase))
                            {
                                exists = true;
                                break; //bulduğu anda döngüden çıksın.
                            }
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exists;
        }

        private void checkBoxsifregoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxsifregoster.Checked)
            {
                 txtBoxKayitSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxKayitSifre.UseSystemPasswordChar= true;
            }
        }
    }
}


