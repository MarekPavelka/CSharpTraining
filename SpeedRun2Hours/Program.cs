using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRun2Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokladna.Solution();
            //GuessNumber.Solution();
            //Bankomat.Solution();
            Factorial.Solution();
            Console.ReadLine();
        }
    }

    class Factorial
    {
        public static void Solution()
        {
            Console.WriteLine("Zadaj cislo z ktoreho chces vypocitat faktorial:");
            var factorialNumber = int.Parse(Console.ReadLine());
            var result = factorialNumber;
            for (int i = factorialNumber-1; i > 1; i--)
            {
                result =  result * i;

            }
            Console.WriteLine(result);
        }
    }
}
