using System.Globalization;

namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            int X = 10;
            int Y = 20;
            Console.WriteLine($"Equation : {X} + {Y} = {X + Y:C}") ;
        }
    }
}
