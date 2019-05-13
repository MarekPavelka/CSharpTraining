using System;

namespace SpeedRun2Hours
{
    class GuessNumber
    {
        public static void Solution()
        {
            var generator = new Random();
            var number = generator.Next(0, 100);
            var userTip = 0;
            var counter = 0;

            Console.WriteLine("Hadaj cislo na ktore myslim, ked budes pripraveny stlac enter");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Napis cislo od 0-100 ktore si myslim: ");
                while (true)
                {
                    
                    userTip = int.Parse(Console.ReadLine());

                    if (userTip < number)
                    {
                        Console.WriteLine("viac");
                    }

                    else if (userTip > number)
                    {
                        Console.WriteLine("menej");
                    }

                    else if (userTip == number)
                    {
                        Console.WriteLine($"Spravne uhadol si na {counter}. pokus");
                        break;
                    }
                    counter++;
                }
            }
        }
    }
}
