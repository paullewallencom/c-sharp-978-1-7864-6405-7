using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBFM
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_EBFM();
        }

        /// <summary>
        /// ExpressionBodied Function Members
        /// </summary>
        private static void Test_EBFM()
        {
            // Old Approach
            Console.WriteLine(Name); // Example 1

            Console.WriteLine(GetFullName("Barbra", "Streisand")); // Example 2

            PrintFullName("Bill", "Manning"); // Example 3

            var c = PrintSingerName("Reynald", "Adolphe"); // Example 4
            Console.WriteLine(c.FirstName + " " + c.LastName);

            // TODO - New Approach  
        }

        // EBFM Example 1 - Property 
        static private string name = "William Shatner";
        static public string Name
        {
            get { return name; }
        }

        // EBFM Example 2 - Method returning string
        static public string GetFullName(string firstName, string lastName)
        {
            return String.Format("{0} {1}", firstName, lastName);
        }

        // EBFM Example 3 - Method returning void
        static public void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(String.Format("{0} {1}", firstName, lastName));
        }

        // EBFM Example 4 - Method returning object
        static public Singer PrintSingerName(string first, string last)
        {
            return new Singer(first, last);
        }

    }
}
