using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _5BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            var library = new Library();

            library.Name = "First Library";
            library.Books = new List<Book>();

            var numberOfBooks = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfBooks; i++)
            {
                var book = Console.ReadLine().Split();

                var newBook = new Book
                {
                    Title = book[0],
                    Author = book[1],
                    Publisher = book[2],
                    ReleaseDate = DateTime.ParseExact((book[3]), "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = book[4],
                    Price = decimal.Parse(book[5])
                };
                library.Books.Add(newBook);

            }

            var afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var groupedAuthor = new Dictionary<string, List<Book>>();


            foreach (var book in library.Books.OrderBy(x => x.ReleaseDate).ThenBy(t => t.Title))
            {
                if (book.ReleaseDate > afterDate)
                {
                    Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
                }
            }

            //foreach (var book in library.Books)
            //{
            //    if (!groupedAuthor.ContainsKey(book.Author))
            //    {
            //        groupedAuthor[book.Author] = new List<Book>();
            //    }

            //    groupedAuthor[book.Author].Add(book);
            //}

            //foreach (var author in groupedAuthor.OrderByDescending(x => x.Value.Sum(y => y.Price)).ThenBy(a => a.Key))
            //{
            //    Console.WriteLine($"{author.Key} -> {(author.Value.Sum(x => x.Price)):F2}");
            //}
        }
     }
}
