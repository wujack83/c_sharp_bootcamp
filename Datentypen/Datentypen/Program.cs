using System;

namespace HelloWorld
{
    class Program
    {
        // Einstiegspunkt für das Programm
        static void Main(string[] args)
        {   
            // Deklarieren und initialisieren der Variable Wert 1
            int wert1 = 25;
            // Deklarieren
            int wert2;
            //Initialisieren
            wert2 = 15;

            // Deklarieren mehrerer Variablen in einer Zeile
            int wert3, wert4, wert5;
            
            int summe = wert1 + wert2;

            double d1 = 3.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            // Verwendung von float
            float f1 = 1.337f;
            
            Console.WriteLine("Die Summe ist: " + summe);
            Console.WriteLine("Der Quotient ist: " + ergebnis);
            Console.ReadKey();
            
        }
    }

}