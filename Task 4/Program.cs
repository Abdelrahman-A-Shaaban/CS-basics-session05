using Microsoft.VisualBasic;
using System.Drawing;

namespace Task_4
{
    #region Question 1
    // Add a private string password = "secret"; field to a Book class. Try to print it from Main
    // (outside the class). What happens, and why?
    /*
    class Book
    {
        private string password = "secret";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(book.password);
        }
    }
    */

    // Error, because the password field is private and cannot be accessed from outside the Book class.
    #endregion

    #region Question 2
    // Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
    // Why?
    /*
    class Book
    {
        internal int copiesInStock = 5;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(book.copiesInStock);
        }
    }

    // Yes it compiles, because the copiesInStock field is internal and in same solution
    */
    #endregion

    #region Question 3
    // Add a public string Title; field to Book. Set it and print it from Main.
    /*
    class Book
    {
        public string Title;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "How to be rich";
            Console.WriteLine(book.Title);
        }
    }
    */
    #endregion

    #region Question 4
    // Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
    // assign it Genre.Science, and print it.
    /*
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    class Book
    {
        public Genre Genre { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book();
            firstBook.Genre = Genre.Science;
            Console.WriteLine(firstBook.Genre);
        }
    }
    */
    #endregion

    #region Question 5
    // Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
    /*
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
        }
    }
    */
    #endregion

    #region Question 6
    // Given int genreNumber = 1;, cast it into a Genre value and print the result.
    /*
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int genreNumber = 1;

            switch (genreNumber)
            {
                case 0:
                    Console.WriteLine(Genre.Fiction);
                    break;

                case 1:
                    Console.WriteLine(Genre.NonFiction);
                    break;

                case 2:
                    Console.WriteLine(Genre.Science);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
    */
    #endregion

    #region Question 7
    // Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
    /*
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Genre genre = Genre.Fiction;
            string genreString = genre.ToString();
            Console.WriteLine(genreString);
        }
    }
    */
    #endregion

    #region Question 8

    /*
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Genre genre = (Genre)Enum.Parse(typeof(Genre), genreString);
        }
    }
    */
    #endregion

    #region Question 9
    // Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
    // attempt the conversion.Print "Unknown genre" if it fails.
    /*

    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string genreText = "Mystery";
            if (Enum.TryParse(genreText, out Genre genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    
    }
    */
    #endregion

}