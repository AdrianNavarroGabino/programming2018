// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class Book :IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
    
    public int CompareTo(Book b2)
    {
        return String.Compare(this.Title, b2.Title, true);
    }
    
    public override string ToString()
    {
        return "Title: " + Title + ", author: " + Author + ", pages: " + Pages;
    }
}

class BookCollection
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        string option;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Search book");
            Console.WriteLine("0. Exit");
            option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                    Console.Write("Enter the title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter the number of pages: ");
                    int pages = Convert.ToInt32(Console.ReadLine());
                    
                    books.Add(new Book(title, author, pages));
                    books.Sort();
                    
                    break;
                case "2":
                    Console.Write("Which book do you want to search? ");
                    string search = Console.ReadLine();
                    
                    foreach(Book b in books)
                        if(b.Title.Contains(search) ||
                            b.Author.Contains(search))
                            Console.WriteLine(b);
                    break;
                case "0":
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        } while(option != "0");
    }
}
