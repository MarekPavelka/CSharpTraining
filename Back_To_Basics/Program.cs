using System;

namespace Back_To_Basics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadaj vek:");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Si student? ano/nie");
            bool student = Console.ReadLine() == "ano";
            Console.WriteLine("Si ztp? ano/nie");
            bool ztp = Console.ReadLine() == "ano";

            int x = funkcia(vek, student, ztp);
            Console.WriteLine("Cena Vasho listka je {0}", x);
            Console.ReadLine();
        }

        static int funkcia(int vek, bool student, bool ztp)
        {
            if (ztp)
            {
                return 0;
            }

            else if (vek < 8 || vek >= 65)
            {
                return 1;
            }

            else if (student && vek <= 26)
            {
                return 3;
            }
            else
            {
                return 5;
            }

        }
    }
}
