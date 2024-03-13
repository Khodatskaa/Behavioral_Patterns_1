using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class SmallCoffeeHandler : ICoffeeHandler
    {
        private ICoffeeHandler? nextHandler;

        public void SetNextHandler(ICoffeeHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(CoffeeOrder order)
        {
            if (order.Size == "Small")
            {
                Console.WriteLine("Making a small coffee");
                if (order.HasMilk)
                    Console.WriteLine("Adding milk");
                if (order.HasSugar)
                    Console.WriteLine("Adding sugar");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(order);
            }
        }
    }
}
