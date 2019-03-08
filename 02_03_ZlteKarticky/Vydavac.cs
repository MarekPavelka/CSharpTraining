using System;
using System.Collections.Generic;

namespace _02_03_ZlteKarticky
{
    class Vydavac
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj sumu na vydanie:");
            var amount = int.Parse(Console.ReadLine());

            var bankovky = new List<int>() { 50, 20, 10, 5, 2, 1 };

            foreach (var bankovka in bankovky)
            {
                while (amount >= bankovka)
                {
                    amount = amount - bankovka;
                    Console.WriteLine("{0}", bankovka);
                }
            }

            Console.ReadKey();
        }
    }
}