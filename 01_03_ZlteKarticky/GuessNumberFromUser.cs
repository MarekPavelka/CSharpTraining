using System;

namespace _01_03_ZlteKarticky
{
    class GuessNumberFromUser
    {
        public static void Solution()
        {
            Console.WriteLine("Vymyslis si cislo od 1 do 100 ja idem hadat, pis mi viac/menej/spravne mas?");
            Console.ReadLine();

            var min = 1;
            var max = 100;
            var counter = 1;

            while (true)
            {
                var getGuess = (max - min) / 2 + min;
                Console.WriteLine("{0}", getGuess);
                var decision = Console.ReadLine();
                if (decision == "viac")
                {
                    min = getGuess;
                }

                if (decision == "menej")
                {
                    max = getGuess;
                }

                if (decision == "spravne")
                {
                    Console.WriteLine("Uhadol som na {0}. pokus", counter);
                    break;
                }

                counter++;
            }
        }
    }
}