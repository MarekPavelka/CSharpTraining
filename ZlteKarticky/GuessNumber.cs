namespace ZlteKarticky
{
    using System;

    class GuessNumber
    {
        public static void Run()
        {
            Console.WriteLine("Myslim si cislo od 1 - 100");
            var rndGenerator = new Random();
            var myNumber = rndGenerator.Next(1, 100);

            var guessCount = 0;
            var isGameOver = false;
            while (!isGameOver)
            {
                Console.WriteLine("Hadaj: ");
                guessCount++;
                var yourGuess = int.Parse(Console.ReadLine());

                if (yourGuess > myNumber)
                {
                    Console.WriteLine("menej");
                }

                if (yourGuess < myNumber)
                {
                    Console.WriteLine("viacej");
                }

                if (yourGuess == myNumber)
                {
                    Console.WriteLine("spravne");
                    Console.WriteLine("Uhadol si na {0}. pokus", guessCount);
                    isGameOver = true;
                }
            }
        }
    }
}
