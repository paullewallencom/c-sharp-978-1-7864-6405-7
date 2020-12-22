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

        }
    }
}
