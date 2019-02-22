using System.Collections.Generic;

namespace ValueVsReferenceTypes
{
    class Program
    {


    }
    class Ferko
    {
        static void Main()
        {
            var x = null + "abc";
            string y = null;
            y.Contains("abc");
        }
    }
}


