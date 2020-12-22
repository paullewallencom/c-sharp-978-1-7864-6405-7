using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_IndexInitiatlizer();
        }

        /// <summary>
        /// Index initializers
        /// </summary>
        private static void Test_IndexInitiatlizer()
        {
            // Old approach
            var myOldDictionary = new Dictionary<string, string>
            {
                { "Name", "Al Pacino" },
                { "ArtistType", "Gangster" },
                { "FamousQuote", "Say hello to my little friend" }
            };
        }
    }
}
