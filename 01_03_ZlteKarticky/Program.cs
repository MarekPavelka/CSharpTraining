using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _01_03_ZlteKarticky
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Pokladna.Solution();
            //GuessNumber.Solution();
            //Bankomat.Solution();
            //Factorial.Solution();
            //Fibonacci.Solution();
            //GuessNumberFromUser.Solution();
            //CarsList.Solution();
            //ArrayReverse.Solution();
            Menu.Solution();

            Console.ReadLine();
        }
    }

    class Menu
    {
        public static void Solution()
        {
            var carList = new List<string>();
            var isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                WriteMenu();
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        ShowCars(carList);
                        AddCar(carList);
                        break;

                    case "2":
                        Console.Clear();
                        ShowCars(carList);
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        ShowCars(carList);
                        RenameCar(carList);
                        break;

                    case "4":
                        Console.Clear();
                        ShowCars(carList);
                        DeleteCar(carList);
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opakuj volbu");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static List<string> DeleteCar(List<string> listOfCars)
        {
            Console.WriteLine("Zadaj cislo auta ktore chces zmazat:");
            listOfCars.RemoveAt(int.Parse(Console.ReadLine()) - 1);
            return listOfCars;
        }

        private static List<string> RenameCar(List<string> listOfCars)
        {
            Console.WriteLine("Zadaj cislo auta ktore chces premenovat:");
            var numberOfCar = int.Parse(Console.ReadLine()) - 1;
            listOfCars.RemoveAt(numberOfCar);
            Console.WriteLine("Zadaj nove meno auta:");
            listOfCars.Insert(numberOfCar, Console.ReadLine());
            return listOfCars;
        }

        private static void ShowCars(List<string> listOfCars)
        {
            var index = 1;
            foreach (var car in listOfCars)
            {
                Console.WriteLine("{0}. {1}", index, car);
                index++;
            }
        }

        private static List<string> AddCar(List<string> listOfCars)
        {
            Console.WriteLine("Pre skoncenie pridavania napis exit");
            Console.WriteLine();
            while(true)
            {
                Console.WriteLine("Zadaj meno {0}. auta:", listOfCars.Count+1);
                var car = Console.ReadLine();
                if (car == "exit")
                {
                    return listOfCars;
                }
                listOfCars.Add(car);
            }
        }

        private static void WriteMenu()
        {
            Console.WriteLine("      Menu");
            Console.WriteLine();
            Console.WriteLine("1. Pridat Auto");
            Console.WriteLine("2. Zobrazit Auta");
            Console.WriteLine("3. Premenovat Auto");
            Console.WriteLine("4. Zmazat Auto");
            Console.WriteLine("5. Koniec");
        }

    }
}
