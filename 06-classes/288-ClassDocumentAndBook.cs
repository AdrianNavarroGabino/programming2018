// Adrián Navarro Gabino

using System;

class Document
{
    protected string title;
    protected string location;

    public Document(string newTitle, string newLocation)
    {
        title = newTitle;
        location = newLocation;
    }

    public Document()
    {
        title = "Untitled";
        location = "Unknown location";
    }

    public void SetTitle(string newTitle) { title = newTitle; }
    public void SetLocation(string newLocation) { location = newLocation; }

    public string GetTitle() { return title; }
    public string GetLocation() { return location; }
}

// ---------------------------------------------------------------------

class Book : Document
{
    protected string author;

    public Book(string newTitle, string newAuthor, string newLocation)
    {
        title = newTitle;
        author = newAuthor;
        location = newLocation;
    }

    public void SetAuthor(string newAuthor) { author = newAuthor; }

    public string GetAuthor() { return author; }
}

// ---------------------------------------------------------------------

class BookTest
{
    static void Main(string[] args)
    {
        Book b = new Book("It", "Stephen King", "A1");

        Console.WriteLine(b.GetTitle() + ", " + b.GetAuthor() + ": " +
            b.GetLocation());
    }
}
