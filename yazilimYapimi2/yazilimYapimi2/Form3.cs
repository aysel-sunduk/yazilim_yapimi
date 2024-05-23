using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace yazilimYapimi2
{
    public partial class Form3 : Form
    {
        private readonly string[] Scopes = { GmailService.Scope.GmailSend };
        private readonly string ApplicationName = "GmailApp";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");

        }



      

        private void btnYeniSifre_Click(object sender, EventArgs e)
        {

            try
            {
                string userEmail = txtBoxSifreAlEmail.Text;
                string newPassword = GenerateRandomPassword(); // Random şifre oluştur

                SendEmail(userEmail, newPassword); // E-posta gönder
                SavePasswordToDatabase(userEmail, newPassword); // Şifreyi veritabanına kaydet

                MessageBox.Show("Yeni şifreniz email adresinize gönderildi !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Email gönderilirken hata oluştu:( " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Zaten açık olan Form1'i al
            form1.Show();   // Form1'i göster
            this.Close(); // Form3'ü kapat
        
    }

        private void SendEmail(string recipientEmail, string newPassword)
        {

            UserCredential credential;
            // Gönderilen dosya projenin debug dosyasına konulacak ve buradaki adres o adres ile değiştirilecek.
            string jsonUzantisi = @"C:\Users\ELİF YILMAZ\Source\Repos\yazilim_yapimi_son\yazilimYapimi2\yazilimYapimi2\bin\Debug\client_secret_498875922383-fcscd9296oko616ag8pcmo77o66r710r.apps.googleusercontent.com.json";

            using (FileStream stream = new FileStream(jsonUzantisi, FileMode.Open, FileAccess.Read))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(path, true)).Result;

            }
            // Gmail servisini açar.
            var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
            string message = $"Yeni şifreniz: {newPassword}";

            //  Mesaj Base64 şeklinde şifrelenir.
            string encodedMessage = Base64UrlEncode($"To: {recipientEmail}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n{message}");

            //Yeni email mesaj nesnesi oluşturulur.
            var emailMessage = new Google.Apis.Gmail.v1.Data.Message { Raw = encodedMessage };


            // Email gönderilir.
            service.Users.Messages.Send(emailMessage, "me").Execute();



        }
        private string GenerateRandomPassword()
        {
            // Rastgele bir şifre oluşturuldu.
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SavePasswordToDatabase(string email, string newPassword)
        {
            // Veritabanı bağlantısı oluşturuldu.
            // Data Source ve Initial Catalog değiştirilecek.
            string connectionString = "Data Source=LAPTOP-3FN5IOBA;Initial Catalog=proje1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string komut = "UPDATE kullanici SET parola = @NewPassword WHERE email = @Email";
                using (SqlCommand command = new SqlCommand(komut, connection))
                {

                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@Email", email);


                    connection.Open();


                    int rowsAffected = command.ExecuteNonQuery();


                    connection.Close();


                    if (rowsAffected > 0)
                    {
                        // Başarılı bir şekilde güncellendi
                        MessageBox.Show("Şifre başarılı bir şekilde güncellendi !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Güncelleme başarısız oldu
                        MessageBox.Show("Şifre güncellenemedi :(.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
