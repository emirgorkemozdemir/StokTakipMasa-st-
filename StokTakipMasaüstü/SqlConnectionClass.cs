using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipMasaüstü
{
    public class SqlConnectionClass
    {
        public static SqlConnection myconnection = new SqlConnection("Data Source=LAPTOP-N542L05B;Initial Catalog=StokTakipDB;Integrated Security=True;TrustServerCertificate=True");

        // Baglantıyı if ile kontrol ediyoruz. Kapalıysa açıyoruz
        public static void CheckConnection()
        {
            if (myconnection.State == System.Data.ConnectionState.Closed)
            {
                myconnection.Open();
            }
        }
    }
}
