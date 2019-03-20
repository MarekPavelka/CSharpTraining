using System.Collections.Generic;

namespace CSharpAdvanced
{
    public class ExtensionMethods
    {
        void Usage()
        {
            var x = new List<int>();
            var y = new List<string>();

            var result = x.Bullshit("fero"); // usage
            var result2 = y.Bullshit("jozef");

            ListExtensions.Bullshit(x, "fero"); // replaced after compilation
        }
    }

    public static class ListExtensions
    {
        public static int Bullshit<T>(this List<T> list, string name)
        {
            return 0;
        }
    }
}