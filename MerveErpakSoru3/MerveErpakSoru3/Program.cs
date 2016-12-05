using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerveErpakSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region şekil oluşturma
            Console.WriteLine("Lütfen bir şekil seçin: kare/dikdörtgen/yamuk");
            
            string sekil = Convert.ToString(Console.ReadLine());
            switch (sekil)
            {
                case "kare":
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("* ");
                        }
                 
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("*");
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write(" ");                           
                        }
                        Console.Write("*");
                        Console.Write("\n");
                       
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("* ");
                    }
                    Console.ReadKey();
                    break;
                case "dikdörtgen":
                    for (int i = 0; i < 5; i++)
                    {

                        Console.Write("*");
                    }
                    break;
                case "yamuk":
                    {

                        Console.Write("*");
                    }
                    break;

                default:
                    Console.WriteLine("Hatalı İşlem!");
                    break;
                    Console.ReadKey();

            }

            //for (int i = 0; i < 5; i++)
            
            //{
            //    for (int j = 0; j < 5; j++)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();

            #endregion
        }
    }
}
