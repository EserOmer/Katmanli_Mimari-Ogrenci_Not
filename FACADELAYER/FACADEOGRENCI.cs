using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//SqlCommand 
using System.Data;//CommandType
using ENTITYLAYER;//ENTITYLAYER sınıfını burada kullanmak için import ediyoruz


namespace FACADELAYER
{
    //Diğer sınıflardan erişim sağlayabilmek için FACADEOGRENCI sınıfımızı public yapmamız gerekiyor.
    public class FACADEOGRENCI
    {
        //bu method etkilenmiş olan kayıt sayısı döndüreceği için int türünde tanımlama yaptık.
        public static int EKLE(ENTITYOGRENCI deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("OGRENCIEKLE", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Eklenecek olan tablonun bütün değerlerini parametre olarak gönderiyoruz.
            komut.Parameters.AddWithValue("AD", deger.AD);
            komut.Parameters.AddWithValue("SOYAD", deger.SOYAD);
            komut.Parameters.AddWithValue("FOTOGRAF", deger.FOTOGRAF);
            komut.Parameters.AddWithValue("KULUPID", deger.KULUPID);
            //Etkilenen kayıt sayısını döndürecektir.
            return komut.ExecuteNonQuery();
        }
        //bu method sadece silindi ve ya silinmedi olarak true/false deger döndürdüğü için bool değerinde tanımlama yaptık.
        public static bool SIL(int deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("OGRENCISIL", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Silinecek olan kaydın id sini prosedürümüze gönderiyoruz.
            komut.Parameters.AddWithValue("ID", deger);
            //Yapılan işlemin sonucunu döndürecektir.
            return komut.ExecuteNonQuery() > 0;
        }
        //bu method sadece güncellendi ve ya güncellenemedi olarak true/false deger döndüreceği için bool türünde tanımlama yaptık.
        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("OGRENCIGUNCELLE", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Guncellenecek olan tablonun bütün değerlerini parametre olarak gönderiyoruz.
            komut.Parameters.AddWithValue("AD", deger.AD);
            komut.Parameters.AddWithValue("SOYAD", deger.SOYAD);
            komut.Parameters.AddWithValue("FOTOGRAF", deger.FOTOGRAF);
            komut.Parameters.AddWithValue("KULUPID", deger.KULUPID);
            komut.Parameters.AddWithValue("ID", deger.ID);
            //Yapılan işlemin sonucunu döndürecektir.
            return komut.ExecuteNonQuery() > 0;
        }
        //Bu methodda kayıtları listeleyeceğimiz için list türünde tanımlama yapıyoruz.
        public static List<ENTITYOGRENCI> OGRENCILISTESI()
        {
            //list türünde bir nesne oluşturuyoruz.
            List<ENTITYOGRENCI> degerler = new List<ENTITYOGRENCI>();
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("OGRENCILISTESI", SQLBAGLANTISI.Baglanti);
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
                //Ogrenci verilerine ulaşabilmek için ENTITYOGRENCI sınıfından bir nesne oluşturuyoruz.
                ENTITYOGRENCI ent = new ENTITYOGRENCI();
                ent.AD = dr["AD"].ToString();
                ent.SOYAD = dr["SOYAD"].ToString();
                ent.FOTOGRAF = dr["FOTOGRAF"].ToString();
                ent.KULUPID = Convert.ToInt16(dr["KULUPID"]);
                ent.ID = Convert.ToInt16(dr["ID"]);
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
