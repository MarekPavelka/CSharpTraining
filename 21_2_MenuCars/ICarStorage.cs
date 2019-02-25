using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_MenuCars
{
    interface ICarStorage
    {
        void Storage(Car car);
        List<Car> GetAllCars();
        void ReplaceAt(int index, Car newValue);
        void DeleteAt(int index);
    }
}
