// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

public class BooksListStructSort
{
    struct Book : IComparable<Book>
    {
        public string title;
        public string author;
        public ushort year;
        public bool isElectronic;
        
        public int CompareTo(Book b2)
        {
            if(this.title != b2.title)
                return String.Compare(this.title, b2.title, true);
            else
                return String.Compare(this.author, b2.author, true);
        }
    }
    public static void Main()
    {
        List<Book> b = new List<Book>();
        string option, search;
        
        do
        {
            // Show menu
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("3. Search book by title or author");
            Console.WriteLine("4. Edit a book");
            Console.WriteLine("5. Delete a book");
            Console.WriteLine("0. Exit");
            option = Console.ReadLine();
            Console.WriteLine();
            
            switch(option)
            {
                case "1": // Add new book
                    try
                    {
                        Book book;
                        
                        do
                        {
                            Console.Write("Enter the title: ");
                            book.title = Console.ReadLine();
                            if (book.title == "")
                                Console.WriteLine("The title cannot be empty");
                        }while(book.title == "");
                        
                        Console.Write("Enter the author: ");
                        book.author = Console.ReadLine();
                        Console.Write(
                            "Enter the year of your edition: ");
                        book.year = 
                            Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Is electronic (y/n): ");
                        book.isElectronic = 
                            Console.ReadLine() == "y";
                        
                        b.Add(book);
                        b.Sort();
                        
                        Console.WriteLine();
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Database full");
                    }
                    break;
                    
                case "2": // Show all books
                    if (b.Count == 0)
                    {
                        Console.WriteLine("Database is empty.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for(int i = 0; i < b.Count ; i++)
                        {
                            Console.WriteLine("Book {0}", i+1);
                            Console.WriteLine("Title: " + b[i].title);
                            Console.WriteLine("Author: " + b[i].author);
                            Console.WriteLine("Year: " + b[i].year);
                            Console.WriteLine("Format: {0}" ,
                                b[i].isElectronic ? "Electronic":"Paper");
                               
                            Console.WriteLine();
                            
                            if (i % 20 == 21)  // Pause after 22 lines
                                Console.ReadLine();
                        }
                    }
                    break;
                    
                case "3": // Search book by title or author
                    Console.Write("Enter data to search: ");
                    search = Console.ReadLine().ToUpper();
                    
                    Console.WriteLine();
                    
                    for(int i = 0; i < b.Count; i++)
                    {
                        if(b[i].title.ToUpper().Contains(search) ||
                            b[i].author.ToUpper().Contains(search))
                        {
                            Console.WriteLine("Book number " + (i+1));
                            Console.WriteLine("Title: " + b[i].title);
                            Console.WriteLine("Author: " + b[i].author);
                            Console.WriteLine("Year: " + b[i].year);
                            Console.WriteLine(
                                b[i].isElectronic?"Electronic":"Paper");
                            
                            Console.WriteLine();
                        }
                    }
                    break;
                    
                case "4": // Edit a book
                    Console.WriteLine("Enter index to edit: ");
                    int posEdit = Convert.ToInt32(Console.ReadLine())-1;
                    if (posEdit < 0 || posEdit > b.Count - 1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        Book bookEdit;
                        
                        Console.WriteLine("New title (it was {0}): ", 
                            b[posEdit].title);
                        string newData = Console.ReadLine();
                        if (newData != "")
                            bookEdit.title = newData;
                        else
                            bookEdit.title = b[posEdit].title;

                        Console.WriteLine("New author (it was {0}): ",
                            b[posEdit].author);
                        newData = Console.ReadLine();
                        if (newData != "")
                            bookEdit.author = newData;
                        else
                            bookEdit.author = b[posEdit].author;

                        Console.WriteLine("New year (it was {0}): ",
                            b[posEdit].year);
                        newData = Console.ReadLine();
                        if (newData != "")
                            bookEdit.year = Convert.ToUInt16(newData);
                        else
                            bookEdit.year = b[posEdit].year;
                    }
                    break;
                    
                case "5": // Delete a book
                    Console.WriteLine("Enter index to delete: ");
                    int posDelete = Convert.ToInt32(Console.ReadLine())-1;
                    if (posDelete < 0 || posDelete > b.Count - 1)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        for (int i = posDelete; i < b.Count; i++)
                        {
                            b[i] = b[i + 1];
                        }
                    }
                    break;
            }
        }while(option != "0");
    }
}
