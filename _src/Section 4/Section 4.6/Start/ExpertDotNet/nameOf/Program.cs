using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameOf
{
    class Program
    {
        private static List<string> theFans;
        static void Main(string[] args)
        {
            //  Test_NameOf();
        }

        /// <summary>
        /// nameOf
        /// </summary>
        /// <param name="thePeople"></param>
        private static void Test_NameOf()
        {
            theFans = null;

            if (theFans == null)
            {
                throw new ArgumentNullException("theFans", "The parameter passed in is null.");
            };

            foreach (var name in theFans)
            {
                Console.WriteLine(name);
                DateTime.Compare(DateTime.Today, DateTime.Today.AddDays(1));
            }
        }

    }
}
