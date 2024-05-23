using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimYapimi2
{
     public  class ServerBaglantisi
    {
        public static string SqlConnectionString = @"Data Source=DESKTOP-N0OHQLM;Initial Catalog=proje1;Integrated Security=True;";
        public static SqlConnection baglanti = new SqlConnection(SqlConnectionString);

    }

}
