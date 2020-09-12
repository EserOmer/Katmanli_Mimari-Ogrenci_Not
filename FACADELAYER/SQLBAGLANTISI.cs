using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // sql baglantısı için gerekli kütüphane

namespace FACADELAYER
{
    public class SQLBAGLANTISI
    {
        //Sql bağlantı sınıfından publick ve statik bir nesne türetiyoruz.
        //Sql bağlantısı oluşturmak için parantez içine veri tabanının vağlı olduğu adresi yazıyoruz
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=DBTESTKATMAN;Integrated Security=True");
    }
}

