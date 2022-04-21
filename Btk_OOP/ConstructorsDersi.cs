using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP
{
    public class ConstructorsDersi
    {
        //Yapılandırıcı metodun adı sınıf adı ile aynı olmak zorunda

        //Yapılandırıcı metodun geri dönüş tipi aslında sınıfın kendisini ifade ettiğinden geri dönüş tipi belirtilmez

        //Yapılandıcı sınıflar Overloading yapılabilir

        private string _adi;
        public ConstructorsDersi(string adi) => Adi = adi;   //Nesne oluşturulduğu anda parametre olarak atayan "Adi" değeri olan
                                                             //yapılancıdıcı Metot
        public string Adi { get => _adi; set => _adi = value; } // Expression bodies ifadesi


       ////Eğer yapılandıcı metot sadece tek bir ifadeden oluşuyorsa yapılandırıcı metot expression-bodied şeklinde uygulanabilir
       ///
       //Türetilmiş sınıflarda constructor yapısının kullanılması, bu durumda hiyerarşik bir yol izlenir

     }
}
