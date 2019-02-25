using System.Collections.Generic;

namespace _21_2_MenuCars
{
    using System;
    using System.IO;
    using System.Linq;

    // bude ukladat auta do fileu
    public class FileCarStorage : ICarStorage
    {
        private string _pathToFile;

        public FileCarStorage(string filePath)
        {
            _pathToFile = filePath;
        }

        //string[] lines = File.ReadAllLines("path to file");
        //File.WriteAllLines("path to file", new string[] { "line1", "line2"});
        //var fileExits = File.Exists("path to file");

        public void Store(Car car)
        {
            // TODO: check if newline is automatically added

            File.AppendAllText(_pathToFile, car.Name + Environment.NewLine);
            // File.AppendAllLines(_pathToFile, new[] { car.Name });
        }

        public List<Car> GetAllCars()
        {
            string[] fileContents = File.ReadAllLines(_pathToFile);

            // carNames -> cars
            var carList = new List<Car>();
            foreach (string carName in fileContents)
            {
                var car = new Car(carName);
                carList.Add(car);
            }

            return carList;
        }

        public void ReplaceAt(int index, Car newValue)
        {
            var carList = GetAllCars();
            carList.RemoveAt(index);
            carList.Insert(index, newValue);
            WriteAllCarsToFile(carList);
        }

        public void DeleteAt(int index)
        {
            var carList = GetAllCars();
            carList.RemoveAt(index);
            WriteAllCarsToFile(carList);
        }

        private void WriteAllCarsToFile(List<Car> cars)
        {
            // cars -> carNames
            var carNames = new List<string>();
            foreach (var car in cars)
            {
                carNames.Add(car.Name);
            }

            // write carNames back to file
            // TODO: check if overwrites the file
            File.WriteAllLines(_pathToFile, carNames);
        }
    }
}