using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
    //Diğer sınıflardan erişim sağlayabilmek için BLLNOTLAR sınıfımızı public yapmamız gerekiyor.
    public class BLLNOTLAR
    {
        public static bool GUNCELLE(ENTITYNOTLAR deger)
        {
            //Not güncelleme için girilen değerler, istenilen aralıkta olduğu zaman güncellenecek değeri FACADELAYER katmanına göndererek günccelleme işlemini tamamlıyor.
            if(Convert.ToString(deger.OGRENCIID) != null && deger.OGRENCIID > 0 && Convert.ToString(deger.ORTALAMA) != null && deger.ORTALAMA >= 0 && deger.ORTALAMA <= 100 && Convert.ToString(deger.SINAV1) != null && deger.SINAV1 >= 0 && deger.SINAV1 <= 100 && Convert.ToString(deger.SINAV2) != null && deger.SINAV2 >= 0 && deger.SINAV2 <= 100 && Convert.ToString(deger.SINAV3) != null && deger.SINAV3 >= 0 && deger.SINAV3 <= 100 && Convert.ToString(deger.PROJE) != null && deger.PROJE >= 0 && deger.PROJE <= 100 && deger.DURUM != null)
            {
                return FACADENOTLAR.GUNCELLE(deger);
            }
            //Güncellenecek değerlerden herhangi birisi boş ise işlemi gerçekleştirmeyecektir.
            return false;
        }
        public static List<ENTITYNOTLAR> LISTELE()
        {
            //Listelenmesi istenilen verileri getiriyor
            return FACADENOTLAR.NOTLISTESI();
        }
    }
}
