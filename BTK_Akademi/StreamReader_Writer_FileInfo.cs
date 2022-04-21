using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public class StreamReader_Writer_FileInfo
    {
        public static void StramReaderilk()
        {
            try
            { // Dinamik konumu vermiş olduk , rakamlar.txt yoksa bile o dosyayı açmış olucaz
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                //foreach (string yolFile in yol)
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyaYol += yol[i] + "\\";
                }
                dosyaYol += "Adlar.txt";

                //Dosya okuma 
                //Using kullanımı undisposible olan nesneleri kullanırken

                using (StreamReader sr = new StreamReader(dosyaYol))  //Dosya yolunu elle de verebiliriz ,C:\\Users\\ThisUser\\adlar.txt" gibi
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) // SR ile okuma yapıcaz ta ki null'a gelene kadar
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StramWriterIlk()
        {
            try
            {
                string[] yol = Directory.GetCurrentDirectory().Split("\\");
                string dosyaYol = "";
                for (int i = 0; i < yol.Length-2; i++)
                {
                    dosyaYol += yol[i] + "\\";
                }
                dosyaYol += "Isimler.txt";

                string[] adlar = new string[] { "emre", "ahmet", "mehmet", "ebru", "Funda", "yudagül" };
                using (StreamWriter sw = new StreamWriter("C:\\Users\\emrep\\OneDrive\\Masaüstü\\StreamReaderFolder\\Isimler.txt"))
                {
                    foreach (string s in adlar)
                    {
                        sw.WriteLine(s);
                    }
                    Console.WriteLine("\n Adlar.txt dosyası başarıyla oluşturuldu");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void File03()
        {
            string dosyaAdi = BTK_Akademi.Dosya.FizikselYol("asdfsdfd.txt");
            Console.WriteLine(dosyaAdi);
            
        }
        
        public static void VarOlanDosyayaEkleme()
        {
            string ad = "";
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            try
            {
                FileStream fs = new FileStream(dosyaYolu,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None);
                while (ad != "cikis")
                {
                    Console.WriteLine("\n dosyaya kaydetmek üzere bir isim giriniz : ");
                    ad = Console.ReadLine();
                    if (ad !="cikis")
                    {
                        if (fs.CanWrite)
                        {
                            byte[] yaz = Encoding.UTF8.GetBytes(ad);  //Encoding ile Utf8 karakter standardını belirledik,
                                                                      //GetBytes diyerek byte byte yazıcaz 
                            //String olarak girilmiş ifadeyi bir byte dizisine çevirmiş olduk
                            fs.Write(yaz, 0, yaz.Length);  //yazıcağımız ifadeyi ve uzunluğunu verdik
                            fs.WriteByte(13);   //13 enter ifadesine denk geliyor bir alt satıra geçmesi için
                        }
                        else
                        {
                            Console.WriteLine("yazma yetkisi yok!");
                        }
                    }
                }

                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FileInftoilk()
        {
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            var fi = new FileInfo(dosyaYolu);

            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length);
            
        }


        /// <summary>
        /// Dosya kopyalama işlemini gerçekleştirir
        /// </summary>
        /// <param name="kaynak"></param>
        /// <param name="hedef"></param>
        public static void DosyaKopyalama(string kaynak , string hedef)
        {
            FileInfo fi = new FileInfo(kaynak);
            fi.CopyTo(hedef);
            Console.WriteLine("{0} kaynaklı dosya {1} kopyalandi.",kaynak,hedef);
        }
        /// <summary>
        /// parametre olarak aldığı dosya yoluna bağlı olarak silme işlemi gerçekleştirir
        /// </summary>
        /// <param name="kaynak">kaynak Dosya yolu</param>
        public static void Silme(string kaynak)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }
        }
    }
}
