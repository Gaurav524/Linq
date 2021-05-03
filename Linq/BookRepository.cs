using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBook()
        {
            return new List<Book>
            {
              new Book(){Title="Ado", Price=5},
              new Book(){Title="Mvc", Price=6},
              new Book(){Title="Csharp", Price=7},
              new Book(){Title="Asp.Net", Price=11},
              new Book(){Title="Cloud", Price=16},
            };
        }
    }
}
