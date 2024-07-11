
using System;
using System.Collections.Generic;

namespace TheLibraryItself
{
    public class LibraryItem : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public void Borrow()
        {
            Console.WriteLine($"{Title} by {Author} borrowed.");
        }

        public void Return()
        {
            Console.WriteLine($"{Title} by {Author} returned.");
        }
    }
    public interface IBorrowable
    {
        void Borrow();
        void Return();
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
        }

        public void BorrowItem(LibraryItem item)
        {
            item.Borrow();
        }

        public void ReturnItem(LibraryItem item)
        {
            item.Return();
        }

        public void DisplayLibrary()
        {
            Console.WriteLine("Library Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Title} by {item.Author} ({item.PublicationYear})");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryItem book1 = new LibraryItem { Title = "Book Title 1", Author = "Author A", PublicationYear = 2000 };
            LibraryItem book2 = new LibraryItem { Title = "Book Title 2", Author = "Author B", PublicationYear = 2010 };

            Library library = new Library();
            library.AddItem(book1);
            library.AddItem(book2);

            library.DisplayLibrary();

            library.BorrowItem(book1);
            library.ReturnItem(book1);

            library.DisplayLibrary();
        }
    }
}

