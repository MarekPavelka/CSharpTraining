using System;

namespace ZlteKarticky
{
    using System.Linq;

    class ArrayReverse
    {
        public static void Run()
        {
            Console.WriteLine("Zadaj cisla oddelene medzerou: ");
            // "1 5 32 -1".Split(' ') -> new string[] { "1", "5", "32", "-1" }
            string[] stringNumbers = Console.ReadLine().Split(' ');
            int[] cisla = stringNumbers.Select(x => int.Parse(x)).ToArray();

            var reversed = Reverse(cisla);

            Console.WriteLine("Reverznuty array je: ");
            reversed.ToList().ForEach(x => Console.Write("{0} ", x));
        }

        static int[] Reverse(int[] input)
        {
            var reversedArray = new int[input.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = input[input.Length - i - 1];
            }

            return reversedArray;
        }
    }
}
