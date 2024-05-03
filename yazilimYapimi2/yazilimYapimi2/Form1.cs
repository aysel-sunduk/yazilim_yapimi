using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //textBox tan alınan kullanıcı bilgileri sql de karşılaştırılacak,
            //ona göre giriş yapılacak ya da hata mesajı verilecek 

            Form4 form4 = new Form4();

            form4.Show();
            this.Hide();
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
    }
}

  