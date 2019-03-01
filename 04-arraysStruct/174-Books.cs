// Adrián Navarro Gabino

using System;

public class Books
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
        
        
        book b1;
        
        Console.Write("Enter the title: ");
        b1.title = Console.ReadLine();
        Console.Write("Enter the author: ");
        b1.author = Console.ReadLine();
        Console.Write("Enter the year of your edition: ");
        b1.year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is electronic?(y/n): ");
        b1.isElectronic = Console.ReadLine() == "y" ? true : false;
    }
}
