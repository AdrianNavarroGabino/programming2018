// Adrián Navarro Gabino

using System;

class Book
{
    private string title;
    private string author;
    private string location;
    
    public Book(string newTitle, string newAuthor,
        string newLocation)
    {
        title = newTitle;
        author = newAuthor;
        location = newLocation;
    }
    
    public void SetTitle(string newTitle) { title = newTitle; }
    public void SetAuthor(string newAuthor) { author = newAuthor; }
    public void SetLocation(string newLocation)
    {
        location = newLocation;
    }
    
    public string GetTitle() { return title; }
    public string GetAuthor() { return author; }
    public string GetLocation() { return location; }
}
