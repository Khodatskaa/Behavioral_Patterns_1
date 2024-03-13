using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_1
{
    public class Book
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Book(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
