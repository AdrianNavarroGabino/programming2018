// Adrián Navarro Gabino

using System;

class Book
{
    private string title;
    private string author;
    private string location;
    
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }
    
    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }
    
    public string Location
    {
        get
        {
            return location;
        }
        set
        {
            location = value;
        }
    }
    
    public Book(string newTitle, string newAuthor,
        string newLocation)
    {
        Title = newTitle;
        Author = newAuthor;
        Location = newLocation;
    }
    
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Location = "Unknown";
    }
}

class BookTest
{
    static void Main()
    {
        Book b = new Book();
        
        b.Title = "It";
    }
}
