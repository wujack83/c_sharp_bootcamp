using System;

namespace HelloWorld
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hallo, Welt!");
            Console.WriteLine("Hallo, Rolf!");
            Console.ReadKey();

            
        }
    }

}