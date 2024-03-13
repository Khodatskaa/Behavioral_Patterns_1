using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class MediumCoffeeHandler : ICoffeeHandler
    {
        private ICoffeeHandler? nextHandler;

        public void SetNextHandler(ICoffeeHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(CoffeeOrder order)
        {
            if (order.Size == "Medium")
            {
                Console.WriteLine("Making a medium coffee");
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
