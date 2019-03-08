using System;

namespace _02_03_ZlteKarticky
{
    class HadajCislo
    {
        public static void Solution()
        {

            Random generator = new Random();
            var number = generator.Next(1, 100);
            Console.WriteLine("Im gona think number from 1-100, write number which i think of:");
            var counter = 1;

            while (true)
            {
                var userGuess = int.Parse(Console.ReadLine());

                if (userGuess < number)
                {
                    Console.WriteLine("viac");
                }

                if (userGuess > number)
                {
                    Console.WriteLine("menej");
                }

                if (userGuess == number)
                {
                    Console.WriteLine("Spravne uhadol si na {0}. pokus", counter);
                    break;
                }
                counter++;
            }

            Console.ReadLine();
        }

    }
}