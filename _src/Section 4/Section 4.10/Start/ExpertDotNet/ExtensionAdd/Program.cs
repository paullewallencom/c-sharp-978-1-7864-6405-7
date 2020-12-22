using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_ExtensionAddMethods();
        }

        /// <summary>
        /// Extension Add Methods 
        /// </summary>
        private static void Test_ExtensionAddMethods()
        {
            // Use intiatializer syntax to add two more artists
            var artistCollection = new SingerCollection {
                new Singer {  Age=45, Name="James Brown" },
                new Singer {  Age=65, Name="Tom Jones" },
            };
        }
    }
}
