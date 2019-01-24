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
        Document[] d = new Document[3];
        
        d[0] = new Document("It", "Stephen King", 1100);
        d[1] = new Document("Momo", "Michael Ende", 300);
        d[2] = new Document("How to be an alien", "Mikes George", 100);
        
        Console.WriteLine("Pages: " + d[0].GetPages());
        Console.WriteLine("Pages: " + d[1].GetPages());
        Console.WriteLine("Pages: " + d[2].GetPages());
    }
}
