using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public  class Dizi
    {
        public  int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];
            Console.WriteLine(" ");
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,3}", sayilar[i]);

            }
            Console.WriteLine(" ");
            return sayilar;
        }

        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
        }

        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                    ek = dizi[i];
            }
            return ek;
        }


        public static double AritmatikOrtalama(int[] dizi)
        {
            double arit = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                arit = dizi[i] + arit;
            }
            arit = arit / dizi.Length;

            return arit;
        }


        public static double StandartSapma(int[] X)
        {
            double aritmatikOrtalama = Dizi.AritmatikOrtalama(X);
            double t = 0, f = 0, std = 0;

            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmatikOrtalama;
                t += Math.Pow(f, 2);

            }
            std = t / (X.Length - 1);
            std = Math.Sqrt(std);
            return std;
        }


        public static int TekSayılarınSayısı(int[] Tek)
        {
            int teksayi = 0;
            for (int i = 0; i < Tek.Length; i++)
            {
                if (Tek[i] % 2 == 1)
                    teksayi++;

            }

            return teksayi;
        }


        public static int CiftSayılarınSayısı(int[] Cift)
        {
            int Ciftsayi = 0;
            for (int i = 0; i < Cift.Length; i++)
            {
                if (Cift[i] % 2 == 0)
                    Ciftsayi++;

            }

            return Ciftsayi;
        }


        public static int[] TekDiziOlustur(int[] X)
        {
            int[] tekDizi = new int[TekSayılarınSayısı(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tekDizi[y] = X[i];
                    y++;
                }
            }
            return tekDizi;

        }


        public static int[] CiftDiziOlustur(int[] X)
        {
            int[] ciftDizi = new int[CiftSayılarınSayısı(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }
            }
            return ciftDizi;

        }


        /// <summary>
        /// parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
            
                Console.Write("{0,3}",X[i]);
                Console.WriteLine("");
            

        }

        //Console.Write("n değerini giriniz : ");
        //    int limit = Convert.ToInt32(Console.ReadLine());
        //int[] sayilar = new Dizi().Olustur(limit);

        //Dizi dizi = new Dizi();

        //int[] tekSayilarDizisi = Dizi.TekDiziOlustur(sayilar);
        //Dizi.Yazdir(tekSayilarDizisi);
        //    Console.WriteLine("tek sayıların sayısı :  {0,5}", Dizi.TekSayılarınSayısı(sayilar));

        //    int[] ciftSayilarDizisi = Dizi.CiftDiziOlustur(sayilar);
        //Dizi.Yazdir(ciftSayilarDizisi);
        //    Console.WriteLine("Cift sayıların sayısı : {0,5}", Dizi.CiftSayılarınSayısı(sayilar));


        }
}
