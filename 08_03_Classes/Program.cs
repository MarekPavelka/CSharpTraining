using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _08_03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student pavel = new Student("Karol", "Novak", 1);
            //Student peter = new Student("Jana", "Sprosta", 2);
            //Student anna = new Student("Jozef", "Vyskocil", 3);
            //pavel.SayHi();
            //anna.SayHi();
            //Console.ReadKey();
            //Console.WriteLine("pavel(4): {0}", pavel.GetRating(4));
            Auto auto1 = new Auto("Lada", 5, 50);
            auto1.meno = "Skoda";
            auto1.DlzkaCesty(100);
            auto1.WriteInfo();
            auto1.DlzkaCesty(200);
            auto1.WriteInfo();
            Console.WriteLine($"Meno auta je {auto1.meno}");
            Console.ReadKey();

        }
    }
}
