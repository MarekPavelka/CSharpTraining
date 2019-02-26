namespace LinqTutorial
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Linq 1
            // Select(), Where(), Any(), All(), Count(), First(),
            // Min(), Max(), Sum(), Average(), ToList(), ToArray()
            // Skip(), SkipWhile(), Take()
            // Linq 2
            // list1.Zip(list2, (l,p) => TResult) : List<TResult>
            // List<TLeft>.Zip(List<TRight>, (TLeft, TRight) => TResult) : List<Tresult>
            // list.GroupBy()
        }

        // List<TSource> .Select(TSource -> TResult) : List<TResult> 
        // Named "Map()" in other languages
        static void SelectExample()
        {
            // Declarative    { 2, 5, 7} -> { "2", "5", "7"}
            List<int> source = new List<int> { 2, 5, 7 };
            List<string> result = source
                                 .Select(x => x.ToString())
                                 .ToList();

            // Imperative    { 2, 5, 7} -> { "2", "5", "7"} 
            //List<int> source = new List<int> { 2, 5, 7 };
            //List<string> result = new List<string>();
            //foreach (var x in source)
            //{
            //    result.Add(x.ToString());
            //}
        }

        // List<TSource> .Where(TSource -> bool) : List<TSource>
        // Named "Filter()" in other languages
        // Funkcia T -> bool is called "predicate"
        static void WhereExample()
        {
            // { 2, 5, 7, 0} -> { 2, 0 }
            List<int> source = new List<int> { 2, 5, 7, 0 };
            List<int> result = source
                              .Where(x => IsEven(x))
                              //.Where(x => x % 2 == 0)
                              .ToList();

            // Imperative
            //var source2 = new List<int> {2, 5, 7, 0};
            //var result2 = new List<int>();
            //foreach (var x in source2)
            //{
            //    if (x % 2 == 0)
            //    {
            //        result2.Add(x);
            //    }
            //}
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        // List<TSource> .Any(TSource -> bool) : bool
        static void AnyExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            bool result = source.Any(); // source.Count > 0;
            bool result2 = source.Any(x => x % 2 == 0); // true, because source collection contains 2
        }

        // List<TSource> .All(TSource -> bool) : bool
        static void AllExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            // false, because not all items in source collection are even
            bool result = source.All(x => x % 2 == 0);
        }

        // List<TSource> .Count(TSource -> bool) : int
        static void CountExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            int result = source.Count();
            int result2 = source.Count(x => x % 2 == 0); // 1, because there is only one even item in source
            // source.Where(x => x % 2 == 0).Count() // equivalent
        }

        // List<TSource> .First(TSource -> bool) : TSource
        static void FirstExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            int result = source.First();
            int result2 = source.First(x => x > 2); // 5
                                                    // source.Where(x => x > 2).First() // equivalent

            // returns 0, because default(int) is 0 (would be null for reference types)
            int result3 = source.FirstOrDefault(x => x > 10);
        }

        static void MinExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            int result = source.Min(); // 2
        }

        static void MaxExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            int result = source.Max(); // 7
        }

        static void SumExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            int result = source.Sum(); // 14
        }

        static void AverageExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            double result = source.Average(); // 14/3 = 4.6666666
        }

        static void ToListExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            // creates a new instance of list containing the same elements
            List<int> result = source.ToList();
        }

        static void ToArrayExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            // creates a new instance of array containing the same elements
            int[] result = source.ToArray(); // { 2, 5, 7 }
        }

        static void SkipExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            List<int> result = source.Skip(2).ToList(); // { 7 }
            List<int> result2 = source.SkipWhile(x => x < 5).ToList(); // { 5, 7 }
        }

        static void TakeExample()
        {
            List<int> source = new List<int> { 2, 5, 7 };
            List<int> result = source.Take(2).ToList(); // { 2, 5 }
        }
    }
}