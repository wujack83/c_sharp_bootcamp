using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarieren und Initialisieren der Variable meinName
            string meinName = "Rolf";
            string nachricht = "Mein Name ist " + meinName; 
            Console.WriteLine(nachricht);
            Console.ReadKey();
        }
    }

}