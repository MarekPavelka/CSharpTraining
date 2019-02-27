using System;

namespace ZlteKarticky
{
    class NacitavanieAut
    {
        public static void Run()
        {
            Console.WriteLine("Zadaj pocet aut: ");
            int pocetAut = int.Parse(Console.ReadLine());

            var cars = NacitajAutaDoPola(pocetAut);
            foreach (var car in cars)
            {
                Console.Write("{0} ", car);
            }
            Console.WriteLine();

            Console.WriteLine("Prve auto bolo: {0}", cars[0]);
            Console.WriteLine("Posledne auto bolo: {0}", cars[cars.Length - 1]);
        }

        private static string[] NacitajAutaDoPola(int pocetAut)
        {
            var cars = new string[pocetAut];

            for (int i = 0; i < pocetAut; i++)
            {
                Console.WriteLine("Zadaj meno {0}. auta: ", i + 1);
                cars[i] = Console.ReadLine();
            }

            return cars;
        }
    }

}
