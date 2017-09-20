namespace library
{
    public class Book
    {
        public string Title;
        public string Author;
        public bool Rentable = true;

        //Constructor for creating the books
        //Parameters that Book takes in must equal the casing of the type specified below
        public Book(string title, string author, bool rentable = true)
        {
            Title = title;
            Author = author;
            Rentable = rentable;
        }
    }
}