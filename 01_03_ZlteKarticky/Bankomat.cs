using System;
using System.Collections.Generic;

namespace _01_03_ZlteKarticky
{
    class Bankomat
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj sumu na vydanie:");
            var suma = int.Parse(Console.ReadLine());
            Solver(suma);
        }

        public static void Solver(int input)
        {
            var coinsList = new List<int>() { 50, 20, 10, 5, 2, 1 };

            for (int index = 0; index < coinsList.Count; index++)
            {
                while (input >= coinsList[index])
                {
                    input = input - coinsList[index];
                    Console.WriteLine("{0}", coinsList[index]);
                }
            }
        }
    }
}