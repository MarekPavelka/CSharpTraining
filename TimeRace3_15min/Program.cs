using System;

namespace TimeRace3_15min
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadaj pocet aut");
            var carCount = int.Parse(Console.ReadLine());
            string[] arrayOfCars = new string[carCount];

            for (int number = 0; number < carCount; number++)
            {
                Console.WriteLine("Zadaj {0}. auto:", number + 1);
                arrayOfCars[number] = Console.ReadLine();
            }
            Console.Write("Zadal si tieto auta:");
            foreach (var item in arrayOfCars)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine("");
            Console.WriteLine("Prve auto:{0}", arrayOfCars[0]);
            Console.WriteLine("Posledne auto je:{0}", arrayOfCars[arrayOfCars.Length - 1]);

            Console.ReadKey();
        }
    }
}
