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
            int laenge = nachricht.Length;
            // ToUpper macht alle Elemente des Strings groß
            string allesGross = nachricht.ToUpper();
            string allesklein = nachricht.ToLower();
            Console.WriteLine(nachricht);
            Console.WriteLine(nachricht + " ist {0} Zeichen lang", laenge);
            Console.WriteLine(allesGross);
            Console.WriteLine(allesklein);
            Console.ReadKey();
        }
    }

}