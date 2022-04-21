using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Modelleme
{
    public class Tasit
    {
        private string motor;
        private double hacim;
        public string Motor { 
            get { return motor; }
            set { motor = value; }
        }
        public double Hacim { 
            get { return hacim; }
            set { hacim = value; 
            }
        }

        //Mesale taşıt classının içinde bir metot tanımı olsun; 
        public void Temizle()
        {
            Console.WriteLine("Tasit Temizlendi");
        }
    }
    ///Enumlar default olarak sıralı ve 0 dan başlayarak listelenir 
    ///Fakat sen buna bir değer vererek katan başlaması istedini de ayarlayabilirsin
    public enum Motor
    {
        Dizel, 
        Benzin,
        LPG, 
        Elektrik,
        Jet
    }
    public enum Renk
    {
        Beyaz, Siyah, Gri, Kırmızı, Yeşil , Mavi
    }
}
