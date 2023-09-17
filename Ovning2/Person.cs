using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2
{
    // Person class, which represent person age and to which price group person belong
    internal class Person
    {
        // Person age
        public uint Alder { get; }

        // Price group depend on person age
        public PriceGroup PriceGroup => Alder < 5 || Alder > 100 ? PriceGroup.Free : Alder < 20 ? PriceGroup.Ungdom : Alder > 64 ? PriceGroup.Pensionar : PriceGroup.Standard;

        // Person class constructor
        public Person(uint alder)
        {
            Alder = alder;
        }
    }
}
