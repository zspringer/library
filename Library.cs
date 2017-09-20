using System;
using System.Collections.Generic;

namespace library
{
    public class Library
    {
        public List<Book> AvailableBooks = new List<Book>();
        public List<Book> CheckedOutBooks = new List<Book>();

        Book Book1 = new Book("HeadFirst with C#", "John Smith");
        Book Book2 = new Book("Mastering the Console App", "Clark Springer");
        Book Book3 = new Book("C# Game Programming: For Serious Game Creation", "Jack Swanson");
        Book Book4 = new Book("Pro C# 5.0 and the .NET 4.5 Framework", "Brad Springer");

        //TODO: Figure out where to use option 5 which is Return Book

        public void stackBooks()
        {
            AvailableBooks.Add(Book1);
            AvailableBooks.Add(Book2);
            AvailableBooks.Add(Book3);
            AvailableBooks.Add(Book4);

        }

        // public void Checkout(index);
        public Book SelectBook(List<Book> list)
        {
            Book selectedbook = null;
            Console.WriteLine("Please choose a book by title to checkout");
            foreach (Book book in list)
            {
                //get the book from the list
                System.Console.WriteLine(book.Title, book.Author);
            }
            string UserChoice = Console.ReadLine();
            System.Console.WriteLine(UserChoice);
            foreach (Book book in list)
            {
                if (UserChoice == book.Title)
                {
                    selectedbook = book;
                }
            }
            return selectedbook;
        }
        public void CheckOutBook(Book book)
        {
               CheckedOutBooks.Add(book);
               System.Console.WriteLine($"{book.Title} was added.");
               AvailableBooks.Remove(book);
               //This is to check that the book was removed from the list of available books
               //System.Console.WriteLine($"{book.Title} was removed.");
        }

        public void ReturnBook(Book book)
        {
            AvailableBooks.Add(book);
            System.Console.WriteLine($"{book.Title} was added back to the Library.");
            CheckedOutBooks.Remove(book);
        }



    }

}