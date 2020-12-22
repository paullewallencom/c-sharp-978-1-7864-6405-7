using System;

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
            Console.WriteLine($"The concert was cool!! Tickets were {Math.Round(29.00):C}");
           
        }
    }
}
