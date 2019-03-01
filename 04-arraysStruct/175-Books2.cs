// Adrián Navarro Gabino

using System;

public class Books2
{
    struct book
    {
        public string title;
        public string author;
        public int year;
        public bool isElectronic;
    }
        
    public static void Main()
    {
        const int SIZE = 3;
        
        book[] b = new book[SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the title: ");
            b[i].title = Console.ReadLine();
            Console.Write("Enter the author: ");
            b[i].author = Console.ReadLine();
            Console.Write("Enter the year of your edition: ");
            b[i].year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is electronic?(y/n): ");
            b[i].isElectronic = Console.ReadLine().ToLower() == "y";
            
            Console.WriteLine();
        }
        
        for(int i = 0; i < SIZE; i++)
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
