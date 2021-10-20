using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "brue", "green" };
            string[] moreColors = { "yellow", "pink", "biege", "purple" };
            PickRandomColor(colors);
            PickRandomColor(moreColors);
        }

        private static void PickRandomColor(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            Console.WriteLine(someArray [randomIndex]);
        }

    }
}
