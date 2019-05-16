using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRun2hours2
{
    class Bankomat
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj sumu na vydanie: ");
            var suma = int.Parse(Console.ReadLine());
            var listOfCoins = new List<int>() {50, 20, 10, 5, 2, 1};

            foreach (var item in ReturnedList(listOfCoins, suma))
            {
                Console.WriteLine(item);    
            }
        }

        private static List<int> ReturnedList(List<int> listOfCoins, int suma)
        {
            var returnedList = new List<int>();
            for (int i = 0; i < listOfCoins.Count; i++)
            {
                while (suma >= listOfCoins[i])
                {
                    suma = suma - listOfCoins[i];
                    returnedList.Add(listOfCoins[i]);
                }
            }

            if (returnedList.Any())
            {
                return returnedList;
            }
            else throw new ArgumentException("Wrong amount of money to give");
        }
    }
}
