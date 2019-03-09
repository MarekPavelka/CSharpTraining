using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student pavel = new Student("Karol", "Novak", 1);
            //Student peter = null;
            //Console.WriteLine(pavel.Name);
            //Console.WriteLine(peter.Name);
            //Student anna = new Student("Jozef", "Vyskocil", 3);
            //pavel.SayHi();
            //anna.SayHi();
            //Console.ReadKey();
            //Console.WriteLine("pavel(4): {0}", pavel.GetRating(4));
            //Auto auto1 = new Auto("Lada", 5, 50);
            //auto1.meno = "Skoda";
            //auto1.DlzkaCesty(100);
            //auto1.WriteInfo();
            //auto1.DlzkaCesty(200);
            //auto1.WriteInfo();
            //Console.WriteLine($"Meno auta je {auto1.meno}");

            Console.WriteLine("Pre spustenie programu stlac enter");
            var keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.Enter)
            {
                var listOfAnimals = new List<Animal>();
                var isRunning = true;

                while (isRunning)
                {
                    Console.Clear();
                    WriteMenu();
                    var selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            Console.Clear();
                            AddAnimal(listOfAnimals);
                            break;
                        case "2":
                            Console.Clear();
                            InfoAboutAnimals(listOfAnimals);
                            Console.ReadLine();
                            break;
                        case "3":
                            var zabijackaCheck = true;
                            while (zabijackaCheck)
                            {
                                Console.Clear();
                                InfoAboutAnimals(listOfAnimals);
                                Console.WriteLine();
                                Console.WriteLine("Ktore zviera chces najebat do gulasu?");
                                var animalToKill = Console.ReadLine();
                                Console.WriteLine("Pre info o mnozstve masa ktore zo zvierata ziskas stlac 1");
                                Console.WriteLine("Pre potvrdenie zabijacky stlac enter");
                                var keySelection = Console.ReadKey(true);
                                if (keySelection.Key == ConsoleKey.Enter)
                                {
                                    RemoveAnimalFromList(listOfAnimals, animalToKill);
                                    zabijackaCheck = false;
                                }

                                if (keySelection.Key == ConsoleKey.D1)
                                {
                                    listOfAnimals[int.Parse(animalToKill) - 1].MeatIGetFromKillingThis();
                                    Console.WriteLine("Chces ho naozaj zaklat? Y/N");
                                    var keySelectionYN = Console.ReadKey(true);
                                    if (keySelectionYN.Key == ConsoleKey.Y)
                                    {
                                        RemoveAnimalFromList(listOfAnimals, animalToKill);
                                        zabijackaCheck = false;
                                    }

                                    if (keySelectionYN.Key == ConsoleKey.N)
                                    {
                                     Console.WriteLine("Budzes hladny");
                                     Console.ReadLine();
                                     break;
                                    }
                                }
                            }
                            break;
                        case "4":
                            isRunning = false;
                            Console.Clear();
                            break;
                    }
                }
            }

            Console.WriteLine("Koniec programu");
            Console.ReadLine();
        }

        private static List<Animal> RemoveAnimalFromList(List<Animal> removedAnimalList, string animalToKill)
        {
            removedAnimalList.RemoveAt(int.Parse(animalToKill) - 1);
            return removedAnimalList;
        }

        private static void InfoAboutAnimals(List<Animal> animalsList)
        {
            var index = 1;
            foreach (var animal in animalsList)
            {
                Console.WriteLine($"{index}. ZVIERA");
                Console.WriteLine($"Meno: {animal.Name}");
                Console.WriteLine($"Vek: {animal.Age}");
                Console.WriteLine($"Vaha: {animal.Weight}");
                Console.WriteLine();
            }
        }

        private static List<Animal> AddAnimal(List<Animal> addedAnimalList)
        {
            var index = 1;
                do
                {
                    Console.WriteLine($"Zadaj meno {index}. zvierata");
                    var meno = Console.ReadLine();
                    Console.WriteLine($"Zadaj vek pre {meno}:");
                    var vek = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Zadaj vahu pre {meno}:");
                    var vaha = int.Parse(Console.ReadLine());
                    addedAnimalList.Add(new Animal(meno, vek, vaha));
                    Console.WriteLine("Pre skoncenie pridavania stlac Enter, pre pokracovanie stlac hocico ine");
                    index++;
                } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            return addedAnimalList;
        }

        private static void WriteMenu()
        {
            
            Console.WriteLine("         ZOO");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Info about all animals");
            Console.WriteLine("3. Delete animal");
            Console.WriteLine("4. EXIT");
            Console.WriteLine();
            Console.WriteLine("Zadaj volbu");
        }

        private static void BlinkingText(string text, ConsoleKeyInfo keyPressed)
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(text);
                        Thread.Sleep(500);
                        break;
                    }
                    ClearCurrentConsoleLine();

                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(text);
                        Thread.Sleep(500);
                        break;
                    }
                    ClearCurrentConsoleLine();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.D1 ||
                     Console.ReadKey(true).Key != ConsoleKey.D2 || 
                     Console.ReadKey(true).Key != ConsoleKey.D3);
        }

        public static void ClearCurrentConsoleLine()
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
}

