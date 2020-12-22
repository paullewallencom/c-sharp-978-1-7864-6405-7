using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_NullConditionalOp();
        }

        /// <summary>
        /// Null-conditional operators
        /// </summary>        
        private static void Test_NullConditionalOp()
        {

            List<Singer> singers = new List<Singer> {
                new Singer { Age = 54, Name = "Kenny Rogers" },
                new Singer { Age = 97, Name = "Paul Simon" }
            }; 

            // Old Approach
            //int? numberOfsingers = (singers == null) ? (int?)null : singers.Count;
            int? numberOfsingers = singers?.Count();
            //Console.WriteLine(numberOfsingers);

            Singer defaultSinger = singers?[0];
            //Console.WriteLine("Default singer name is: {0}", defaultSinger?.Name);
            //int theCount = singers?.Count ?? 0;
            //Console.WriteLine($"theCount={theCount}");

            Console.WriteLine($"Default singer,{defaultSinger?.Name}, is age: {singers?[0]?.Age}");
        }
    }
}
