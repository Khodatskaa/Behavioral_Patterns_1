using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class CoffeeOrder
    {
        public string Size { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }

        public CoffeeOrder(string size, bool hasMilk, bool hasSugar)
        {
            Size = size;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
        }
    }
}
