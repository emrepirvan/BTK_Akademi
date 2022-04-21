using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Cizim
{
    public class Elips : Sekil
    {
        public override void Tasi(Pozisyon yenipozisyon)
        {
            Console.Write("Elips ");
            base.Tasi(yenipozisyon);

        }

        public override void Ciz()
        {
            Console.WriteLine($"Elips {Pozisyon} - {Boyut} ");
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Yukseklik = yukseklik;
            Boyut.Genislik = genislik;
        }
    }
}
