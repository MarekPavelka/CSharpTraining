namespace Scatch
{
    class Program
    {
        static void Main()
        {
            var array = new[] { 1, 2, 3 };
            var lengthOfArray = array.Length;
            array.ToString();

            Sorceress mojChar = new Sorceress("");
            mojChar.Name = "Jozka";
            mojChar.KillYourself();

            var className = Sorceress.ClassName;
            Sorceress tvojChar = new Sorceress("");
            tvojChar.Name = "Fidorka";

            //var console = new Console();
            //console.WriteLine();
        }

        // Function overloads
        static void Foo(int x, string y)
        {
        }

        static void Foo(int x, string p, bool x)
        {
        }
    }
}
