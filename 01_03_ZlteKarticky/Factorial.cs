using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace _01_03_ZlteKarticky
{
    class Factorial
    {
        public static void Solution()
        {
        //Console.WriteLine("Zadaj cislo pre vypocet faktorialu:");
        //var userInput = int.Parse(Console.ReadLine());
        //Console.Write("{0}! je ", userInput);
        //Solve(userInput);

        var car1 = new Car("bmw");
        Console.WriteLine(car1.Name);
        Console.ReadLine();
        List<Car> list = new List<Car>();
        }

        public static void Solve(int userInput)
        {
            for (int i = userInput; i > 0; i--)
            {
                Console.Write("{0} ", i);
            }
        }
    }

    public class Car
    {
        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }
    }
}
