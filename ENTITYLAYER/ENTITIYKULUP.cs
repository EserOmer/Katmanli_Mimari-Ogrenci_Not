using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class ENTITIYKULUP //Diğer sınıflardan erişim sağlayabilmek için ENTITYOGRENCI sınıfımızı public yapmamız gerekiyor.
    {
        //Sınıf içerisindeki değişkenlere diğer katmanlardan ulaşabilmek için kapsülleme işlemi gerçekleştiriyoruz.
        int _KULUPID;
        string _KULUPAD;

        public int KULUPID { get => _KULUPID; set => _KULUPID = value; }
        public string KULUPAD { get => _KULUPAD; set => _KULUPAD = value; }
    }
}
