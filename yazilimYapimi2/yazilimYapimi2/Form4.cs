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
        public Form4()
        {
            InitializeComponent();
            // ComboBox'a yeni kelime sayılarını manuel olarak ekleyelim
            cmbBoxKelimeSayi.Items.AddRange(new object[] { 5, 10, 15, 20 }); // Örneğin
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-N0OHQLM;Initial Catalog=proje1;Integrated Security=True");
        private void tbPageKelimeEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnKelimeKayit_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into kelimeler (ingKelimeAdi,turKelimeAdi,ornCumle) Values ('" + txtBoxIng.Text.ToString() + "', '" + txtBoxTurk.Text.ToString() + "' , '" + txtBoxCumle.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            string mesaj = "Kelime başarıyla kaydedildi.";
            string title = "success";
            MessageBox.Show(mesaj, title);

        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {
          
            //sınav ekranına gider.
            Form5 form5 = new Form5();
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
    }
}
