using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Program
    {
        private static List<string> theAthletes;

        static void Main(string[] args)
        {
            //  Some code
        }


        /// <summary>
        /// renaming
        /// </summary>
        // <param name="theAthletes"></param>
        private static void Test_Renaming()
        {
            var theAthletes = string.Empty;

            if (Program.theAthletes == null)
            {
                throw new ArgumentNullException("theAthletes", "The parameter passed in is null.");
            };

            foreach (var name in Program.theAthletes)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }
         
    }
}
