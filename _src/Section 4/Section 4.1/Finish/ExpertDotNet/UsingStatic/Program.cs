using System;
using static System.Console;
using static System.Math;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_Using();
        }

        /// <summary>
        /// Using static
        /// </summary>
        static private void Test_Using()
        {
            WriteLine($"The concert was cool!! Tickets were {Round(29.00):C}");
            
        }
    }
}
