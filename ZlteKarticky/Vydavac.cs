using System;

namespace ZlteKarticky
{
    class Vydavac
    {
        public static void Run()
        {
            Console.WriteLine("Zadaj sumu 1-99 z ktoru ti mam vydat: ");
            var zostatok = int.Parse(Console.ReadLine());
            var bankovky = new[] { 50, 20, 10, 2, 1 };
            foreach (var bankovka in bankovky)
            {
                while (FitsBankovkaInZostatok(bankovka, zostatok))
                {
                    zostatok = zostatok - bankovka;
                    Console.WriteLine(bankovka);
                }
            }
        }

        private static bool FitsBankovkaInZostatok(int bankovka, int zostatok)
        {
            return bankovka <= zostatok;
        }
    }
}
