using System;

namespace SpeedRun2hours2
{
    class GuessNumber
    {
        public static void Solution()
        {
            var generator = new Random().Next(0, 100);
            Console.WriteLine("Budem si mysliet cislo od 0-100 ty hadaj na ake myslim");
            bool spravne = false;
            var counter = 0;

            while (!spravne)
            {
                counter++;
                var userGuess = int.Parse(Console.ReadLine());

                if (userGuess > generator)
                {
                    Console.WriteLine("Menej");
                }

                if (userGuess < generator)
                {
                    Console.WriteLine("Viac");
                }

                if (userGuess == generator)
                {
                    Console.WriteLine($"Spravne! Uhadol si na {counter}. pokus");
                    spravne = true;
                }
            }
        }
    }
}
