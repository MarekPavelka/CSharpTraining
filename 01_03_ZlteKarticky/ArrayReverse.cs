using System;
using System.Linq;

namespace _01_03_ZlteKarticky
{
    internal class ArrayReverse
    {
        public static void Solution()
        {
            Console.WriteLine("Vypis cisla ktore chces v poli a oddeluj bodkociarkou");
            var input = Console.ReadLine();
            string[] inputArray = input.Split(';');

            var jebemBoha = string.Join(";", ReverseArray(inputArray));
            Console.WriteLine("Obratene je to takto {0}", jebemBoha);

        }

        public static string[] ReverseArray(string[] array)
        {
            var resultArray = new string[array.Length];
            var counter = 0;

            for (int i = array.Length; i > 0; i--)
            {
                resultArray[counter] = array[i-1];
                counter++;
            }

            return resultArray;
        }
    }
}