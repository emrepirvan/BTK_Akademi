using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP
{
    ///inheritance'ın kullanılmadığı yerde extention method'lar da
    ///yine bir sınıfı genişletmek için kullanılabilir
    ///aşağıdaki örnekte string kütüphanesine extention metotla yeni bir fonksiyon ekledik
    ///

    //-------this------- anahtar sözcüğü ile kullanılır  ------Static------ bir metot olmaz zorundadır
    public static class ExtensionMethods
    {
        public static int kelimeSayisi(this string s) => s.Split().Length;
    }
    //string s = "Sen beni bilemedin amacımı göremedin";   
    //Console.WriteLine(s.kelimeSayisi());
}
