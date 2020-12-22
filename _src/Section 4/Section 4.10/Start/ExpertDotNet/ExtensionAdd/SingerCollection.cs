using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAdd
{
    class SingerCollection : IEnumerable<Singer>
    {
        List<Singer> singers = new List<Singer> {
            new Singer { Age = 40, Name = "Jay Z" },
            new Singer { Age = 60, Name = "Julio Iglesias" } };

        public IEnumerator<Singer> GetEnumerator()
        {
            return singers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Singer Add(Singer anotherSinger)
        {
            singers.Add(anotherSinger);
            return anotherSinger;
        }
    }
}
