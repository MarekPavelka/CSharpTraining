using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24_2SmileyCounter2
{
    class Program
    {
        static void Main()
        {
            var listSmajlikov = new List<string>(){""};
            Console.WriteLine("Smajliky ktore poznam su :) :D ;) ;D :-) ;-) :-D ;-D");
            Console.WriteLine();
            Console.WriteLine("Postupne zadavaj smajlikov, pre ukoncenie napis koniec:");

            for (int counter = 0; listSmajlikov[counter] != "koniec"; counter++)
            {
                Console.WriteLine("Zadaj {0}. smajlika a potvrd enterom", counter+1);
                listSmajlikov.Add(Console.ReadLine());
            }
            Console.WriteLine("Naratal som {0} smajlikov ktore poznam", CountSmileys(listSmajlikov));
            Console.ReadKey();
        }

        public static int CountSmileys(List<string> smileys)
        {
            Regex containsSmile = new Regex("[:;][-~]?[)D]");
            int count = 0;
            foreach (string smile in smileys)
            {
                if (containsSmile.IsMatch(smile))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
