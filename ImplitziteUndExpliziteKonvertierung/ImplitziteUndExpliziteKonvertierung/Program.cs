using System;

namespace ImplitziteUndExpliziteKonvertierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implizte Konvertierung
            int num = 123453233;
            long bigNum = num;

            float myfloat = 13.37f;
            double myDouble = myfloat;

            //Explizite Konvertierung
            int myInt;
            double myNewDouble = 13.37;
            myInt = (int)myNewDouble;

            string myString = myNewDouble.ToString();
            string myString2 = myString + "12";

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadKey();
        }
    }
}
