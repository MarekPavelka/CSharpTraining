namespace ZlteKarticky
{
    using System;

    class Pokladna
    {
        public static void Run()
        {
            Console.WriteLine("Zadaj vek: ");
            int vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadaj ano/nie si student? ");
            bool isStudent = Console.ReadLine() == "ano";

            Console.WriteLine("Zadaj ano/nie si ztp? ");
            bool isZtp = Console.ReadLine() == "ano";

            var ticketPrice = CalculateTicketPrice(vek, isStudent, isZtp);

            Console.WriteLine("Cena listku je {0}", ticketPrice);
        }

        static int CalculateTicketPrice(int vek, bool isStudent, bool isZtp)
        {
            if (isZtp)
            {
                return 0;
            }

            if (vek <= 7 || vek > 65)
            {
                return 1;
            }

            if (vek < 26 && isStudent)
            {
                return 3;
            }

            return 5;
        }
    }
}
