using System;
using System.Collections.Generic;

namespace MyProject
{
    public class Book
    {
        private string title;
        private string author;
        private int yearPublished  ;
        private bool isAvailable;

        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
            this.isAvailable = true;
        }

        public void CheckOut()
        {
            if (isAvailable)
            {
                Console.WriteLine($"The book '{title}' by {author} has been checked out.");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine($"Sorry, the book '{title}' is currently not available.");
            }
        }

        public void Return()
        {
            if (!isAvailable)
            {
                Console.WriteLine($"The book '{title}' has been returned.");
                isAvailable = true;
            }
            else
            {
                Console.WriteLine($"Error: This book '{title}' is already available in the library.");
            }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }
    }

    public class Library // Aggregation and Composition
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books in the Library:");
            foreach (Book book in books)
            {
                if (book.IsAvailable)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
            }
        }
    }

    public class EBook : Book // Inheritance
    {
        private string format;

        public EBook(string title, string author, int yearPublished, string format)
            : base(title, author, yearPublished)
        {
            this.format = format;
        }

        public void ReadEBook()
        {
            Console.WriteLine($"Reading the eBook '{Title}' in {format} format.");
        }
    }

    public class Author // Association 
    {
        private string name;

        public Author(string name)
        {
            this.name = name;
        }

        public void WriteBook(string title, int yearPublished)
        {
            Book newBook = new Book(title, name, yearPublished);
            Console.WriteLine($"Author {name} has written a new book: {title}");
        }
    }

    public class Publisher // Association
    {
        private string name;

        public Publisher(string name)
        {
            this.name = name;
        }

        public Book PublishBook(string title, string author, int yearPublished)
        {
            Book newBook = new Book(title, author, yearPublished);
            Console.WriteLine($"Publisher {name} has published a new book: {title} by {author}");
            return newBook;
        }
    }

    
}
