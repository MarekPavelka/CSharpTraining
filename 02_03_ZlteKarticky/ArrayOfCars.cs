using System;

namespace _02_03_ZlteKarticky
{
    class ArrayOfCars
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj pocet aut ktore chces pridat");
            var numberCars = int.Parse(Console.ReadLine());
            var carList = new string[numberCars];
            var updateCarList = UpdateCarList(carList, numberCars);

            Console.Write("Zadal si tieto auta:");
            foreach (var car in updateCarList)
            {
                Console.Write(" {0}", car);
            }
            Console.WriteLine();
            Console.WriteLine("Prve auto bolo: {0}", updateCarList[0]);
            Console.WriteLine("Posledne auto bolo: {0}", updateCarList[numberCars-1]);
            Console.ReadKey();
        }

        private static string[] UpdateCarList(string[] carList, int numberCars)
        {
            for (int i = 1; i <= numberCars; i++)
            {
                Console.WriteLine("Zadaj meno {0}. auta", i);
                carList[i - 1] = Console.ReadLine();
            }

            return carList;
        }
    }
}