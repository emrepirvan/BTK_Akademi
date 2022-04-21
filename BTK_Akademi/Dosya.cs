using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public class Dosya
    {
        public static string FizikselYol(string dosyaAdi)
        {
            {
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                //foreach (string yolFile in yol)
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyaYol += yol[i] + "\\";
                }
                dosyaYol += dosyaAdi;
                return dosyaYol;
            }
        }
    }
}
