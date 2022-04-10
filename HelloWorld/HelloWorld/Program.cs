/*
 * 
 * Mein 1. C# Programm für mein Training 
 * Author: Rolf Seewaldt
 * 
 */
using System;

namespace HelloWorld
{ 
    class Program
    {
        // Einstiegspunkt für das Programm
        static void Main(string[] args)
        {
            //Ändere die Konsolenfarbe und gebe Hallo, Welt! aus
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hallo, Welt!");
            // Übung: Ändere den Code in Hallo, Rolf
            Console.WriteLine("Hallo, Rolf!");
            // ReadKey lässt die Konsole offen
            Console.ReadKey();           
            
        }
    }

}