using System;
using System.IO;

namespace BTK_Akademi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kaynak = Dosya.FizikselYol("Adlar.txt");
            string hedef = Dosya.FizikselYol("Isimler.txt");

            StreamReader_Writer_FileInfo.Silme(hedef);
        }
    }
}
