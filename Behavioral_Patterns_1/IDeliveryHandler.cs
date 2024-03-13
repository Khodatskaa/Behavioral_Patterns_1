using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public interface IDeliveryHandler
    {
        void SetNextHandler(IDeliveryHandler nextHandler);
        void HandleRequest(Order order);
    }
}
