using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class ExpressDeliveryHandler : IDeliveryHandler
    {
        private IDeliveryHandler? nextHandler;

        public void SetNextHandler(IDeliveryHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(Order order)
        {
            Console.WriteLine($"Processing express delivery for {order.Product} to {order.Address}");
        }
    }
}
