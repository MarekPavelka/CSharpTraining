using System;

namespace _20_2_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj dolnu hranicu intervalu:");
            var minValueInterval = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj hornu hranicu intervalu:");
            var maxValueInterval = int.Parse(Console.ReadLine());

            var sizeOfArray = (maxValueInterval - minValueInterval) + 1;

            int[] arrayIntNumbers = new int[sizeOfArray];

            for (int arrayIndex = 0; arrayIndex < sizeOfArray; arrayIndex++)
            {
                arrayIntNumbers[arrayIndex] = minValueInterval;
                minValueInterval++;
            }

            foreach (var itemArrayIntNumber in arrayIntNumbers)
            {
                if (itemArrayIntNumber % 3 == 0)
                {
                    Console.Write("{0}; ", itemArrayIntNumber);
                }
            }
            Console.ReadLine();
        }
    }
}
