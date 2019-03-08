using System;

namespace _02_03_ZlteKarticky
{
    class UserGuessNumber
    {
        public static void Solution()
        {
            Console.WriteLine("Vymysli si cislo ja budem hadat, pis mi viac, menej, spravne. Mas?");
            Console.ReadLine();
            var min = 1;
            var max = 100;

            for (int i = 1; i > 0; i++)
            {
                var pcGuess = (max - min) / 2 + min;
                Console.WriteLine(pcGuess);
                var userInput = Console.ReadLine();
                
                if (userInput == "viac")
                {
                    min = pcGuess;
                }

                if (userInput == "menej")
                {
                    max = pcGuess;
                }

                if (userInput == "spravne")
                {
                    Console.WriteLine("Juchuu, uhadol som na {0}. pokus", i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}