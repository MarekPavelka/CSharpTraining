using System;

namespace _01_03_ZlteKarticky
{
    class Pokladna
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj vek:");
            var vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj ci si student: ano/nie");
            bool student = Console.ReadLine() == "ano";
            Console.WriteLine("Zadaj ci si ZTP: ano/nie");
            bool ztp = Console.ReadLine() == "ano";
            Console.WriteLine("Cena tvojho listka je {0}", CalculatePrice(vek, student, ztp));
            Console.ReadKey();

        }

        public static int CalculatePrice(int vek, bool student, bool ztp)
        {
            if (ztp)
            {
                return 0;
            }

            if (vek <= 7 || vek > 65)
            {
                return 1;
            }

            if (student && vek < 26)
            {
                return 3;
            }
            return 5;
        }

    }
}