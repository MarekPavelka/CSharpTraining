using System;
using System.Linq;

namespace SpeedRun2Hours
{
    class CarArray
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj pocet aut: ");
            var numberOfCars = int.Parse(Console.ReadLine());
            var arrayOfCars = new string [numberOfCars];

            for (int i = 1; i <= numberOfCars; i++)
            {
                Console.WriteLine($"Zadaj meno {i}. auta:");
                arrayOfCars[i - 1] = Console.ReadLine();
            }

            Console.Write("Zadal si: ");
            foreach (var item in arrayOfCars)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
            Console.WriteLine($"Prve auto je {arrayOfCars.First()}");
            Console.WriteLine($"Posledne auto je {arrayOfCars.Last()}");
        }
    }
}
