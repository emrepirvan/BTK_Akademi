using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btk_OOP.Cizim
{///Virtual Methods
//Virtual oalrak bildirilmiş bir temel sınıf (Base class) metodu,
//Temel sınıftan türetilen sınıflarda overriden (ezilebilir, gerçersiz kılınabillir) edilebilir. Bu izi ilgili metot iin verilir.
// Virtual anahtar kelimesi metotlar için kullanılabildiği gibi, propertyler için de kullanılabilir

    public sealed class Pozisyon //Her şeklin bir pozisyonu olacak
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() =>
          $"X : {X} , Y : {Y} ";


    }
    public sealed class Boyut //Sealed ile artık bunu zırhladık , bunun üstünden her hangi bir yeni sınıf oluşturulamaz
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString() =>
             $"Genislik : {Genislik} " + 
            $"Yukseklik : {Yukseklik} ";
        
    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base Class -> Constructor");
        }
        public Sekil(int genislik, int yukseklik, int x, int y)
        {
            Boyut = new Boyut
            {
                Genislik = genislik,
                Yukseklik = yukseklik,
            };
            Pozisyon = new Pozisyon
            {
                X = x,
                Y = y,
            };
        }


        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get; } = new Boyut();

        public virtual void Ciz() =>  //Ezilebilir bir metot---------------------------------------VIRTUAL
            Console.WriteLine($"Sekil {Pozisyon} - {Boyut}");

        public virtual void Tasi(Pozisyon yenipozisyon)
        {
            Pozisyon.X = yenipozisyon.X;
            Pozisyon.Y = yenipozisyon.Y;
            Console.WriteLine($"Tasindi : {Pozisyon}");
        }


        public abstract void YenidenBoyutlandir(int genislik, int yukseklik);


    }

}
//Polymorfizm'de çağrılan yöntem derleme zamanı sırasında değil dinamik olarak tanımlanır

//
//public static void SekilCiz(Sekil sekil) //Polymorphism : Kompare edilirken değilde Çalışma zamanı sırasında dinamik bir şekilde bir metotdu çağırmasını sağlayacak
//                                         //Çalıştırdığımızda Gelen Dikdörtgen'dir.
//{
//    sekil.Ciz();
//}
//static void Main(string[] args)
//{
//    var r = new Dikdortgen();
//    r.Pozisyon.X = 55;
//    r.Pozisyon.Y = 25;
//    r.Boyut.Genislik = 200;
//    r.Boyut.Yukseklik = 100;
//    SekilCiz(r); // r aslında dikdörtgen  ama metodu Sekil clasından çağırmamıza rağmen bunu kabul etmesini bekliyoruz çünkü neticede dikdörtgen de sekil classından türedi
//                 //Sonuc Dikdortgen gelir
//                 //Sekil yerine dikdortgen gelmesine polymorphism ile açıklanır.
//    ///Daha önce bir araba isimli br modelleme yapmıştık, çalıştır dedik, fakat ucak farklı çalışıcak , araba farklı çalışıcak motor farklı çalışcak
//    ///Dolayısıyla bir taşıt nasıl çalışıcak buna çalışma zamanı sırasında karar vericeksek eğer burada dinamik bir yapı söz konusu olacak bunu da Polymorphism ile açıklıyoruz
//    r.Tasi(new Pozisyon { X = 20, Y = 30 });
//    SekilCiz(r);
//}





//public static void SekilCiz(Sekil sekil) //Polymorphism : Kompare edilirken değilde Çalışma zamanı sırasında dinamik bir şekilde bir metotdu çağırmasını sağlayacak
//                                         //Çalıştırdığımızda Gelen Dikdörtgen'dir.
//{
//    sekil.Ciz();
//}