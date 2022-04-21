using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Cizim
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen() :base()
        {
            Console.WriteLine("Derived class-> Constructors");
        }

        public Dikdortgen(int genislik, int yukseklik, int x, int y) : base(genislik : -5, yukseklik : -10, x : -25, y:-35) // Bu şekilde dışarıdan girilen parametreleri ezdik
        {
            Console.WriteLine("Derived Class -> ctor 4p");
        }

        public override void Ciz()  //Burda Sekildeki Ciz() Metodunu ezerek kendi Diktorgen içinde yeni bir Metod yazdık
        {
            Console.WriteLine($"Dikdörtgen {Pozisyon} - {Boyut} ");
        }

        public override void Tasi(Pozisyon yenipozisyon)
        {
            Console.WriteLine($"");
            Console.Write(" Dikdortgen");
            base.Tasi(yenipozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Yukseklik = yukseklik;
            Boyut.Genislik = genislik;
        }
    }
}

