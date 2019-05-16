using System;

namespace SpeedRun2hours2
{
    class GuessNumberSolver
    {
        public static void Solution()
        {
            Console.WriteLine("Vymysli si cislo od 1-100 ja budem hadat, ty mi pis \"viac\", \"menej\", \"spravne\"");
            Console.ReadLine();
            var min = 1;
            var max = 100;
            var counter = 0;

            while (true)
            {
                counter++;
                var generateNumber = (max - min) / 2 + min;
                Console.WriteLine($"My guess is {generateNumber}");
                var userResponse = Console.ReadLine();

                if (userResponse == "viac")
                {
                    min = generateNumber;
                }

                if (userResponse == "menej")
                {
                    max = generateNumber;
                }

                if (userResponse == "spravne")
                {
                    Console.WriteLine($"Spravne uhadol si na {counter}. pokus");
                    break;
                }
            }
        }
    }
}
