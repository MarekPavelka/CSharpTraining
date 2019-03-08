using System;

namespace _02_03_ZlteKarticky
{
    class Pokladna
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj svoj vek:");
            var vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Si student? ano/nie");
            var student = Console.ReadLine() == "ano";
            Console.WriteLine("Si ZTP? ano/nie");
            var ztp = Console.ReadLine() == "ano";

            Console.WriteLine("Cena Vaseho lista je {0} korun", Logika(vek,student,ztp));
            Console.ReadKey();
        }

        private static int Logika(int vek, bool student, bool ztp)
        {
            if (ztp)
            {
                return 0;
            }

            if (vek <= 7 || vek >= 65)
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