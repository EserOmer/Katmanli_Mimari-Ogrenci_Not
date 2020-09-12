using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SqlCommand 
using System.Data; //CommandType
using ENTITYLAYER; //ENTITYLAYER sınıfını burada kullanmak için import ediyoruz

namespace FACADELAYER
{
    //Diğer sınıflardan erişim sağlayabilmek için FACADEOGRENCI sınıfımızı public yapmamız gerekiyor.
    public class FACADENOTLAR
    {
        //bu method sadece güncellendi ve ya güncellenemedi olarak true/false deger döndüreceği için bool türünde tanımlama yaptık.
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("NOTGUNCELLE", SQLBAGLANTISI.Baglanti);
            //tanımlanan komutun prosedür olduğunu tanıtıyoruz.
            komut.CommandType = CommandType.StoredProcedure;
            //Baglantı durumunu sorgulayıp sql bağlantısını tamamlıyoruz.
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            //Guncellenecek olan tablonun bütün değerlerini parametre olarak gönderiyoruz.
            komut.Parameters.AddWithValue("SINAV1", deger.SINAV1);
            komut.Parameters.AddWithValue("SINAV2", deger.SINAV2);
            komut.Parameters.AddWithValue("SINAV3", deger.SINAV3);
            komut.Parameters.AddWithValue("PROJE", deger.PROJE);
            komut.Parameters.AddWithValue("ORTALAMA", deger.ORTALAMA);
            komut.Parameters.AddWithValue("DURUM", deger.DURUM);
            komut.Parameters.AddWithValue("OGRID", deger.OGRENCIID);
            //Yapılan işlemin sonucunu döndürecektir.
            return komut.ExecuteNonQuery() > 0;
        }
        //Bu methodda kayıtları listeleyeceğimiz için list türünde tanımlama yapıyoruz.
        public static List<ENTITYNOTLAR> NOTLISTESI()
        {
            //list türünde bir nesne oluşturuyoruz.
            List<ENTITYNOTLAR> degerler= new List<ENTITYNOTLAR>();
            //SqlCommand sınıfından komut isimli bir nesne tanımlıyoruz.
            SqlCommand komut = new SqlCommand("NOTLISTESI", SQLBAGLANTISI.Baglanti);
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
                //Not verilerine ulaşabilmek için ENTITYNOTLAR sınıfından bir nesne oluşturuyoruz.
                ENTITYNOTLAR ent = new ENTITYNOTLAR();
                ent.OGRENCIID = Convert.ToInt16(dr["OGRID"]);
                ent.AD = dr["AD"].ToString();
                ent.SOYAD = dr["SOYAD"].ToString();
                ent.SINAV1 = Convert.ToInt16(dr["SINAV1"]);
                ent.SINAV2 = Convert.ToInt16(dr["SINAV2"]);
                ent.SINAV3 = Convert.ToInt16(dr["SINAV3"]);
                ent.PROJE = Convert.ToInt16(dr["PROJE"]);
                ent.ORTALAMA = Convert.ToDouble(dr["ORTALAMA"]);
                ent.DURUM = dr["DURUM"].ToString();
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
