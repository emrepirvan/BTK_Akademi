using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public class Matris
    {
        /// <summary>
        /// Matris oluşturur
        /// </summary>
        /// <param name="satir"> satir sayisi   </param>
        /// <param name="sutun">sutun sayisi </param>
        /// <param name="min"> minimum değer</param>
        /// <param name="max"> maksimum değer</param>
        /// <returns> X matrisi oluşturacak</returns>
        public static int[,] Olustur(int satir=3, int sutun=3, int min=1, int max=9)
        {
            int[,] X = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                    X[i, j] = new Random().Next(min, max);



            return X;
        }

        /// <summary>
        /// parametre olarak aldığı matrisi ekrana yazar
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[,] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                   Console.Write("{0,5}",X[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır
        /// </summary>
        /// <param name="X"> Dizi</param>
        public static void Yazdir(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("{0,5}", X[i]);

            }
            Console.WriteLine();
        }
        /// <summary>
        /// sıfır matrisi oluşturur
        /// </summary>
        /// <param name="satir">satir sayisi</param>
        /// <param name="sutun">sutun sayisi</param>
        /// <returns></returns>
        public static int[,] SifirMatrisiOlustur(int satir, int sutun)
        {
            return Olustur(satir, sutun,0,0);
        }
        /// <summary>
        /// birler matrisi olusturur
        /// </summary>
        /// <param name="satir"> satir sayisi</param>
        /// <param name="sutun"> sutun sayisi</param>
        /// <returns></returns>
        public static int[,] BirlerMatrisiOlustur(int satir, int sutun)
        {
            return Olustur(satir, sutun, 1, 1);
        }


        /// <summary>
        /// kosegen matris olusturur
        /// </summary>
        /// <param name="boyut"> satir ve sutun sayisi</param>
        /// <param name="min">minimum değerler</param>
        /// <param name="max"> maksimum değerler</param>
        /// <returns></returns>
        public static int[,] KosegenMatrisOlustur(int boyut=3,int min=1,int max=9)
        {
            int[,] X = SifirMatrisiOlustur(boyut, boyut);

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if  (i == j)
                    {
                        X[i,j] = new Random().Next(min,max);
                    }
                }
            }
            return X;
            
        }

        /// <summary>
        /// skaler matris oluşturur
        /// </summary>
        /// <param name="boyut"> satır ve sutunu temsil eder </param>
        /// <param name="skaler"> kosegenler üzerindeki değeri temsil eder</param>
        /// <returns></returns>
        public static int[,] SkalerMatrisOlustur(int boyut=3, int skaler = 3)
        {
            return KosegenMatrisOlustur(boyut, skaler, skaler);
        }



        /// <summary>
        /// kare matris kontrolü yapar
        /// </summary>
        /// <param name="X"> Matris</param>
        ///// 
        //              int[,] X = Matris.BirlerMatrisiOlustur(5, 5);
        //              Matris.Yazdir(X);
        //              Console.WriteLine("{0}", Matris.KareMatrisMi(X)? "kare matris" :"kare matris değil!" ); 
        /// 
        /// <returns>Sonuc</returns>
        public static bool KareMatrisMi(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ?
                true : false;
        }


        public static int[,] BirimMatris(int boyut=3)
        {
            return SkalerMatrisOlustur(boyut, 1);
        }
        /// <summary>
        /// Birim Matris Kontrolu yapar
        /// </summary>
        /// <returns>True ya da False olabilir</returns>
        public static bool BirimMatrisMi(int[,] X)
        {
            bool s = true;

            for (int i = 0; (i < X.GetLength(0) && s == true); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    /// diyagonal elemanlar dışındaki değerler 0 mı ?
                    if (X[i, j] != 0 && i != j)
                    {
                        s = false;
                        break;
                    }
                    //diyagonal elemanlar bir mi
                    else
                    {
                        if (X[i, i] != 1 && i == j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            return s;
        }

        /// <summary>
        /// Diyagonal elemanların listesini bir dizi olarak.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns></returns>
        public static int[] DiyagonalElemanlarinListesi(int[,] X)
        {
            if (KareMatrisMi(X) )
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                    D[i] = X[i,i];
                return D;
            }
            else
            {
                int[] sayilar = new int[1];
                Console.WriteLine("lütfen kare matris giriniz");
                return sayilar;
            }
        }
        /// <summary>
        /// Bir matrisin izini verir
        /// </summary>
        /// <param name="X"> Matris</param>
        /// <returns>izi</returns>
        public static int Izi(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {
                int[] D = DiyagonalElemanlarinListesi(X);
                for (int i = 0; i < D.Length; i++)
                {
                    t += D[i];
                }
                return t;
            }
            else
            {
                return t;
            }
        }

        /// <summary>
        /// Bir matrisin transpozunu alır
        /// </summary>
        /// <param name="X">Matrisi</param>
        /// <returns>Transpoz</returns>
        public static int[,] Transpoz(int[,] X)
        {
           int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i, j] = X[j, i];
                }

            }


            return T;
        }


        /// <summary>
        /// iki matrisin karşılaştırmasını yapar
        /// </summary>
        /// <param name="X">1.matris</param>
        /// <param name="Y">2.matris</param>
        /// <returns>Eşit mi</returns>
        public static bool EsitliMi(int[,] X, int [,] Y)
        {
            bool s = true;
            if (X.GetLength(0) == Y.GetLength(0) && X.GetLength(1) == Y.GetLength(1))
            {
                for (int i = 0; i < Y.GetLength(0); i++)
                {
                    for (int j = 0; j < Y.GetLength(1); j++)
                    {
                        if (Y[i,j]!= X[i,j])
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                s = false;
            }
            return s;
        }


        /// <summary>
        /// Determinan hesabı yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Determinant</returns>
        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                {
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                }
                else if (X.Length == 9)
                {
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                        X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) +
                        X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                }
                else
                {
                    Console.WriteLine("Tanimli bir boyut yok!");
                    return d;
                }

                return d;
            }
            else
            {
                Console.WriteLine("kare matris olmalı");
                return d;
            }

        }
        /// <summary>
        /// skaler bir değer ile matrisi carpar.
        /// </summary>
        /// <param name="c">Skaler deger</param>
        /// <param name="X">Matris</param>
        /// <returns>Carpim</returns>
        public static int[,] SkalerCarpim(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    X[i, j] = c * X[i, j];
                }

            }
            return X;
        }


        /// <summary>
        /// Bir matristeki elemanlarin toplamini verir
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>Toplam</returns>
        public static int ElemanlariToplami(int[,] X)
        {
            int t = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    t += X[i, j];
                }
            }
            return t;
        }

        /// <summary>
        /// Simetrik matris olusturur
        /// </summary>
        /// <param name="boyut">Matrisin boyutu</param>
        /// <param name="min">alabilecegi minimum deger</param>
        /// <param name="maks">alabilecegi maksimum deger</param>
        /// <returns>Simetrik Matris Olustrur</returns>
        public static int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i-1; j++)
                {
                    X[i, j] = new Random().Next(min, maks);
                    X[j,i] = X[i,j];
                }

            }
            return X;
        }

        public static bool SimetrikMi(int[,] X)
        {
            int[,] Y = Matris.Transpoz(X);
            return EsitliMi(X, Y);
        }

        /// <summary>
        /// Kosegen matris olup olmadıgının kontrolunu yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Sonuc</returns>
        public static bool KosegenMatrisMi(int[,] X)
        {
            bool s = true;
            if (Matris.KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (!(X[i,j]==0))
                        {
                            if (i != j)
                            {
                                s = false;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Kare Matris degil");
                s = false;
            }
            return s;
        }

        /// <summary>
        /// Ust Ucgen matris olusturur
        /// </summary>
        /// <param name="boyut">matrisin boyutu</param>
        /// <param name="min">elemanların alıcagı min deger</param>
        /// <param name="maks">elemanların alacagı maks deger</param>
        /// <returns>Matris</returns>
        public static int[,] UstUcgenMatrisOlustur(int boyut = 3, int min=1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i; j < X.GetLength(1); j++)
                {
                    X[i,j] = new Random().Next(min,maks);
                }

            }
            return X;
        }
        /// <summary>
        /// Alt Kosegen matris olusturur
        /// </summary>
        /// <param name="boyut">Matrisin boyutu</param>
        /// <param name="min">Degerlerin alacagı Maks</param>
        /// <param name="maks">Degerlerin alacagı Min</param>
        /// <returns>Alt ucgen Matris</returns>
        public static int[,] AltUcgenMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    X[i, j] = new Random().Next(min, maks);
                }

            }
            return X;
        }


        /// <summary>
        /// Parametre olarak aldigi matrisin Ust Ucgen olup olmadıgını kontrol eder
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>Sonuc</returns>
        public static bool UstUcgenMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i-1; j++)
                {
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
                }

            }
            return s;
        }

        /// <summary>
        /// Parametre olarak aldigi matrisin Alt Ucgen olup olmadıgını kontrol eder
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>Sonuc</returns>
        public static bool AltUcgenMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i+1; j < X.GetLength(1); j++)
                {
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
                }

            }
            return s;
        }
    }
}
