using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_StringInterp();
        }

        /// <summary>
        /// String interpolation
        /// </summary>
        private static void Test_StringInterp()
        {
            var city = "Los Angeles";
            var state = "CA";
            var zip = 91405;
            decimal cash = 15;

            //var address_oldSchool = string.Format("\n14681 S. Happy St., {0}, {1}, {2}\n", city, state, zip);
            //Console.WriteLine(address_oldSchool);

            var address_newSchool = $"\n14681 S. Happy St., {city}, {state}, {zip}\n";
            Console.WriteLine(address_newSchool);

            var cashOwed = $"Today: {DateTime.Now:d}, Dollars owed:{cash:C}";
            Console.WriteLine(cashOwed);
        }
    }
}
