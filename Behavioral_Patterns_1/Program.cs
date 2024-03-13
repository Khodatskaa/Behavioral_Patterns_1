namespace Behavioral_Patterns_1
{
    internal class Program
    {
        static void Main()
        {
            LibraryHandler fictionHandler = new FictionHandler();
            LibraryHandler nonFictionHandler = new NonFictionHandler();

            fictionHandler.SetSuccessor(nonFictionHandler);

            Book book = new Book("The Great Gatsby", "Fiction");

            fictionHandler.HandleRequest(book);
        }
    }
}
