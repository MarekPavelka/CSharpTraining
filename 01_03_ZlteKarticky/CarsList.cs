using System;

namespace _01_03_ZlteKarticky
{
    class CarsList
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj pocet aut ktore chces pridavat:");
            var arraySize = int.Parse(Console.ReadLine());
            var carList = CarList(arraySize);

            Console.Write("Zoznam vsetkych aut ktore si pridal: ");
            WriteAllCars(carList);
            Console.WriteLine();
            Console.WriteLine("1. auto: {0}", carList[0]);
            Console.WriteLine("Posledne auto: {0}", carList[carList.Length-1]);
        }

        private static void WriteAllCars(string[] carList)
        {
            foreach (var car in carList)
            {
                Console.Write("{0} ", car);
            }
        }

        public static string[] CarList(int arraySize)
        {
            var carList = new string[arraySize];
            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine("Zadaj {0}. auto:", index + 1);
                carList[index] = Console.ReadLine();
            }
            return carList;
        }
    }
}