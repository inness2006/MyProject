namespace MyProject;

public class Book
{
    private string title;
    private string author;
    private int yearPublished;
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
}