using System;

namespace TimeRace2_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vymysli si cisielko od 1 do 100, ja budem hadat, ked mas stlac random klaves");
            Console.ReadKey();

            var intervalMax = 100;
            var intervalMin = 1;
            string writeSomething;
            var counter = 0;

            while (true)
            {
                counter++;

                var intervalSolver = (intervalMax - intervalMin) / 2 + intervalMin;
                Console.WriteLine("{0}", intervalSolver);
                writeSomething = Console.ReadLine();

                if (writeSomething == "menej")
                {
                    intervalMax = intervalSolver;
                }

                if (writeSomething == "viac")
                {
                    intervalMin = intervalSolver;
                }

                if (writeSomething == "spravne")
                {
                    Console.WriteLine("Uhadol som na {0}. pokus", counter);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
