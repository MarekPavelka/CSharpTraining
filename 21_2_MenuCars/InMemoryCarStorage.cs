using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_MenuCars
{
    class InMemoryCarStorage : ICarStorage
    {
        private List<Car> _list = new List<Car>();

        public void Storage(Car car)
        {
            _list.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return _list.ToList();
        }

        public void ReplaceAt(int index, Car newValue)
        {
            _list.RemoveAt(index);
            _list.Insert(index, newValue);
        }

        public void DeleteAt(int index)
        {
            _list.RemoveAt(index);
        }
    }
}
