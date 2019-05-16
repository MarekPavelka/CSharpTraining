using System;
using System.Linq;

namespace SpeedRun2hours2
{
    class ArrayExercise
    {
        public static void Solution()
        {
            Console.WriteLine("Write the number of cars u want to add:");
            var numberOfCars = int.Parse(Console.ReadLine());
            var arrayOfCars = new string[numberOfCars];

            for (int i = 0; i < arrayOfCars.Length; i++)
            {
                Console.WriteLine($"Zadaj meno {i+1}. auta");
                arrayOfCars[i] = Console.ReadLine();
            }

            Console.WriteLine("Zadal si tieto auta:");
            foreach (var car in arrayOfCars)
            {
                Console.Write($"{car} ");
                Console.WriteLine();
            }

            Console.WriteLine($"Prve auto bolo {arrayOfCars.First()}");
            Console.WriteLine($"Posledne auto bolo {arrayOfCars.Last()}");
        }
    }
}
