using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Program
    {
        private static List<string> theRunners;

        static void Main(string[] args)
        {
            //  Some code
        }

        #region New Language Features Part I - Expression Level

        /// <summary>
        /// renaming
        /// </summary>
        // <param name="theRunners"></param>
        private static void Test_Renaming()
        {
            var theAthletes = string.Empty;

            if (theRunners == null)
            {
                throw new ArgumentNullException("theRunners", "The parameter passed in is null.");
            };

            foreach (var name in theRunners)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }
        #endregion
    }
}
