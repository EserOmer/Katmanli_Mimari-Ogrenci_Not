using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;


namespace BUSINESSLOGICLAYER
{
    public class BLLOGRENCI
    {
        public static int EKLE(ENTITYOGRENCI deger)
        {
            //Öğrenci ekleme için girilen değerler, istenilen aralıkta olduğu zaman eklenecek değeri FACADEOGRENCI katmanına göndererek ekleme işlemini tamamlıyor.
            if (deger.AD!=null&& deger.SOYAD!=null&& deger.KULUPID >0 && deger.FOTOGRAF != null&&deger.KULUPID>0&&deger.FOTOGRAF.Length>1)
            {
                return FACADEOGRENCI.EKLE(deger);
            }
            //Eklenecek değerlerden herhangi birisi boş ise işlemi gerçekleştirme.
            return -1;
        }
        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            //Öğrenci güncelleme için girilen değerler, istenilen aralıkta olduğu zaman güncellenecek değeri FACADEOGRENCI katmanına göndererek günccelleme işlemini tamamlıyor.
            if (deger.AD != null && deger.SOYAD != null && deger.KULUPID >0 && deger.FOTOGRAF != null && deger.KULUPID > 0&& deger.ID>0)
            {
                return FACADEOGRENCI.GUNCELLE(deger);
            }
            //Güncellenecek değerlerden herhangi birisi boş ise işlemi gerçekleştirmeyecektir.
            return false;
        }
        public static List<ENTITYOGRENCI> LISTELE()
        {
            //Listelenmesi istenilen verileri getiriyor
            return FACADEOGRENCI.OGRENCILISTESI();
        }
    }
}
