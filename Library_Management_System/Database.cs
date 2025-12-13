using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Database
    {
        public static string baglantiCumlesi = @"Server=.;Database=VTkutuphane;Integrated Security=True;";


        public static SqlConnection GetSqlConnection()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                baglanti.Open();
                Console.WriteLine("Bağlantı Kuruldu");
                return baglanti;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı Hatası: " + ex.Message);
                //return null;  // Hata olursa null döndür
                throw;
            }
        }
    }
}
