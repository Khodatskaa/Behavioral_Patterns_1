using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public abstract class LibraryHandler
    {
        protected LibraryHandler? successor;    // successor is a reference to the next object in the chain

        public void SetSuccessor(LibraryHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(Book book);
    }
}
