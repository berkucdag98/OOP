using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> arabalar = new List<string> { "Bmw", "Mercedes", "Renault" };
            //Console.WriteLine(arabalar[0]);
            //Console.WriteLine(arabalar[1]);
            //Console.WriteLine(arabalar[2]);
            //arabalar.Add("Opel");
            //Console.WriteLine(arabalar[3]);
            //Console.WriteLine(arabalar[0]);


            //MyList<string> urunler = new MyList<string>();

            //urunler.Add("Telefon");
            //urunler.Add("PC");
            //Console.WriteLine(urunler.Items[0]);
            //urunler.Add("PS");
            //urunler.Add("Tablet");
            //Console.WriteLine(urunler.Length);

            //foreach (var urun in urunler.Items)
            //{
            //    Console.WriteLine(urun);
            //}


            //Dictionary<int, string> ogrenci = new Dictionary<int, string>();

            //ogrenci.Add(123, "Berk Üçdağ");
            //ogrenci.Add(1234, "Ali Yılmaz");
            //ogrenci.Add(12345, "Veli Öztürk");
            //ogrenci.Add(123456, "Ahmet Zeki");

            //Console.WriteLine(ogrenci[1234]);

            MyDictionary<int,string> ogrenci2 = new MyDictionary<int, string>();
            ogrenci2.Add(111,"Berk");
            ogrenci2.Add(123,"Ali");
            Console.WriteLine(ogrenci2.Length);
            ogrenci2.Add(122,"Veli");
            ogrenci2.Add(133,"Ahmet");
            Console.WriteLine(ogrenci2.Length);

            Console.WriteLine($" Öğrenci No:{ogrenci2.TkeyItems[0]} \n Öğrenci Ad: {ogrenci2.TValueItems[0]}");

            for (int i = 0; i < ogrenci2.TkeyItems.Length; i++)
            {
                Console.WriteLine($" Öğrenci No:{ogrenci2.TkeyItems[i]} \n Öğrenci Ad: {ogrenci2.TValueItems[i]}");
            }


        }
    }
}
