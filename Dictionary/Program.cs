using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            var car1 = new Car("audi", "BA25522");
            var car2 = new Car("skoda", "NR12233");
            var car3 = new Car("bmw", "KE66688");

            cars.Add(car1.SPZ, car1);
            cars.Add(car2.SPZ, car2);
            cars.Add(car3.SPZ, car3);

            Console.WriteLine("Enter SPZ of car u wanna find: ");
            var spz = Console.ReadLine();
            if (cars.ContainsKey(spz))
            {
                Console.WriteLine($"Car with this SPZ is: {cars[spz].NameOfCar}");
            }
            Console.WriteLine("Cars not found");

            Console.Write("Do you want to see full list of cars in database? Y/N: ");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                foreach (var car in cars.Values)
                {
                    Console.WriteLine($"SPZ = {car.SPZ}, TYPE = {car.NameOfCar}");
                }
            }
            throw new Exception("Fico je najlepsi");
            Console.ReadLine();
        }
    }

    class Car
    {
        public string NameOfCar { get; set; }
        public string SPZ { get; set; }

        public Car(string nameofcar, string spz)
        {
            NameOfCar = nameofcar;
            SPZ = spz;
        }
    }
}
