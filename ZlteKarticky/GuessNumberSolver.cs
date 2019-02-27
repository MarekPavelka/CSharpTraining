using System;

namespace ZlteKarticky
{
    class GuessNumberSolver
    {
        public static void Run()
        {
            var introText = "Mysli si cislo od 1-100, ja budem hadat," + Environment.NewLine +
                            "ty mi odpovies 'viac', 'menej', alebo 'spravne'." + Environment.NewLine +
                            "Ked budes mat stlac enter.";

            Console.WriteLine(introText);
            Console.ReadLine();

            int min = 1;
            int max = 100;
            int guessNo = 0;

            bool isGameRunning = true;
            while (isGameRunning)
            {
                guessNo++;
                int myGuess = MyNextOptimalGuess(min, max);
                Console.WriteLine("Hadam cislo {0}", myGuess);
                var userFeedback = Console.ReadLine();

                switch (userFeedback)
                {
                    case "menej":
                        max = myGuess;
                        break;

                    case "viac":
                        min = myGuess;
                        break;

                    default: // "spravne" & garbage
                        isGameRunning = false;
                        Console.Write("Uhadol som na {0}. pokus", guessNo);
                        break;
                }
            }
        }

        static int MyNextOptimalGuess(int intervalStart, int intervalEnd)
        {
            var intervalLength = intervalEnd - intervalStart;
            var intervalMid = intervalLength / 2 + intervalStart;

            return intervalMid;
        }
    }
}
