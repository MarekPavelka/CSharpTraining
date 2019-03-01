using System;

namespace _01_03_ZlteKarticky
{
    class GuessNumber
    {
        public static void Solution()
        {
            Random generator = new Random();
            var numberToGuess = generator.Next(1, 100);
            Console.WriteLine("Myslim si cislo od 1 do 100 skus ho uhadnut");
            Solver(numberToGuess);
        }

        private static void Solver(int number)
        {
            var counter = 0;
            while (true)
            {
                var userGuess = int.Parse(Console.ReadLine());
                if (userGuess > number)
                {
                    Console.WriteLine("menej");
                }

                if (userGuess < number)
                {
                    Console.WriteLine("viac");
                }

                if (userGuess == number)
                {
                    Console.WriteLine("Spravne, uhadol si na {0}. pokus", counter + 1);
                    break;
                }

                counter++;
            }
        }
    }
}