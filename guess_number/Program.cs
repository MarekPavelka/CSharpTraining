using System;


namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ferko = new Random();
            int thinkNumber = ferko.Next(1, 100);

            Console.WriteLine("Hadaj cislo:");

            Funkcia(thinkNumber);
        }

        static void Funkcia(int thinkNumber)
        {
            int counter = 0;

            while (true)
            {
                counter++;
                int guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > thinkNumber)
                {
                    Console.WriteLine("menej");
                }

                if (guessNumber < thinkNumber)
                {
                    Console.WriteLine("viac");
                }

                if (guessNumber == thinkNumber)
                {
                    Console.WriteLine("spravne");
                    break;
                }
            }

            Console.WriteLine("Pocet pokusov bol {0}", counter);
            Console.ReadLine();
        }
    }
}
