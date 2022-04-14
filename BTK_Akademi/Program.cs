using System;

namespace BTK_Akademi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] X = Matris.UstUcgenMatrisOlustur(5,3,10);
            Matris.Yazdir(X);
            Console.WriteLine("{0}",Matris.AltUcgenMatrisMi(X) ? "Alt Ucgen matris" : "Alt Ucgen Matris degil");
        }
    }
}
