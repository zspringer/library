using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Library zachBooks = new Library();
            zachBooks.stackBooks();

            bool selecting = true;
            Console.Clear();
            while (selecting)
            {
                Console.WriteLine("Make a selection");
                Console.WriteLine("1. Checkout a book\n2. Return a book\n3. Quit");
                string UserChoice = Console.ReadLine();
                //Declare a num and then Int32 line says that if it successfully takes in the user choice, it will set the value to num
                int num;
                Int32.TryParse(UserChoice, out num);

                //if statements corresponding to user choice from the menu
                if (num == 1)
                {
                    selecting = false;
                    Book selectedBook = zachBooks.SelectBook(zachBooks.AvailableBooks);
                    if (selectedBook != null)
                    {
                        zachBooks.CheckOutBook(selectedBook);
                    }
                }
                if (num == 2)
                {
                    selecting = false;
                    Book selectedBook = zachBooks.SelectBook(zachBooks.CheckedOutBooks);
                    if (selectedBook != null)
                    {
                        zachBooks.ReturnBook(selectedBook);
                    }
                }
                if (num ==3)
                {
                    selecting = false;
                }
                selecting = true;





            }


        }
    }
}
