namespace _21_2_MenuCars
{
    using System.Linq;
    using System.Collections.Generic;

    public class InMemoryCarStorage : ICarStorage
    {
        private List<Car> _list = new List<Car>();

        public void Store(Car car)
        {
            _list.Add(car);
        }

        public List<Car> GetAllCars()
        {
            // return a copy of the list, to not allow 'public'
            // to modify our private list (thus breaking encapsulation)
            return _list.ToList();
        }

        public void DeleteAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void ReplaceAt(int index, Car newValue)
        {
            _list.RemoveAt(index);
            _list.Insert(index, newValue);
        }
    }
}