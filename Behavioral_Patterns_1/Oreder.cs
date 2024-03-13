using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class Order
    {
        public string Product { get; set; }
        public string Address { get; set; }
        public bool IsInternational { get; set; }

        public Order(string product, string address, bool isInternational)
        {
            Product = product;
            Address = address;
            IsInternational = isInternational;
        }
    }
}
