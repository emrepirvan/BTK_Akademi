using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP
{
    public class Kisi
    {
        private string _adi;

        public string Adi { get => _adi; set => _adi = value; } //Expression-bodied şeklinde => ifadelerini kullanarak geldi
        //Yani Adi artık bir property oldu get ve set ile bu property'e okuma ve yazma yapabiliriz
        public int Yasi { get; set; }
        public Kisi()
        {

        }
        public Kisi(string adi)
        {
            Adi = adi;
        }
        public Kisi(string adi, int yas)
        {
            Adi = adi;
            Yasi = yas;
        }
    }
}
//Kisi k = new Kisi("Ahmet", 18); // Şeklinde çağırdığımızda bu classı somutlaştırmış oluyoruz
//k.Adi = "Ebru";
//k.Yasi = 25;
//Console.WriteLine(k.Adi + " " + k.Yasi);
//Kisi k2 = new Kisi("Sema");
//Console.WriteLine(k2.Adi + " " + k2.Yasi);
//Kisi k3 = new Kisi();
//Console.WriteLine(k3.Adi + " " + k3.Yasi);