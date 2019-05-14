using System;

namespace SpeedRun2Hours
{
    class PCGuessNumber
    {
        public static void Solution()
        {
            Console.WriteLine("Vymysli si cislo 0-100 ja budem hadat ktore to je, ty mi pis viac/menej/spravne");
            Console.ReadLine();
            var minInterval = 1;
            var maxInterval = 100;
            var counter = 0;


            while (true)
            {
                counter++;
                var myGuess = (maxInterval - minInterval) / 2  + minInterval;
                Console.WriteLine($"{myGuess}");
                var userInput = Console.ReadLine();

                if (userInput == "menej")
                {
                    maxInterval = myGuess;
                }
                else if (userInput == "viac")
                {
                    minInterval = myGuess;
                }
                else if (userInput == "spravne")
                {
                    Console.WriteLine($"Uhadol som na {counter}. pokus");
                    break;
                }
            }
        }
    }
}
