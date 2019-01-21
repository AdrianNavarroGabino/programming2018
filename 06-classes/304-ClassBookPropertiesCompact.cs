// Adrián Navarro Gabino

using System;

class Book
{
    public string Title { get;set; }
    public string Author { get;set; }
    public string Location { get;set; }
    
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
