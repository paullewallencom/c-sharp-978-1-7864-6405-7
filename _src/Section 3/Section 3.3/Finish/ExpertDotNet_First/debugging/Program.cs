using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Debugging_Fun();
        }

        private static void Debugging_Fun()
        {
            // Debug for life!
            var athletes = new List<Athlete>() {
                new Athlete () {
                    Name = "Bruce Jenner",
                    Age = 99,
                    FavoriteFood = Food.Japanese },
                new Athlete () {
                    Name = "Bo Jackson",
                    Age = 59,
                    FavoriteFood = Food.Italian }
                };

            var whoLovesItalian = from a in athletes
                                  where a.FavoriteFood == Food.Italian
                                  select a;           
        }
    }

    internal class Athlete
    {
        public int Age { get; internal set; }
        public Food FavoriteFood { get; internal set; }
        public string Name { get; internal set; }
    }

    enum Food
    {
        Japanese,
        Italian
    }
}
