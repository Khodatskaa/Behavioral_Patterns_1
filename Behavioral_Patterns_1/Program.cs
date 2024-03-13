namespace Behavioral_Patterns_1
{
    internal class Program
    {
        static void Main()
        {
            ICoffeeHandler smallHandler = new SmallCoffeeHandler();
            ICoffeeHandler mediumHandler = new MediumCoffeeHandler();
            ICoffeeHandler largeHandler = new LargeCoffeeHandler();

            smallHandler.SetNextHandler(mediumHandler);
            mediumHandler.SetNextHandler(largeHandler);

            CoffeeOrder order = new CoffeeOrder("Medium", true, false);

            smallHandler.HandleRequest(order);
        }
    }
}
