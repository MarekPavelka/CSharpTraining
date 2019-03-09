using System;

namespace _08_03_Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void MeatIGetFromKillingThis()
        {
            var amount = Weight / 4;
            Console.WriteLine($"Ked {Name} zarezes ziskas {amount} kg masa na gulas");
        }
    }
}