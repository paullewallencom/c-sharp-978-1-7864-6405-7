using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameOf
{
    class Program
    {
        private static List<string> theFollowers;
        static void Main(string[] args)
        {
            //  Test_NameOf();
            
        }

        /// <summary>
        /// nameOf
        /// </summary>
        /// <param name=nameof(theFollowers)></param>
        private static void Test_NameOf()
        {
            theFollowers = null;
            
            if (theFollowers == null)
            {
                throw new ArgumentNullException(nameof(theFollowers), "The parameter passed in is null.");
            };

            foreach (var name in theFollowers)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }

    }
}
