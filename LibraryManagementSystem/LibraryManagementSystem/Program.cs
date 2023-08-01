using System;
using BookLibraryLib;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Library library = new Library(); // Moved outside of the do-while loop
            do
            {
                Console.WriteLine("Library Management System\n1. Add Book\n" +
                    "2. View All Books\n3. Search book by ID\n4. Search book by Title\n" +
                    "5. Exit");

                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Book book = new Book();
                        Console.WriteLine("Enter Book ID: ");
                        book.BookId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Book Title: ");
                        book.Title = Console.ReadLine();
                        Console.WriteLine("Enter Book Author: ");
                        book.Author = Console.ReadLine();
                        Console.WriteLine("Enter Book Genre: ");
                        book.Genre = Console.ReadLine();

                        library.AddBook(book);
                        break;
                    case 2:
                        library.PrintBookDetails();
                        break;
                    case 3:
                        Console.WriteLine("Enter book id to search");
                        int searchId = int.Parse(Console.ReadLine());
                        Book foundBook = library.SearchBookByID(searchId);

                        if (foundBook != null)
                        {
                            Console.WriteLine("Book Found");
                            Console.WriteLine("Book Unique Id: " + foundBook.BookId);
                            Console.WriteLine("Title: " + foundBook.Title);
                            Console.WriteLine("Author: " + foundBook.Author);
                            Console.WriteLine("Genre: " + foundBook.Genre);
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter book title to search");
                        string searchTitle = Console.ReadLine();
                        Book foundBookByTitle = library.SearchBookByName(searchTitle);

                        if (foundBookByTitle != null)
                        {
                            Console.WriteLine("Book Found");
                            Console.WriteLine("Book Unique Id: " + foundBookByTitle.BookId);
                            Console.WriteLine("Title: " + foundBookByTitle.Title);
                            Console.WriteLine("Author: " + foundBookByTitle.Author);
                            Console.WriteLine("Genre: " + foundBookByTitle.Genre);
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Do you wish to continue? If yes, press 'y'");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");
        }
    }
}







