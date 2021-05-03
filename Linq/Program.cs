using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBook();
            var book = books.Single(b => b.Title == "Ado345");
            Console.WriteLine(book.Title);
            //LinqBasicMethods(books);

            //books.Where(b => b.Price < 10);
            //books.Single(b => b.Price < 10);
            //books.SingleOrDefault(b => b.Price < 10);
            //books.Count();
            //books.Sum(b=>b.Price);
            //books.First(b => b.Price < 10);
            //books.FirstOrDefault(b => b.Price < 10);
            //books.Max();
            //books.Min();
            //books.Average(b => b.Price);
            //books.Skip(2).Take(3);
            //books.Last();
            //books.LastOrDefault();

        }

        private static void LinqBasicMethods(IEnumerable<Book> books)
        {
            //LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            foreach (var cheapBook in cheaperBooks)
                Console.WriteLine(cheapBook.Title + " " + cheapBook.Price);

            //LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook);
        }
    }
}
