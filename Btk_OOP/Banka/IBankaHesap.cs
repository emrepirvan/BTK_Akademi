using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Banka
{
    public interface IBankaHesap
    {
        void Yatir(decimal miktar);
        bool Cek(decimal miktar);
        decimal Bakiye { get; }

    }
}
//IBankaHesap mevduatHesabi = new MevduatHesabi();
//ITransfer aktifHesap = new AktifHesap();
//mevduatHesabi.Yatir(500);
//aktifHesap.Yatir(800);
//aktifHesap.TransferYap(mevduatHesabi, 200);

//Console.WriteLine($" {mevduatHesabi.ToString()}                 {aktifHesap.ToString()}");