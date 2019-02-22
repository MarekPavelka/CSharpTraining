using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Obsah Pola 1 je: ");

            foreach (var item in array1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            Console.WriteLine("Obsah Pola 2 je: ");
            Console.ReadKey();

            foreach (var itemReversedArray in Reverse(array1))
            {
                Console.Write("{0} ", itemReversedArray);
            }

            Console.ReadKey();
        }

        static int[] Reverse(int[] randomArray)
        {
            var counter = 0;
            var index = randomArray.Length;
            var arrayNew = new int[index];

            for (index = randomArray.Length - 1; index >= 0; index--)
            {
                var valueOfRandomArray = randomArray[index];
                arrayNew[counter] = valueOfRandomArray;
                counter++;
            }
            return arrayNew;
        }
    }
}
