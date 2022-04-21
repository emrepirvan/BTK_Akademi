using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Banka
{
    public class AktifHesap : ITransfer
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

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

        public bool TransferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc  = Cek(miktar);
            if (sonuc == true)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }

        public void Yatir(decimal miktar)
        {
            _bakiye += miktar;
        }

        public override string ToString()
        {
            Console.WriteLine($"Aktif Hesap Bakiye  {_bakiye,6:C} ");
            return " ";
        }
    }
}
