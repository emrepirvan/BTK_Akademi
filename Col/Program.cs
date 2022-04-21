using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel; //Collection<int> a;

namespace Coll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0 ,1, 2, 3, 4, 5, 6 };
            string[] names ={ "emre","ali","ebru"};
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            };
            ProcessItems<int>(arr);
            ProcessItems<int>(list);
            ProcessItems<string>(names);


        }
        /// <T> ile ifade edilmiş değer integer de oldu string de oldu Lis
        private static void ProcessItems<T>(IList coll)
        {
            Console.WriteLine("Is read returns {0} for this collection.",coll.IsReadOnly);
            foreach (T item in coll)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        //private static void ProcessItems<T>(T[] arr)
        //{
        //    throw new NotImplementedException();
        //}



        //Array dizi = Array.CreateInstance(typeof(int), 3);
        //dizi.SetValue(23, 0);
        //dizi.SetValue(44,1);
        //dizi.SetValue(55,2);

        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    Console.WriteLine(dizi.GetValue(i));
        //}


        //---------------------------------
        ///IEnumerable başlıngıçta kırmızıydı fakat, ctrl . 
        ///dediğimizde kod tamamlama özelliği bize bir fonksiyon yazmamızı
        ///istedi, yani implemente önerdi , alttaki geldi

        internal class MyCollection : IEnumerable  ////Ve bu şekilde nongeneric bir ifadeyi/koleksiyonu bu şekilde tanımlamış olacaz
        {
            int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator GetEnumerator() //Buşekilde kendi özel koleksiyonumuzu yazmış olduk
                //Bu diğer koleksiyonlara göre biraz daha hızlı çalışıcak çünkü objeli değil integer'lı
                //Yield anahtar sözcüğü de her defasında çağrıldığı zaman sırayla dizideki değerleri ileri yönde dönücek
                //ilk çağırdığımızda 1 dönücek , bir daha çağırdğımızda 2 dönücek gibi..
                //Dolayısıyla dizi elemanlarına tek tek erişebilicez
                //Buradaki kesme işlemi yani tek tek çağırmayı yapıcak ifade ""yield" anahtar sözcüğü tanımlıcak
            {
                foreach (int i in data)
                {
                    yield return i;
                };
            }
        }
        //Generic yapıcağıımız için <> ifadesi geldi/ bunun arasına seal yani paketlenmiş zırhlanmış bir yapı da olabilir
        //integer gibi ya da string gibi bir ifade gelmeli
        internal class MyGenCollection : IEnumerable<int>
        {
            int[] data = {1,2,3, 4, 5};
            public IEnumerator<int> GetEnumerator() 
            {
                foreach(int i in data)
                    yield return i;
            }
            //birinde tek değer diğerinde çoklu liste değerleri dönebilir
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
