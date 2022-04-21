using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Cizim
{
    public class Kare : Sekil
    {
        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            throw new NotImplementedException();
        }

        public override void Ciz()
        {
            Console.WriteLine($"Kare {Pozisyon} - {Boyut} ");
        }
    }
}
