using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class LocalDeliveryHandler : IDeliveryHandler
    {
        private IDeliveryHandler? nextHandler;

        public void SetNextHandler(IDeliveryHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(Order order)
        {
            if (!order.IsInternational)
            {
                Console.WriteLine($"Processing local delivery for {order.Product} to {order.Address}");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(order);
            }
        }
    }
}
