using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRun2hours2
{
    class Program
    {
        static void Main()
        {
            //Pokladna.Solution();
            //GuessNumber.Solution();
            //Bankomat.Solution();
            //Factorial.Solution();
            //FactorialRecursive.Solution();
            //Fibonacci.Solution();
            //GuessNumberSolver.Solution();
            //ArrayExercise.Solution();
            ArrayReverse.Solution();


            Console.ReadLine();
        }
    }

    class ArrayReverse
    {
        public static void Solution()
        {
            Console.WriteLine("Give me numbers separated with \",\"");
            var userInput = Console.ReadLine().Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var trimmedUserInput = Trim(userInput);
            Console.WriteLine("U gave me this array of numbers: ");
            foreach (var number in trimmedUserInput)
            {
                Console.Write($"{number} ");
            }

            Console.ReadLine();
            Console.WriteLine("And this is how it is reversed: ");
            foreach (var number in Reversed(trimmedUserInput))
            {
                Console.Write($"{number} ");
            }

        }

        private static List<string> Reversed(List<string> trimmedUserInput)
        {
            var reversedList = new List<string>();
            for (int i = trimmedUserInput.Count-1; i >= 0; i--)
            {
                reversedList.Add(trimmedUserInput[i]);
            }

            return reversedList;
        }

        private static List<string> Trim(List<string> list)
        {
            
            foreach (var item in list)
            {
                    item.Replace(" ", String.Empty);
            }
            return list;
        }
    }
}
