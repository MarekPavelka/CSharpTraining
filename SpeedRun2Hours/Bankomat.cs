using System;
using System.Collections.Generic;

namespace SpeedRun2Hours
{
    class Bankomat
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj sumu na vydanie");
            var moneyToGive = int.Parse(Console.ReadLine());
            CalculateMoney(moneyToGive);
        }

        private static void CalculateMoney(int moneyToGive)
        {
            var moneyList = new List<int>() { 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < moneyList.Count; i++)
            {
                while (moneyToGive >= moneyList[i])
                {
                    moneyToGive -= moneyList[i];
                    Console.WriteLine(moneyList[i]);
                }
            }
        }
    }
}
