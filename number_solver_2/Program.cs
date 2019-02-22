using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mysli si cislo od 1 do 100, ja idem hadat na co myslis");

            int numberMin = 1;
            int numberMax = 100;
            int counter = 1;
            bool spravne = false;

            while (!spravne)
            {
                int stred = (numberMax - numberMin) / 2 + numberMin;
                Console.WriteLine("Moj tip je {0}", stred);
                string writeSomething = Console.ReadLine();

                bool menej = writeSomething == "menej";
                bool viac = writeSomething == "viac";
                spravne = writeSomething == "spravne";

                if (menej)
                {
                    numberMax = stred;  // nastavenie max hodnoty pre generator              
                }

                if (viac)
                {
                    numberMin = stred; // nastavenie min hodnoty pre generator
                }

                if (spravne)
                {
                    Console.WriteLine("Uhadol som na {0}. pokus", counter);
                }

                counter++;
            }

            Console.ReadLine();
        }
    }
}
