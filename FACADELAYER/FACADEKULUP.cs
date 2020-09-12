using System;
using System.Collections.Generic;
using System.Data.SqlClient;//SqlCommand 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;//ENTITYLAYER sınıfını burada kullanmak için import ediyoruz
using System.Data;//CommandType

namespace FACADELAYER
{
    //Diğer sınıflardan erişim sağlayabilmek için FACADEKULUP sınıfımızı public yapmamız gerekiyor.
    public class FACADEKULUP
    {
        //bu method etkilenmiş olan kayıt sayısı döndüreceği için int türünde tanımlama yaptık.
        public static int EKLE(ENTITIYKULUP deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("KULUPEKLE",SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Sql üzerindeki prosedüre parametreyi gönderiyoruz
            komut.Parameters.AddWithValue("KULUPAD",deger.KULUPAD);
            //Etkilenen kayıt sayısını döndürecektir.
            return komut.ExecuteNonQuery();
        }
        //bu method sadece silindi ve ya silinmedi olarak true/false deger döndürdüğü için bool değerinde tanımlama yaptık.
        public static bool SIL(int deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("KULUPSIL", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State!= ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Silinecek olan kaydın id sini prosedürümüze gönderiyoruz.
            komut.Parameters.AddWithValue("KULUPID", deger);
            //Yapılan işlemin sonucunu döndürecektir.
            return komut.ExecuteNonQuery() > 0;
        }
        //bu method sadece güncellendi ve ya güncellenemedi olarak true/false deger döndüreceği için bool türünde tanımlama yaptık.
        public static bool GUNCELLE(ENTITIYKULUP deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("KULUPGUNCELLE", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Güncellenecek olan tablonun bütün değerlerini parametre olarak gönderiyoruz.
            komut.Parameters.AddWithValue("KULUPAD", deger.KULUPAD);
            komut.Parameters.AddWithValue("KULUPID", deger.KULUPID);
            //Yapılan işlemin sonucunu döndürecektir.
            return komut.ExecuteNonQuery() > 0;
        }
        //Bu methodda kayıtları listeleyeceğimiz için list türünde tanımlama yapıyoruz.
        public static List<ENTITIYKULUP> KULUPLISTESI()
        {
            //list türünde bir nesne oluşturuyoruz.
            List<ENTITIYKULUP> degerler = new List<ENTITIYKULUP>();
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("KULUPLISTESİ", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Bu sınıf verileri okumak için kullandığımız bir sınıftır.Komut nesnesinin özellikleri ile beraber kullanıyoruz.
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                //Kulup verilerine ulaşabilmek için ENTITIYKULUP sınıfından bir nesne oluşturuyoruz.
                ENTITIYKULUP ent = new ENTITIYKULUP();
                ent.KULUPID =Convert.ToInt16(dr["KULUPID"]);
                ent.KULUPAD = dr["KULUPAD"].ToString();
                //ent nesnesinden aldığımız değerleri degerler nesnesine ekliyor.
                degerler.Add(ent);
            }
            //okuma işlemini bitir.
            dr.Close();
            //Degerleri geri döndürüyor.
            return degerler;
        }

    }
}
