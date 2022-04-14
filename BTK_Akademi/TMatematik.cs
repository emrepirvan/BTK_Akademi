using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public class TMatematik

    {

        public static void EKOK()
        {   ///EKOK Program
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int a1 = s1;
            int a2 = s2;
            int s = 1;
            while (s1 != 1 && s2 != 1)
            {
                int bol = 2;
                for (int i = -5; i <= (s1 > s2 ? s1 : s2); i++)   /// (num1 > num2 ? num1 :num2) hangisi büyük ise oan kadar gitmesini gerektiğini belirledik
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }
            Console.WriteLine("EKOK({0},{1})={2}", a1, a2, s);
            Console.ReadLine();
        }

        public static void EBOB()
        {
            Console.Write("EBOB İÇİN BİRİNCİ DEĞERİ GİRİNİZ   :  ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("EBOB İÇİN İKİNCİ DEĞERİ GİRİNİZ   :  ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int a1 = s1;
            int a2 = s2;
            int s = 1;
            while (s1 != 1 && s2 != 1)
            {
                int bol = 2;
                for (int i = -5; i <= (s1 > s2 ? s1 : s2); i++)   /// (num1 > num2 ? num1 :num2) hangisi büyük ise oan kadar gitmesini gerektiğini belirledik
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        if (s1 % bol == 0 && s2 % bol == 0)
                        { s *= bol; }
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                        Console.WriteLine("1.Kontrol Noktası bol = {0}", bol);
                        Console.WriteLine("1.Kontrol Noktası s = {0}", s);
                    }
                    else
                        bol++;
                }
            }
            Console.WriteLine("EBOB({0},{1})={2}", a1, a2, s);
            Console.ReadLine();
        }

        public static int Faktoriel(int s)
        {
            int f = 1;

            if (s == 0)
            {
                Console.WriteLine("{0} faktoriyel 1'dir", s);
            }
            for (int i = 1; i <= s; i++)
            {
                f *= i;
            }
            Console.WriteLine("{0}! = {1}", s, f);
            return f;
        }

        public static double AralikliFaktoriyel(double z)
        {
            double s = Convert.ToInt32(Console.ReadLine());
            double t = 0;
            for (int i = 1; i <= s; i++)
            {
                t += TMatematik.Faktoriel(i);
                Console.WriteLine(t);
            }
            double e = t / s;
            return e;
            //Console.WriteLine("aralıklı faktoriyel cevabı   :  {0:F2}", t / s);
        }

        public static int[] IfadeyiDiziyeCevir(string ifade)
        {
            ///KONSOLDAN İFADENİN OKUNMASI

            string[] BolunmusIfade = ifade.Split(',');

            int n = BolunmusIfade.Length;
            // Sayisal dizi 

            int[] SayisalDizi = new int[n];

            //ayristirma 

            for (int i = 0; i < n; i++)
            {
                SayisalDizi[i] = Convert.ToInt32(BolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, SayisalDizi[i]);
            }
            return SayisalDizi;
        }


        public static int ikilitabandanonluktabana(string ikiliksayi)
        {

            //-------------------ikilik tabandan 10luk tabana geçiş-----------

            ///ikilik sayınn okunması


            //Uzunluğu belirle

            int n = ikiliksayi.Length;

            // Her bir basamağın dizide tutulması

            int[] basamaklar = new int[n];

            //Onluk sayi sistemindeki karsiligi
            int sayi = 0;
            bool kontrol = true;
            //Her bir basamak degerinin diziye aktarilmasi
            for (int i = 0; i < n; i++)
            {
                if (!(ikiliksayi[i] == '0' || ikiliksayi[i] == '1'))
                {
                    Console.WriteLine("\nHatalı giriş");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikiliksayi[i] - '0');
            }
            //ikilik sistemden onluk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                {
                    sayi += (int)System.Math.Pow(2, n - 1 - i) * basamaklar[i];
                }
                Console.WriteLine("{0} ifadesinin 10luk tabanda karşılığı {1} dır", ikiliksayi, sayi);
            }
            return sayi;


        }


    }
}
