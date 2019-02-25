namespace _21_2_MenuCars
{
    using System.Collections.Generic;

    // Contract
    public interface ICarStorage
    {
        void Store(Car car);
        List<Car> GetAllCars();
        void ReplaceAt(int index, Car newValue);
        void DeleteAt(int index);
    }
}