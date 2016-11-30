using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sayilari yaz 0,9
            //{
            //    int counter = 1;
            //    while (counter < 10)
            //    {
            //        Console.WriteLine(counter);
            //        counter++;
            //    }
            //    Console.ReadKey();

            //}
            #endregion

            #region faktöryel hesap
            //int n = 5, fakto = 1, counter = 1;
            //while (counter <= n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}
            //Console.WriteLine(fakto);
            //Console.ReadKey();
            #endregion

            #region sayı bulma
            //Console.WriteLine("[1-10] arasında bir sayı tuttum, Tahmin edebilir misin?");

            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 11);
            //int tahmin, counter=0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("Tahmin Et: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin == sayi)
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("\nTebrikler... {0}. adımda bildin", counter);
            //Console.ReadKey();
            #endregion

            #region devameden

            //bool devam = true;
            //while (devam)
            //{
            //    Console.Write("Birinci Sayı: ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İkinci Sayı: ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İslem Seç: ");
            //    char islem = Convert.ToChar(Console.ReadLine());

            //    double sonuc;

            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;

            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;

            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;

            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;
            //        default:
            //            Console.WriteLine("Böyle bir şey yok!");
            //            sonuc = 0;
            //            break;


            //    }

            //    Console.WriteLine("Sonuc: " + sonuc);

            //    Console.WriteLine("Devam Edilsin mi? (evet)");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "evet")
            //    {
            //        devam = true;

            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}
            //Console.WriteLine("C u!");
            //Console.ReadLine();
            #endregion

            #region taban hesaplama
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = 0;
            int basamak = 1;
            while (sayi>0)
            {
                sonuc += (sayi % 2) * basamak;
                basamak *= 10;
                sayi /= 2;

            }
            Console.WriteLine(sonuc);
            Console.ReadKey();
            #endregion
            
        }
    }
}
