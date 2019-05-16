using System;

namespace SpeedRun2hours2
{
    class Pokladna
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj svoj vek: ");
            var vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Napis ci si student? ano/nie");
            bool student = Console.ReadLine() == "ano";
            Console.WriteLine("Napis ci si ZTP? ano/nie");
            bool ztp = Console.ReadLine() == "ano";
            Console.WriteLine("Pre vypocet ceny stlac enter");
            Console.ReadLine();
            Console.WriteLine($"Cena tvojho listka je {Price(vek, student, ztp)} eur");

        }

        private static int Price(int vek, bool student, bool ztp)
        {
            if (ztp)
            {
                return 0;
            }

            if (vek <= 7 || vek >= 65)
            {
                return 1;
            }

            if (vek < 26 && student)
            {
                return 3;
            }
            return 5;
        }
    }
}
