using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsTrue = Tester.IsEqual(2, 3);

            Console.WriteLine(IsTrue ? "yes" : "no");
        }
    }

    public class Tester {
        public static bool IsEqual(int InterestRate1, int InterestRate2) {
            return InterestRate1 == InterestRate2;
        }
    }
}
