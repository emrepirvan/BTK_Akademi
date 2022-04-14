using System;

namespace BTK_Akademi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] X = Matris.Olustur(3, 3);
            Matris.Yazdir(X);
            Console.WriteLine("|X| = {0}",Matris.Determinant(X));
        }
    }
}
