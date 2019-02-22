using System;
using System.Collections.Generic;


namespace _20_2_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Postupne zadavaj mena STARYCH zamestnancov, pre skoncenie napis JBMNT");

            var originalEmployees = EmployeesList(); // viem naplnit obsah list {ferko, jozko atd.} z funkcie?

            Console.WriteLine("Postupne zadaj mena NOVYCH zamestnancov; pre skoncenie napis JBMNT");

            var newEmployees = EmployeesList();

            var sumEmployees = new List<string>();
            sumEmployees.AddRange(originalEmployees);
            sumEmployees.AddRange(newEmployees);

            var lastElement = sumEmployees[sumEmployees.Count - 1]; //pri poslednom mene necem vypisat ciarku za nim
            var numberOfElements = sumEmployees.Count; //pri poslednom mene necem vypisat ciarku za nim

            for (int z = 0; z < numberOfElements - 1; z++) //pri poslednom mene necem vypisat ciarku za nim
            {

                var itemSumEmployees = sumEmployees[z];
                Console.Write("{0}, ", itemSumEmployees);
            }
            Console.WriteLine("{0}", lastElement);
            Console.ReadKey();
        }
        
        static List<string> EmployeesList()
        {
            var eployees = new List<string>();
            while (true)
            {
                var userInput = Console.ReadLine();
                bool shouldEnd = userInput == "JBMNT";

                if (shouldEnd)
                {
                    break;
                }
                eployees.Add(userInput);
            }
            return eployees;
        }
    }
}
