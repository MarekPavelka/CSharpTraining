using System;

namespace _23_2_BinaryAdittion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1; //new Random().Next(1, 1000);
            int number2 = 2; // new Random().Next(1, 2000);
            var number3 = number1 + number2;
            Console.WriteLine("Cislo 1 ktore som si vymyslel je {0}", number1);
            Console.WriteLine("Cislo 2 ktore som si vymyslel je {0}", number2);
            Console.WriteLine("Sucet tychto cisiel je {0}", number3);
            Console.WriteLine();
            Console.WriteLine("Binarny zapis suctu tychto dvoch cisiel je {0}", AddBinary(number1, number2));
            Console.ReadKey();
        }

        public static string AddBinary(int a, int b)
        {
            double sum = a + b;
            var z = 2;
            var y = 0;
            var power = Math.Pow(z, y); ;
            var binary = "";

            if (sum == 0)
            {
                binary = "0";
            }
            else
            {
                while (sum > power) // najdenie max exponentu
                {
                    y++;
                    power = Math.Pow(z, y);
                }

                while (y >= 0)
                {
                    if (sum >= power)
                    {
                        sum = sum - power;
                        binary = binary + "1";
                        y--;
                    }
                    else
                    {
                        binary = binary + "0";
                        binary = binary == "0" ? "" : "1";
                        y--;
                    }
                    power = Math.Pow(z, y);
                }
            }
            return binary;
        }
    }
}
