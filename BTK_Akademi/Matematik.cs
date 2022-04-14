using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public class Matematik
    {
        /// <summary>
        /// girilen bir sayının taban ve kuvvete bağlı olarak üstalma işlemini yapan fonksiyondur.
        /// </summary>
        /// <param name="taban"></param>
        /// <param name="kuvvet"></param>
        /// <returns></returns>
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
            {
                s = s * taban;
            }
            Console.WriteLine("sonuc budur {0}",
            s);
            return s;
        }

        /// <summary>
        /// bir sayının asal çarpanlarını verir
        /// </summary>
        /// <param name="n"> sayıyı temsil eder</param>
        /// <returns> carpan dizisdir</returns>
        public static int[] AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;

            while (n>1)
            {
                if (n%i==0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else 
                    i++;
            }
            carpanListesi = carpanListesi.Substring(0,carpanListesi.Length-1);
            string[] carpanlar = carpanListesi.Split(",");
            string s = carpanlar[0];
            string y = s;

            for (int iu = 0; iu < carpanlar.Length; iu++)
            {
                if (!(s==carpanlar[iu]))
                {
                    y = y + "," + carpanlar[iu];
                    s = carpanlar[iu];
                }
            }
            carpanlar = y.Split(",");
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (int io = 0; io < asalCarpanlar.Length; io++)     ///tekrarlayan ifadeleri 
                asalCarpanlar[io] = Convert.ToInt32(carpanlar[io]);
            return asalCarpanlar;
        }

        /// <summary>
        /// Asal çarpanların toplamını verir
        /// </summary>
        /// <param name="n"> Sayıyı temsil eder</param>
        /// <returns>Toplamı temsil eders</returns>
        public static int AsalCarpanlarinToplami(int n)
        {
            int [] asalCarpanlar = AsalCarpanlar(n);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
                t += asalCarpanlar[i];
            return t;
        }
        /// <summary>
        /// Asal çarpanlarin carpimini hesaplar
        /// </summary>
        /// <param name="n"> Sayıyı temsil eder</param>
        /// <returns>Toplamı temsil eders</returns>
        public static int AsalCarpanlarinCarpimi(int n)
        {
            int[] asalCarpanlar = AsalCarpanlar(n);
            int c = 1;
            for (int i = 0; i < asalCarpanlar.Length; i++)
                c *= asalCarpanlar[i];
            return c;
        }

        public static int DesenMiktari(int n)
        {


            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {

                    if (j >= i)
                        Console.Write('#');
                    else
                        Console.Write('-');
                }
                Console.WriteLine("");
            }
            return n;
        }
    }
}
