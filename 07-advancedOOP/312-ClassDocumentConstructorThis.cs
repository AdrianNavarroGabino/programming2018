// Adrián Navarro Gabino

using System;

class Document
{
    protected string title;
    protected string author;
    protected int pages;
    
    public void SetTitle(string title) { this.title = title; }
    public void SetAuthor(string author) { this.author = author; }
    public void Setpages(int pages)
    {
        this.pages = pages;
    }
    
    public string GetTitle() { return title; }
    public string GetAuthor() { return author; }
    public int GetPages() { return pages; }
    
    public Document(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
    
    public Document(string title) : this(title, "Unknown", 0)
    {
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
