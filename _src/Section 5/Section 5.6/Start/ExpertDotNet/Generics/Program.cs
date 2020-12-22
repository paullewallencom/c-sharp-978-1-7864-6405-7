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
            bool IsTrue = Tester<int>.IsEqual(3, 3);

            Console.WriteLine(IsTrue ? "yes" : "no");
        }
    }

    public class Tester<T>
    {
        public static bool IsEqual(T InterestRate1, T InterestRate2) {
            return InterestRate1.Equals(InterestRate2);
        }
    }
}
