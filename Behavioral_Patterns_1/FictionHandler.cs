using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class FictionHandler : LibraryHandler
    {
        public override void HandleRequest(Book book)
        {
            if (book.Category == "Fiction")
            {
                Console.WriteLine($"FictionHandler handled the request for book: {book.Title}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(book);
            }
        }
    }
}
