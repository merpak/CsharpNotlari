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
            Console.WriteLine("[1-10] arasında bir sayı tuttum, Tahmin edebilir misin?");

            Random rnd = new Random();
            int sayi = rnd.Next(1, 11);
            int tahmin, counter=0;

            while (true)
            {
                counter++;
                Console.Write("Tahmin Et: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayi)
                {
                    break;
                }
                                
            }
            Console.WriteLine("\nTebrikler... {0}. adımda bildin", counter);
            Console.ReadKey();
            #endregion


        }
    }
}
