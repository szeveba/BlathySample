using FrameSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameSample.Logic
{
    internal class MainLogic
    {
        public MainLogic()
        {
            Books = new List<Book>();
            Authors = new List<Author>();
        }
        public List<Book> Books { get; }
        public List<Author> Authors { get; }
    }
}
