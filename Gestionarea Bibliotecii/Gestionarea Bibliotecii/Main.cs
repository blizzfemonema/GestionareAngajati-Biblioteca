
using System;
public interface IBorrowable
{
    void Borrow();
    void Return();
    bool IsBorrowed { get; }
}

public abstract class LibraryItem : IBorrowable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsBorrowed { get; private set; }

    public LibraryItem(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        IsBorrowed = false;
    }

    public void Borrow()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"{Title} is already borrowed.");
        }
    }

    public void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"{Title} has been returned.");
        }
        else
        {
            Console.WriteLine($"{Title} was not borrowed.");
        }
    }
}
public class Book : LibraryItem
{
    public Book(string title, string author, int publicationYear)
        : base(title, author, publicationYear) { }
}

public class Magazine : LibraryItem
{
    public Magazine(string title, string author, int publicationYear)
        : base(title, author, publicationYear) { }
}

public class DVD : LibraryItem
{
    public DVD(string title, string author, int publicationYear)
        : base(title, author, publicationYear) { }
}

public class Library
{
    private List<LibraryItem> items;

    public Library()
    {
        items = new List<LibraryItem>();
    }

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Title} has been added to the library.");
    }

    public void BorrowItem(string title)
    {
        var item = items.Find(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (item != null)
        {
            item.Borrow();
        }
        else
        {
            Console.WriteLine($"{title} not found in the library.");
        }
    }

    public void ReturnItem(string title)
    {
        var item = items.Find(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (item != null)
        {
            item.Return();
        }
        else
        {
            Console.WriteLine($"{title} not found in the library.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("The girl on the train", "Paula Hawkins", 2015);
        Magazine magazine1 = new Magazine("Time", "Henry Luce", 2020);
        DVD dvd1 = new DVD("Inception", "Christopher Nolan", 2010);

        library.AddItem(book1);
        library.AddItem(magazine1);
        library.AddItem(dvd1);

        library.BorrowItem("The girl on the train");
        library.BorrowItem("The girl on the train");

        library.ReturnItem("The girl on the train");
        library.ReturnItem("The girl on the train");

        library.BorrowItem("Inception");
        library.ReturnItem("Time");
    }
}