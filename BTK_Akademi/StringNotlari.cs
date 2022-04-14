using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK_Akademi
{
    public static class StringNotlari
    {
        /// <summary>
        /// Belli bir char aralıktaki elemanları yazmayı sağlar
        /// </summary>
        public static void Elemanlari()
        {

            for (int i = 40; i < 400; i++)
            {
                Console.Write("{0,6}", (char)i);
                if (i % 5 == 0)
                {
                    Console.WriteLine(" ");
                }

            }
        }

        //public static void StringOlusturma1()
        //{
        //    char[] chars = { 'w', 'o', 'r', 'd' };
        //    sbyte[] bytes = { 0x41, 0x42, 0x43, 0x45, 0x00 };

        //    //Create a string from a character array.
        //    string string1 = new string(chars);
        //    Console.WriteLine(string1);

        //    // Create a string that consists of character repeated 20 times.
        //    string string2 = new string('c', 20);
        //    Console.WriteLine(string2);

        //    string stringFromBytes = null;
        //    string stringFromChars = null;
        //    unsafe
        //    {
        //        fixed (sbyte* pbytes = bytes)
        //        {
        //            /// Create a string from a pointer to a signed byte array.
        //            stringFromBytes = new string(pbytes);
        //        }
        //        fixed (char* pchars = chars)
        //        {
        //            ////// Create a string from a pointer to a signed byte array.
        //            stringFromChars = new string(pchars);
        //        }
        //    }
        //    Console.WriteLine(stringFromChars);
        //    Console.WriteLine(stringFromBytes);
        //}

        public static void StringBirlestirme()
        {

            /// bu günün tarihini string birleştirme ile cümle içinde kullanma
            string string1 = "Today is " + DateTime.Now.ToString("D") + ".";
            Console.WriteLine(string1);

            string string2 = " This is one sentence. " + "This is a second. ";
            string2 += "This is a third sentence.";
            Console.WriteLine("{0,50}", string2);
            ///The example displays output like following:
            /// Today is tesday july 06 ,2011.
            /// This is one sentence.This is a second.This is a third sentence."

        }

        public static void stringAyıklama()
        {
            string sentence = "This sentence has five words.";
            //Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition,
                sentence.IndexOf(" ", startPosition) - startPosition);
            Console.WriteLine("Second word: " + word2);
        }
        
        public static void StringDonusumu()
        {
            DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            double temperature = 68.3;
            string result = string.Format("At {0:t} on {0,0}, the temperature was {1:F1} degrees Fahrenheit.", dateAndTime, temperature);
            Console.WriteLine(result);
        }

        public static void stringkelimesayma()
        {
            string s1 = "This string consists of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();
            for (int ctr = 0; ctr < s1.Length; ctr++)
            {
                if (char.IsPunctuation(s1[ctr]) | char.IsWhiteSpace(s1[ctr]))
                    nWords++;
            }
            Console.WriteLine("The Sentence \n  {0}\nhas {1} words.", s1, nWords);
        }

        public static void StringBoslukKontrol()
        {
            //string ifadesinin null empty veya white space kontrolü için;
            string str = "sen beni bilemedin";
            if (str == null || str.Equals(String.Empty) || str.Trim().Equals(String.Empty))
            {
                ////şeklinde 3 kontrol yapmak yerine ;
                ///
                ///  isNullOrEmpty(string)
                /// 
                /// isNullOrWhiteSpace(string) metodunu kullanabiliriz
            }

        }
    }
}
