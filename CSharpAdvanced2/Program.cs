namespace CSharpAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        private void Foo(DayOfWeek day)
        {
            if (day == DayOfWeek.Sunday)
            {
            }
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var result = list.MySelect(ConvertToStringRepresentation).ToList();

            var result2 = list.Select(x => ConvertToStringRepresentation(x)).ToList();

            var result3 = list.Where(x => IsEven(x)).ToList();
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static string ConvertToStringRepresentation(int x)
        {
            //

            //
            //
            //
            //
            return "abc" + x;
        }
    }

    public static class LinqExtensions
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
