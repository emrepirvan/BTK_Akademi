using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Banka
{
    public class YatirimHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye
        {
            get { return _bakiye; }
        }
       
        public bool Cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a bakiye yetersiz");
            return false;
        }

        public void Yatir(decimal miktar)
        {
           _bakiye += miktar;
        }

        public override string ToString()
        {
            Console.WriteLine($" Yatirim hesabi bakiye bilgisi {_bakiye,6:C}");
            return " ";
        }
    }
}
