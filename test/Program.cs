using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mysli si cislo od 1 do 100, ja idem hadat na co myslis");
            Random generator = new Random();

            int numberMin = 1;
            int numberMax = 100;
            int counter = 1;
            bool spravne = false;

            while (!spravne)
            {
                int guess = generator.Next(numberMin, numberMax);
                Console.WriteLine("Moj tip je {0}", guess);
                string writeSomething = Console.ReadLine();

                bool menej = writeSomething == "menej";
                bool viac = writeSomething == "viac";
                spravne = writeSomething == "spravne";

                if (menej)
                {
                    numberMax = guess;  // nastavenie max hodnoty pre generator              
                }

                if (viac)
                {
                    numberMin = guess; // nastavenie min hodnoty pre generator
                }

                if (spravne)
                {
                    Console.WriteLine("Uhadol som na {0}. pokus", counter);
                    break;
                }

                counter++;
            }

            Console.ReadLine();
        }
    }
}
