using System;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";

            int num1 = int.Parse(myString);
            int num2 = int.Parse(mySecondString); 

            int Result = num1 + num2;

            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
