using System;
using System.Collections.Generic;

namespace _20_2_Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj pocet aut:");
            var carsNumberTotal = int.Parse(Console.ReadLine());
            var listOfCars = new List<string>();

            for (int carNumber = 1; carNumber <= carsNumberTotal; carNumber++)
            {
                Console.WriteLine("Zadaj {0}. auto", carNumber);
                listOfCars.Add(Console.ReadLine());
            }

            Console.Write("Zadal si: ");
            foreach (var itemInListOfCars in listOfCars)
            {
                Console.Write("{0}, ", itemInListOfCars);
            }

            Console.WriteLine();
            Console.WriteLine("Vyber si cislom v poradi ktore auto si chces kupit?");

            var numberSelected = int.Parse(Console.ReadLine());
            if (numberSelected < carsNumberTotal && numberSelected > 0)
            {
                var selectedCar = listOfCars[numberSelected - 1];
                Console.WriteLine("Auto ktore si chces kupit je {0}!", selectedCar);
            }
            Console.ReadKey();
        }
    }
}
