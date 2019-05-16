using System;

namespace SpeedRun2hours2
{
    class Factorial
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo z ktoreho chces vypocitat faktorial: ");
            var userInput = int.Parse(Console.ReadLine());
            var result = userInput;

            for (int i = userInput-1; i > 0;  i--)
            {
                result = result * i;
            }

            Console.WriteLine($"{userInput}! je {result}");
        }
    }
}
