// Adrián Navarro Gabino

using System;

public class BooksManagement
{
    public struct book
    {
        public string title;
        public string author;
        public int year;
        public bool isElectronic;
    }
    
    const int SIZE = 1000;
    static book[] b;
    
    static int count = 0;
    
    public static void Init()
    {
        b = new book[SIZE];
    }
    
    public static void Add(int count, book[] b)
    {
        if(count < SIZE)
        {
            Console.Write("Enter the title: ");
            b[count].title = Console.ReadLine();
            Console.Write("Enter the author: ");
            b[count].author = Console.ReadLine();
            Console.Write("Enter the year of your edition: ");
            b[count].year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is electronic?(y/n): ");
            b[count].isElectronic = Console.ReadLine().ToLower() == "y";
            
            count++;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Database full");
        }
    }
    
    public static void Search(int count, string wordsToSearch, book[] b)
    {
        Console.WriteLine("Enter the words you want to search:");
        wordsToSearch = Console.ReadLine();
        
        Console.WriteLine();
        
        for(int i = 0; i < count; i++)
        {
            if(b[i].title.Contains(wordsToSearch) ||
                b[i].author.Contains(wordsToSearch))
            {
                Console.WriteLine("Book number " + (i+1) + ":");
                Console.WriteLine("Title: " + b[i].title);
                Console.WriteLine("Author: " + b[i].author);
                Console.WriteLine("Year: " + b[i].year);
                Console.WriteLine(b[i].isElectronic ? "Electronic" : "Paper");
                
                Console.WriteLine();
            }
        }
    }
    
    public static void SeeAll(int count, book[] b)
    {
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Book number " + (i+1) + ":");
            Console.WriteLine("Title: " + b[i].title);
            Console.WriteLine("Author: " + b[i].author);
            Console.WriteLine("Year: " + b[i].year);
            Console.WriteLine(b[i].isElectronic ? "Electronic" : "Paper");
            
            Console.WriteLine();
        }
    }
        
    public static void Main()
    {
        Init();
        
        int option;
        
        string wordsToSearch = "";
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Search a book");
            Console.WriteLine("3. See all books");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        
            if(option == 1)
            {
                Add(count,b);
            }
            else if(option == 2)
            {
                Search(count, wordsToSearch,b);
            }
            else if(option == 3)
            {
                SeeAll(count,b);
            }
        } while(option != 0);
    }
}
