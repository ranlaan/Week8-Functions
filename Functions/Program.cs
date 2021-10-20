using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi: ");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi: ");
            string userlastname = Console.ReadLine();
            Console.WriteLine("sisesta oma sünniaasta: ");
            int userage = Convert.ToInt32(Console.ReadLine()); 

            Greetings(username, userage, userlastname);
        }

        private static void Greetings(string someString, int someInt, string someName)
        {
            Console.WriteLine($"Tere, {someString} {someName}!");
            Console.WriteLine($"Oled {2021 - someInt}.");
        }


    }
}
