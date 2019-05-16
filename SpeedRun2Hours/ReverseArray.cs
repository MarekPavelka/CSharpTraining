using System;
using System.Collections.Generic;

namespace SpeedRun2Hours
{
    class ReverseArray
    {
        public static void Solution()
        {
            Console.WriteLine("Postupne Zadavaj cisla ktore chces pridat do arrayu, pre skoncenie napis \"enter\"");
            var listOfNumbers = new List<string>();
            string input = "";
            
            while (input != "enter")
            {
                input = Console.ReadLine();
                if (input != "enter")
                {
                    listOfNumbers.Add(input);
                }
            }

            Console.WriteLine("Array ktory si zadal je: ");
            foreach (var item in listOfNumbers)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadLine();
            Console.WriteLine("Obrateny array je: ");
            foreach (var item in ReverseArrayMethod(listOfNumbers))
            {
                Console.Write($"{item}, ");
            }
        }

        private static List<string> ReverseArrayMethod(List<string> list)
        {
            var reversedList = new List<string>();

            for (int i = list.Count-1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }

            return reversedList;
        }
    }
}
