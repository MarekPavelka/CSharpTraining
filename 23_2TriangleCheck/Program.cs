using System;

namespace _23_2TriangleCheck
{
    class Program
    {
        static void Main()
        {
            var x = new Random().Next(1,20);
            var y = new Random().Next(1,25);
            var z = new Random().Next(1,30);

            Console.WriteLine("3 random priamky su {0}, {1}, {2}\nViem z nich postavit trojuholnik?", x, y, z);
            Console.ReadKey();
            Console.WriteLine(IsTriangle(x,y,z));
            Console.ReadKey();

        }
        public static bool IsTriangle(int a, int b, int c)
        {
            bool triangle = a + b > c && a + c > b && b + c > a ? true : false;
            return triangle;
        }
    }
    
}
