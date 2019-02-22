//namespace ClassCar
//{
//    // class definition
//    public class Car
//    {
//        // constructor
//        public Car(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }

//        public string Name { get; set; }
//        public int Age { get; }
//    }

//    // Usage
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car cc = new Car("audi", 17);

//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace ClassCar
{
    static class Program
    {
        static void Main()
        {
            var cars = new List<string> {"audi", "bmw"};


            Console.ReadKey();
        }

        private static List<string> RemoveEverythingFromList(List<string> carList)
        {
            carList.Clear();
            return carList;
        }
    }

}
