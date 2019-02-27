using System;

namespace ZlteKarticky
{
    class Fibonacci
    {
        // 1 1 2 3 5 8 13
        public static void Run()
        {
            Console.WriteLine("Zadaj kolko prvych cisel z Fibonacciho postupnosti mam vypisat: ");
            int wantedCount = int.Parse(Console.ReadLine());

            int predposledny = 0;
            int posledny = 0;

            // runs wantedCount times
            for (int counter = 1; counter <= wantedCount; counter++)
            {
                // moje chrapunske riesenie
                if (predposledny == 0 && posledny == 0)
                {
                    Console.Write("1 ");
                    posledny = 1;
                    continue;
                }

                var nasledujuci = posledny + predposledny;
                Console.Write("{0} ", nasledujuci);

                predposledny = posledny;
                posledny = nasledujuci;
            }
        }
    }
}
