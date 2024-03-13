namespace Behavioral_Patterns_1
{
    internal class Program
    {
        static void Main()
        {
            IDeliveryHandler localHandler = new LocalDeliveryHandler();
            IDeliveryHandler internationalHandler = new InternationalDeliveryHandler();
            IDeliveryHandler expressHandler = new ExpressDeliveryHandler();

            localHandler.SetNextHandler(internationalHandler);
            internationalHandler.SetNextHandler(expressHandler);

            Order order = new Order("Electronics", "555 Main Street", true);

            localHandler.HandleRequest(order);
        }
    }
}
