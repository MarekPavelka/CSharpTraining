using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _02_03_ZlteKarticky
{
    class Program
    {
        static void Main()
        {
            //Pokladna.Solution();
            //HadajCislo.Solution();
            //Vydavac.Solution();
            //Factorial.Solution();
            //Fibonacci.Solution();
            //UserGuessNumber.Solution();
            //ArrayOfCars.Solution()
            ArrayReverse.Solution();
        }
    }

    internal class ArrayReverse
    {
        public static void Solution()
        {
            Console.WriteLine("Zadavaj cisla ktore si mam pamatat, pre skoncenie napis koniec");
            var List1 = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "koniec")
                {
                    break;
                }

                List1.Add(input);
            }

            Reverse(List1);


            Console.WriteLine("Cisla ktore si zadal su: {0}", string.Join(" ", List1));

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Chces ich obratit? ano/nie");
                var reverse = Console.ReadLine();
                
                if (reverse == "ano")
                {
                    foreach (var cislo in Reverse(List1))
                    {
                        Console.Write("{0} ", cislo);
                    }
                }

                if (reverse == "nie")
                {
                    Console.WriteLine("tak chod do rici!");
                    break;
                }
            }
            Console.ReadKey();
        }

        public static List<string> Reverse(List<string> List1)
        {
            var x = List1.Count;
            for (int i = x-1; i >= 0; i--)
            {
                List1.Add(List1[i]);
            }
            List1.RemoveRange(0, x);
            return List1;
        }
    }
}
