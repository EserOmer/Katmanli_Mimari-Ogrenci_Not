using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;//ENTITYLAYER sınıfını burada kullanmak için import ediyoruz
using FACADELAYER;//FACADELAYER sınıfını burada kullanmak için import ediyoruz



namespace BUSINESSLOGICLAYER
{
    //Diğer sınıflardan erişim sağlayabilmek için BLLKULUP sınıfımızı public yapmamız gerekiyor.
    public class BLLKULUP
    {

        public static int EKLE(ENTITIYKULUP deger)
        {
            if (deger.KULUPAD != null)
            {
                //FACADEKULUP sınıfının içerisindeki EKLE() metoduna, eklemeyi istediğimiz değişkeni gönderiyoruz.
                return FACADEKULUP.EKLE(deger);
            }
            //Girilen değer yok ise ekleme yapmayacaktır.
            return -1;
        }
        public static bool GUNCELLE(ENTITIYKULUP deger)
        {
            if(deger.KULUPAD!=null&& deger.KULUPID.ToString() != null)
            {
                //FACADEKULUP sınıfının içerisindeki GUNCELLE() methoduna, güncellemeyi istediğimiz değişkeni gönderiyoruz.
                return FACADEKULUP.GUNCELLE(deger);
            }
            //güncellenecek değerlerden herhangi birisi boş ise işlemi gerçekleştirme.
            return false;
        }
        public static bool SIL(int deger)
        {
            if (deger.ToString() != null)
            {
                //FACADEKULUP sınıfının içerisindeki SIL() methoduna, silmeyi istediğimiz değişkeni gönderiyoruz.
                return FACADEKULUP.SIL(deger);
            }
            //Boş değer girildiğinde işlem gerçekleşmeyecektir.
            return false;
        }
        public static List<ENTITIYKULUP> LISTELE()
        {
            //Kulüplerin listelenmesi için verilerimizi çağırıyoruz.
            return FACADEKULUP.KULUPLISTESI();
        }
    }
}
