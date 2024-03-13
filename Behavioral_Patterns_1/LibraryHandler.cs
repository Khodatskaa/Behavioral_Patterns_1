using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public abstract class LibraryHandler
    {
        protected LibraryHandler? successor;

        public void SetSuccessor(LibraryHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(Book book);
    }
}
