using System;

namespace ZlteKarticky
{
    using System.Collections.Generic;

    class MenuAuta
    {
        public static void Run()
        {
            var cars = new List<string>();

            while (true) // run forever
            {
                Console.Clear();
                PrintMenu();
                var userChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (userChoice)
                {
                    case 1:
                        AddNewCar(cars);
                        break;
                    case 2:
                        PrintAllCars(cars);
                        Console.WriteLine("Stlac enter pre navrat do hlavneho menu...");
                        Console.ReadLine();
                        break;
                    case 3:
                        RenameCar(cars);
                        break;
                    case 4:
                        DeleteCar(cars);
                        break;
                    default: return; // 5 & garbage -> exit
                }
            }
        }

        private static void DeleteCar(List<string> cars)
        {
            PrintCarsForAction(cars, "vymazanie");
            var carToRenameId = int.Parse(Console.ReadLine());
            cars.RemoveAt(carToRenameId - 1);
        }

        private static void RenameCar(List<string> cars)
        {
            PrintCarsForAction(cars, "premenovanie");
            var carToRenameId = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj nove meno auta: ");
            cars[carToRenameId - 1] = Console.ReadLine();
        }

        private static void PrintCarsForAction(List<string> cars, string actionName)
        {
            PrintAllCars(cars);
            Console.WriteLine("Zadaj cislo auta pre {0}: ", actionName);
        }

        private static void PrintAllCars(List<string> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine("{0}. {1}", cars.IndexOf(car) + 1, car);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Add a new car");
            Console.WriteLine("2. Print all cars");
            Console.WriteLine("3. Rename a car");
            Console.WriteLine("4. Delete a car");
            Console.WriteLine("5. Exit");
        }

        private static void AddNewCar(List<string> cars)
        {
            Console.WriteLine("Zadaj meno noveho auta: ");
            var newCar = Console.ReadLine();
            cars.Add(newCar);
        }
    }
}
