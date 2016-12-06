using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine(numbers.Count);

            //Console.Clear();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i, numbers[i]);
            //}

            // int[] array = new int[2];
            //array[0] = 3;
            // array[1] = 5;
            // List<int> list = new List<int>(array);
            // Console.WriteLine("{0} tane eleman yazdıracağım.", list.Count);
            // foreach(var elm in list)
            // {
            //     Console.Write(elm + " ");
            // }

            //List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905 });
            //int index = numbers.IndexOf(1907);

            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            //numbers.RemoveAt(0);//girilen index silinir
            //numbers.Remove(8);//girilen değer silinir, 1 den fazla ise ilk değer silinir
            //numbers.RemoveRange(3, 2);//aralığı siler

            //bool varmi = numbers.Contains(13); //konsoldaki değerler arasında arama yapar

            //bool varmi = true;
            //while(varmi)
            //{
            //    if (numbers.Contains(8))
            //    {
            //        numbers.Remove(8);
            //    }
            //    else
            //    {
            //        varmi = false;
            //    }
            //}

            var result = numbers.FindAll(i => i > 5).Count();

            foreach (var item in result)
            {
                Console.WriteLine("\n\t" + item);
            }



        }
    }
}
