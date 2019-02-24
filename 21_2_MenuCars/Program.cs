using System;
using System.Collections.Generic;

namespace _21_2_MenuCars
{
    class Program
    {
        public static void Main()
        {
            //classy
            var carName = "audi";
            var car1 = new Car(carName);
            var car2 = new Car("bmw");
            List<Car> list = new List<Car>();
            list.Add(car1);
            list.Add(car2);
            list.Remove(car1);

            // classy end  

            var carList = new List<string>();
            var selection = 0;

            while (selection != 5)
            {
                Console.Clear();
                Menu();
                selection = int.Parse(Console.ReadLine()); // pocka na volbu

                switch (selection)
                {
                    case 1:
                        AddCar(carList); // add car
                        break;
                    case 2:
                        ShowCarList(carList); // show car list
                        Console.WriteLine("Pre navrat stlac any key");
                        Console.ReadKey();
                        break;
                    case 3: // rename car
                        RenameCar(carList);
                        break;
                    case 4: // remove car
                        RemoveCar(carList);
                        break;
                    case 5:
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Koniec programu");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("     MENU\n\n1. Pridat Auto\n2. Zobrazit Auta\n3. Premenovat Auto\n4. Zmazat Auto\n5. Koniec");
        }

        static void ShowCarList(List<string> carListXY) // vypisanie listu
        {
            for (int index = 0; index < carListXY.Count; index++)
            {
                Console.WriteLine(" {0}. {1} ", index + 1, carListXY[index]);
            }
        }

        static void AddCar(List<string> addedCarListXY) // pridavania aut do listu
        {
            Console.WriteLine("Pre ukoncenie pridavania napis \"done\"");
            Console.WriteLine();
            var writeSomething = "";

            for (int carNumber = 1; writeSomething != "done"; carNumber++)
            {
                Console.WriteLine("Zadaj {0}. auto:", carNumber);
                writeSomething = Console.ReadLine();
                if (writeSomething != "done")
                {
                    addedCarListXY.Add(writeSomething); // pridas auto do listu
                }
            }
        }

        static void RenameCar(List<string> carListXY)
        {
            ShowCarList(carListXY);
            Console.WriteLine("Zadaj cislo auta ktore chces premenovat: ");
            var index = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Zadaj nove meno auta:");
            carListXY[index - 1] = Console.ReadLine();
            Console.WriteLine("Pre navrat stlac any key");
            Console.ReadKey();
        }

        static void RemoveCar(List<string> removedCarListXY)
        {
            ShowCarList(removedCarListXY);
            Console.WriteLine("Zadaj cislo auta ktore chces zmazat: ");
            var index = int.Parse(Console.ReadLine());
            removedCarListXY.RemoveAt(index - 1);
        }

    }
}
