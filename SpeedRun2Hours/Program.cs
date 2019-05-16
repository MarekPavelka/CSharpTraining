using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
            //Factorial.Solution();
            //FactorialRecursive.Solution();
            Fibonacci.Solution();
            //PCGuessNumber.Solution();
            //CarArray.Solution();
            //ReverseArray.Solution();
            //Menu.Solution();

            Console.ReadLine();
        }
    }

    class Car
    {
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public int CarWeight { get; set; }

        public Car(string carName, string carColor, int carWeight)
        {
            CarName = carName;
            CarColor = carColor;
            CarWeight = carWeight;
        }
    }

    class Menu
    {
        public static void Solution()
        {
            var selection = "";
            var carList = new List<Car>();

            while (selection != "5")
            {
                WriteMenu();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.Clear();
                        AddCar(carList);
                        Return();
                        break;

                    case "2":
                        Console.Clear();
                        ShowCars(carList);
                        Return();
                        break;

                    case "3":
                        Console.Clear();
                        ShowCars(carList);
                        Console.WriteLine();
                        RenameCar(carList);
                        Return();
                        break;

                    case "4":
                        Console.Clear();
                        ShowCars(carList);
                        Console.WriteLine();
                        DeleteCar(carList);
                        Return();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Koniec programu");
                        break;
                }
            }
        }

        private static List<Car> DeleteCar(List<Car> carList)
        {
            Console.WriteLine("Write the number of Car u want to delete: ");
            int carToDelete = int.Parse(Console.ReadLine());
            carList.RemoveAt(carToDelete - 1);
            return carList;
        }

        private static void RenameCar(List<Car> list)
        {
            Console.WriteLine("Write the name of the Car which u wanna rename: ");
            var oldCarName = Console.ReadLine();
            var index = list.IndexOf(list.Where(car => car.CarName == oldCarName).FirstOrDefault());
            Console.WriteLine("Write the new name of the Car: ");
            var newCarName = Console.ReadLine();
            list[index].CarName = newCarName;
        }

        private static void ShowCars(List<Car> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.CarName}, {item.CarColor}, {item.CarWeight}");
            }
        }

        private static void Return()
        {
            Console.WriteLine();
            Console.WriteLine("For return to menu hit backspace button");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        private static List<Car> AddCar(List<Car> carList)
        {
            Console.WriteLine("Enter the new Car name: ");
            var carname = Console.ReadLine();
            Console.WriteLine("Enter the new Car color: ");
            var carcolor = Console.ReadLine();
            Console.WriteLine("Enter the new Car weight: ");
            var carweight = int.Parse(Console.ReadLine());
            carList.Add(new Car(carname, carcolor, carweight));
            return carList;
        }

        private static void WriteMenu()
        {
            Console.WriteLine("    Menu");
            Console.WriteLine();
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Show Cars");
            Console.WriteLine("3. Rename Car");
            Console.WriteLine("4. Delete Car");
            Console.WriteLine("5. End");
            Console.WriteLine();
            Console.WriteLine("Zadaj svoju volbu");
        }
    }
}
