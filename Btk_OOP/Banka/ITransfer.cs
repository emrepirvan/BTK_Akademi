using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Banka
{
    public interface  ITransfer : IBankaHesap
    {
        public bool TransferYap(IBankaHesap aliciHesap, decimal miktar);
    }
}
