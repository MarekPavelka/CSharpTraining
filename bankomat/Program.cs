using System;

namespace bankomat
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadaj sumu na vydanie");
            int suma = int.Parse(Console.ReadLine());
            Console.WriteLine("Vysledne bankovky su tieto: {0}", Funkcia(suma));
            Console.ReadLine();

        }

        private static string Funkcia(int zostatok)
        {
            var bankovky = new[] { 50, 20, 10, 5, 2, 1 };
            string z = null;

            foreach (int bankovka in bankovky)
            {
                while (bankovka <= zostatok)
                {
                    zostatok = zostatok - bankovka;
                    z = z + " " + bankovka;
                }
            }

            return z;
        }
    }
}
