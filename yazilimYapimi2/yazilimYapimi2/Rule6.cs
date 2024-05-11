using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimYapimi2
{
    public class Rule6
    {
        public void SetDateToWords(int bilinensiklik, SqlConnection connection, Kelimeler obj, string kullaniciID)
        {
            DateTime dt = DateTime.Now.Date;
            connection.Open();

            using (SqlCommand selectCommand = new SqlCommand($"SELECT SorulacakTarih FROM kelimeler{kullaniciID} WHERE EngWord = @EngWord", connection))
            {
                selectCommand.Parameters.AddWithValue("@EngWord", obj.secilenkelime);
                object result = selectCommand.ExecuteScalar();
            }

            DateTime newdate = Convert.ToDateTime(dt);

            DateTime newdatetime = DateTime.Now;

            switch (bilinensiklik)
            {
                case 0:
                    //direkt şimdiki zaman olarak geçirmesi için.
                    break;
                case 1:
                    newdatetime = newdate.AddDays(1);
                    break;
                case 2:
                    newdatetime = newdate.AddDays(7);
                    break;
                case 3:
                    newdatetime = newdate.AddMonths(1);
                    break;
                case 4:
                    newdatetime = newdate.AddMonths(3);
                    break;
                case 5:
                    newdatetime = newdate.AddMonths(6);
                    break;
                case 6:
                    newdatetime = newdate.AddYears(1);
                    break;
                default:
                    newdatetime = newdate.AddYears(10);
                    break;

            }

            using (SqlCommand updateCommand = new SqlCommand($"UPDATE kelimeler{kullaniciID} SET SorulacakTarih = @SorulacakTarih WHERE EngWord = @EngWord", connection))
            {
                updateCommand.Parameters.AddWithValue("@SorulacakTarih", newdatetime);
                updateCommand.Parameters.AddWithValue("@EngWord", obj.secilenkelime);
                updateCommand.ExecuteNonQuery();

            }
            connection.Close();
        }

        public int SetBilinmeSikliği(SqlConnection baglanti, Kelimeler obj, string kullaniciID, bool bildimi)
        {
            int newresult = 0;
            try
            {
                baglanti.Open();

                using (SqlCommand command1 = new SqlCommand($"SELECT BilinmeSikligi FROM kelimeler{kullaniciID} WHERE EngWord = @EngWord", baglanti))
                {
                    command1.Parameters.AddWithValue("@EngWord", obj.secilenkelime);
                    object result = command1.ExecuteScalar();
                    newresult = Convert.ToInt32(result);
                    if (bildimi)
                    {
                        newresult++;
                    }
                    else
                    {
                        newresult=0;
                    }

                    // SQL command to update the table with a condition

                    using (SqlCommand command = new SqlCommand($"UPDATE kelimeler{kullaniciID} SET BilinmeSikligi = @BaglantiSayisi WHERE EngWord = @EngWord", baglanti))
                    {
                        // Adding parameters to the SQL command
                        command.Parameters.AddWithValue("@BaglantiSayisi", newresult);
                        command.Parameters.AddWithValue("@EngWord", obj.secilenkelime);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                baglanti.Close();
            }
            return newresult;
        }

        public void _Rule6(SqlConnection baglanti, Kelimeler obj, string kullaniciID, bool dogrubildimi)
        {
            SetDateToWords(SetBilinmeSikliği(baglanti, obj, kullaniciID, dogrubildimi), baglanti, obj, kullaniciID);
        }

    }
}
