// Adrián Navarro Gabino

using System;

class Document
{
    protected string title;
    protected string author;
    protected int pages;
    
    public void SetTitle(string newTitle) { title = newTitle; }
    public void SetAuthor(string newAuthor) { author = newAuthor; }
    public void Setpages(int newPages)
    {
        pages = newPages;
    }
    
    public string GetTitle() { return title; }
    public string GetAuthor() { return author; }
    public int GetPages() { return pages; }
    
    public Document(string newTitle, string newAuthor, int newPages)
    {
        title = newTitle;
        author = newAuthor;
        pages = newPages;
    }
}

class DocumentTest
{
    static void Main()
    {
        Document d = new Document("Unknown", "Unknown", 5);
        Console.WriteLine("Pages: " + d.GetPages());
    }
}
