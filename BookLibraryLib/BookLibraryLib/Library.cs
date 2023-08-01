using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryLib
{
    public class Library
    {
        static List<Book> books;

        public Library()
        {
            books = new List<Book>()
            {
                new Book{ BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction"},
                new Book{ BookId = 2, Title = "To kill a mockingbird", Author = "Harper lee", Genre = "Fiction"},
                new Book{ BookId = 3, Title = "The Hobbit", Author = "J.R.R. Tolkin", Genre = "Fantasy"},
                

            };
        }

        public void PrintBookDetails()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Book Unique Id: " + book.BookId);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);               
                Console.WriteLine();
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("After adding new book");
            this.PrintBookDetails();
        }

        public Book SearchBookByID(int id)
        {
            return books.Find(book => book.BookId == id);
        }

        public Book SearchBookByName(string title)
        {
            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
