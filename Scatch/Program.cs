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
            Foo();
            Sorceress tvojChar = new Sorceress("");
            tvojChar.Name = "Fidorka";

            int x = 1;
            int y = 37;

            //var console = new Console();
            //console.WriteLine();
        }

        private static void Foo()
        {


        }
    }
}
