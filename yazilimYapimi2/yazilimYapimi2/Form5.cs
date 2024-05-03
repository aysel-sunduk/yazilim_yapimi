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
    public partial class Form5 : Form
    {

      

        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    
        private void btnSinavKapat_Click_1(object sender, EventArgs e)
        {
            
            this.Close(); // Form5'i kapat(sınav ekranını kapatır.)
        }
    }
}



