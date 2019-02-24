using System;
using System.Collections.Specialized;

namespace _23_2SmileyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rules for a smiling face:
            -Each smiley face must contain a valid pair of eyes.Eyes can be marked as : or;
            -A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
            -Every smiling face must have a smiling mouth that should be marked with either) or D.*/

            var feeder = new[] { ":", ".", ")", ";", "~", "D",":","-",")","]","-",";",")",":","]" };
            var numberOfSmileys = ReturnSmiley(feeder);
            Console.WriteLine("Pocet smajlikov som naratal {0}", numberOfSmileys);
            Console.ReadKey();
        }
        static int ReturnSmiley(string[] smileys)
        {
            var index = 0;
            var output = 0; 

            while (index < smileys.Length)
            {
                if (smileys[index] == ":" || smileys[index] == ";")
                {
                    if (smileys[index + 1] == ")" || smileys[index + 1] == "D")
                    {
                        output = output + 1;
                        index = index + 2;
                    }
                    else if (smileys[index + 1] == "-" || smileys[index + 1] == "~")
                    {
                        if (smileys[index + 2] == ")" || smileys[index + 2] == "D")
                        {
                            output = output + 1;
                            index = index + 3;
                        }
                        else
                        {
                            index = index + 2;
                        }
                    }
                    else
                    {
                        index = index + 1;
                    }
                }
                else
                {
                    index = index + 1;
                }
            }
            return output;
        }
}
}
