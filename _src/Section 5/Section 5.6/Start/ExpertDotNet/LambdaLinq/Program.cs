using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HomeBuyer> buyerList = new List<HomeBuyer>() {
                new HomeBuyer { ID = 10, Name="Matt"},
                new HomeBuyer { ID = 11, Name="Jimmy"},
                new HomeBuyer { ID = 12, Name="Margy"}
            };

            HomeBuyer buyer = buyerList.Find(delegate (HomeBuyer b) { return b.ID == 11; });
            Console.WriteLine($"ID = {buyer.ID}, Name: {buyer.Name}");
        }
    }
}
