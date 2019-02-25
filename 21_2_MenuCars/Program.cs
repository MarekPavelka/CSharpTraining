
namespace _21_2_MenuCars
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            // classy
            // var carName = "audi";
            // var car1 = new Car(carName);
            // var car2 = new Car("bmw");
            // List<Car> list = new List<Car>();
            // list.Add(car1);
            // list.Add(car2);
            // list.Remove(car1);
            // classy end  

            ICarStorage carStorage = new FileCarStorage("storage.txt");

            // IList<int> list = new List<int>();

            var selection = 0;

            while (selection != 5)
            {
                Console.Clear();
                Menu();
                selection = int.Parse(Console.ReadLine()); // pocka na volbu

                switch (selection)
                {
                    case 1:
                        AddCar(carStorage); // add car
                        break;
                    case 2:
                        ShowCarList(carStorage); // show car list
                        Console.WriteLine("Pre navrat stlac any key");
                        Console.ReadKey();
                        break;
                    case 3: // rename car
                        RenameCar(carStorage);
                        break;
                    case 4: // remove car
                        RemoveCar(carStorage);
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

        static void ShowCarList(ICarStorage carListXY) // vypisanie listu
        {
            var allCars = carListXY.GetAllCars();

            for (int index = 0; index < allCars.Count; index++)
            {
                var car = allCars[index];
                Console.WriteLine(" {0}. {1} ", index + 1, car.Name);
            }
        }

        static void AddCar(ICarStorage carListXY) // pridavania aut do listu
        {
            Console.WriteLine("Pre ukoncenie pridavania napis \"done\"");
            Console.WriteLine();
            var carName = "";

            for (int carNumber = 1; carName != "done"; carNumber++)
            {
                Console.WriteLine("Zadaj {0}. auto:", carNumber);
                carName = Console.ReadLine();
                if (carName != "done")
                {
                    var newCar = new Car(carName);
                    carListXY.Store(newCar);
                }
            }
        }

        static void RenameCar(ICarStorage carListXY)
        {
            ShowCarList(carListXY);
            Console.WriteLine("Zadaj cislo auta ktore chces premenovat: ");
            var index = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Zadaj nove meno auta:");
            var newCarName = Console.ReadLine();
            var newCar = new Car(newCarName);
            carListXY.ReplaceAt(index - 1, newCar);
            //carListXY.RemoveAt(index - 1);
            //carListXY.Insert(index - 1, newCar);
            Console.WriteLine("Pre navrat stlac any key");
            Console.ReadKey();
        }

        static void RemoveCar(ICarStorage removedCarListXY)
        {
            ShowCarList(removedCarListXY);
            Console.WriteLine("Zadaj cislo auta ktore chces zmazat: ");
            var index = int.Parse(Console.ReadLine());
            removedCarListXY.DeleteAt(index - 1);
        }
    }
}
