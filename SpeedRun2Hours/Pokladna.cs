using System;

namespace SpeedRun2Hours
{
    class Pokladna
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj vek: ");
            var vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Si student? ano/nie");
            bool student = Console.ReadLine() == "ano";
            bool ztp = Console.ReadLine() == "nie";

            if (ztp)
            {
                Console.WriteLine("Cena listka je 0");
            }

            else if (vek <= 7 && vek >= 65)
            {
                Console.WriteLine("Cena listka je 1");
            }

            else if (student && vek < 26)
            {
                Console.WriteLine("Cena listka je 3");
            }
            Console.WriteLine("Cena listka je 5");              
        }
    }
}
