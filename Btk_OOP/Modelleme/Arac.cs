using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Modelleme
{ ///araç classı  taşıt clasına kalıtım  yoluyla üretilsin ve biz motor ve hacim bilgilerini ordan alalım 
    //Burda taşit kapsayıcı class
    //araç classı taşıttan türemiş oldu
    //Inheritance yani kalıtım yoluyla görüyoruz ki sınıfları genişletmek mümkün
    //Bunun içinde   :  işaretini kullanıyoruz, : deyiminden sonra eğer bir class yapısı söz konusu oluyor ise 
    //Bu classtaki tüm nitelikleri tüm fonksiyonları araç classı içinde kullabiliriz
    public class Arac :Tasit
    {
        #region Fields
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Property
        public string Marka {
            get { return marka; } 
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public int Yil { 
            get { return yil; } 
            set { yil = value; } 
        }
        #endregion
        #region Constructors
        public Arac()
        {

        }
        public Arac( string marka , string model , string renk, int yil)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
        }
        public Arac(string marka, string model, string renk, int yil, string motor,double hacim)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            Yil = yil;
            Motor = motor;
            Hacim = hacim;
        }

        #endregion
        #region Methods
        public void Calistir()
        {
            Console.WriteLine($"Arac Calisti !!");
        }
        public void Durdur()
        {
            Console.WriteLine($"Arac Durduruldu!!");
        }
        #endregion
        ///Override // başka bir metodu ezme
        /// Object sınıfından gelen ToString diye bir metot var ve biz bu metodu ezmek istedik.
        /// Bunu override ettik, dedik ki üst sınıfın ToString Metodunu sen kullanma bunun yerine ToString Dediğimizde 
        /// Sen aşağıdaki işleri yap ve Geriye boş bir string dön, --------(isteseydin bunları bi değişkene alıp onları da dönebilirdik)
        /// 
        /// This ifadesi olmasa da derleyici bunların her birinin property olduğunu anlayabiliyor ve yine aynı çıktıyı alabilir
        public override string ToString()
        {
            Console.WriteLine(new String('-', 30));
            Console.WriteLine($"{this.Marka}");
            Console.WriteLine($"{this.Model}");
            Console.WriteLine($"{this.Renk}");
            Console.WriteLine($"{this.Yil}");
            Console.WriteLine($"{this.Motor}");
            Console.WriteLine($"{this.Hacim}");
            Console.WriteLine("");
            return Marka +" "+ Model;  //Şeklinde de geri dönüş yapabilirdik
        }




    }
}
//Arac benimAracim = new Arac("skoda", "SuperB", "Gri", 2020);
//benimAracim.Motor = Motor.Elektrik.ToString();
//benimAracim.Hacim = 1.6;


////Motor benimMotor = new Motor();
////string a = Enum.GetName(typeof(Motor),3);


//benimAracim.Temizle();
//benimAracim.Calistir();


//benimAracim.ToString();

//Console.WriteLine("-----------------------------------------------------");
//Arac seninAracin = new Arac
//{
//    Marka = "bmw",
//    Model = "5.20",
//    Renk = Renk.Beyaz.ToString(),
//    Yil = 2022,
//    Motor = Motor.Elektrik.ToString(),
//    Hacim = 1.5
//};
//seninAracin.ToString();




//List<Arac> filo = new List<Arac>();

//filo.Add(new Arac
//{
//    Marka = "Skoda",
//    Model = "Octavia",
//    Renk = Renk.Beyaz.ToString(),
//    Yil = 2018,
//    Motor = Motor.Dizel.ToString(),
//    Hacim = 1.6
//});
//filo.Add(new Arac
//{
//    Marka = "Opel",
//    Model = "Corsa",
//    Renk = Renk.Kırmızı.ToString(),
//    Yil = 2014,
//    Motor = Motor.Benzin.ToString(),
//    Hacim = 1.4
//});
//filo.Add(new Arac
//{
//    Marka = "Renault",
//    Model = "Fluence",
//    Renk = Renk.Siyah.ToString(),
//    Yil = 2017,
//    Motor = Motor.Dizel.ToString(),
//    Hacim = 1.6
//});


////Mesela Filomuzdaki bir aracı silicez
//filo.RemoveAt(1);
////Veya bir aracımızı kiralicaz, bunu başka bir listeye de gönderebilirdik

//foreach (Arac a in filo)
//{
//    a.ToString();
//}