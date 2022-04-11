using System;

namespace Challange_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[1024];
            sbyte[] buffer2 = new sbyte[1024]; 
            int myint = 0;
            uint myuint = 0;
            short myshort = 0;
            ushort myushort = 0;
            long mylong = 1337;
            float myfloat = 0f;
            double mydouble = 0;
            char mychar = 'a';
            bool mybool = false;
            string mystring = "1.337";
            decimal mydecimal = 0;

            string toString = mylong.ToString();
            double toNum = double.Parse(mystring);

            Console.WriteLine(toString);
            Console.WriteLine(toNum);
            Console.ReadKey();
        }
    }
}
