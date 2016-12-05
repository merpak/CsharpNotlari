using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[3];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.ReadKey();

            //Console.Write("Sınıf Mevcudu: ");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenciler = new string[mevcut];
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.Write("{0}. öğrencinin ismi: ", i);
            //    ogrenciler[i] = Console.ReadLine();

            //}
            //Console.Clear();
            //Console.WriteLine("Ogrenciler: \n");
            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //{

            //}


            //Random random = new Random();
            //int pozitif = 0, negatif = 0, sifir = 0;

            //Console.WriteLine("Kaç Sayı ?");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[size];
            //Console.Clear();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-100, 101);
            //}
            //foreach (var sayi in numbers)
            //{
            //    Console.WriteLine(sayi);
            //    if (sayi > 0)
            //    {
            //        pozitif++;
            //    }
            //    else if (sayi < 0)
            //    {
            //        negatif++;

            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} Tane Pozitif Sayi", pozitif);
            //Console.WriteLine("{0} Tane Negatif Sayi", negatif);
            //Console.WriteLine("{0} Tane Sıfır Var", sifir);

            //Console.ReadKey();

            string[] gunler = new string[] { "Pazertesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

        }
        
    }
}
