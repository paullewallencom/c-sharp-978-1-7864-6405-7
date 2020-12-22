using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_AutoPropertyInit();
        }

        /// <summary>
        /// Auto-Property Initializers
        /// </summary>
        private static void Test_AutoPropertyInit()
        {
            Singer s = new Singer();
            Console.WriteLine($"{s.Name}");
        }
    }
}
