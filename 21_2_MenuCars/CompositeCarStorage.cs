namespace _21_2_MenuCars
{
    using System.Collections.Generic;

    public class CompositeCarStorage : ICarStorage
    {
        private List<ICarStorage> _components;

        public CompositeCarStorage(List<ICarStorage> components)
        {
            _components = components;
        }

        public void Store(Car car)
        {
            foreach (var component in _components)
            {
                component.Store(car);
            }
        }

        public List<Car> GetAllCars()
        {
            // ??? we dont want to return cars "_components.Count" times
            var emptyList = new List<Car>();
            return _components.Count > 0 ? _components[0].GetAllCars() : emptyList;
        }

        public void ReplaceAt(int index, Car newValue)
        {
            foreach (var component in _components)
            {
                component.ReplaceAt(index, newValue);
            }
        }

        public void DeleteAt(int index)
        {
            foreach (var component in _components)
            {
                component.DeleteAt(index);
            }
        }
    }
}