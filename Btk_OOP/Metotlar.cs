using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP
{
    public class Metotlar
    {
        ///     [Modifiers] return_Type MethodName([parameters])
        ///     {
        ///          Method Body
        ///     }
        /// Expression-Bodied Methods : 
        /// Eğer bir methodun uygulanması sadece bir deyimi içeriyorsa, C# bunun içn basit bir söz dizilimi sağlar.
        /// Bu durumda süslü paranteler return deyimi gibi ifadelerin kullanılmasına gerek kalmaz
        /// => operatörü ifadenin sol ve sağ taraflarını birbirinden ayrılmasını sağlar
        public bool KareMi(int x, int y) // Modifiers Public// return_type : bool   Bu Clasic yazım
        {
            return (x == y);
        }
        public bool KareMi2(int x, int y) => x == y;  // Expression-Bodied Methods

        //Method Overloading

        public bool EsitMi (int x, int y) => (x == y);
        public bool EsitMi(double x, double y) => (x == y);
        public bool EsitMi(string x,string y) => x.Equals(y);

        //Optional arguments  

        //Method tanımlarında parametreler bazen tercihe bağlı olarak sunulabilir
        //Bu durumda varsayılan değerler tanımlaması gerekir

        public bool EsitMiMi(int x,int y = 1) => x== y;  //y ' ye değer verilmez ise  1 olarak atanır
        public bool EsitMiMi(double x = 1, double y = 1) => x == y; //x'e ve y'ye değer verilmez ise  1 olarak atanır 

    }
}
