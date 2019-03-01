// Adrián Navarro Gabino

using System;

public class BooksManagement
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
        const int SIZE = 1000;
        
        book[] b = new book[SIZE];
        
        int option;
        int count = 0;
        string wordsToSearch;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Search a book");
            Console.WriteLine("3. See all books");
            Console.WriteLine("4. Modify a book");
            Console.WriteLine("5. Delete a book");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        
            switch(option)
            {
                case 1:
                    if(count < SIZE)
                    {
                        Console.Write("Enter the title: ");
                        string auxAdd = Console.ReadLine();
                        while(auxAdd == "")
                        {
                            auxAdd = Console.ReadLine();
                        }
                        b[count].title = auxAdd;
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
                    
                    break;
                case 2:
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
                    
                    break;
                case 3:
                    for(int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Book number " + (i+1) + ":");
                        Console.WriteLine("Title: " + b[i].title);
                        Console.WriteLine("Author: " + b[i].author);
                        Console.WriteLine("Year: " + b[i].year);
                        Console.WriteLine(b[i].isElectronic ? "Electronic" : "Paper");
                        
                        Console.WriteLine();
                        if(i % 22 == 21)
                        {
                            Console.ReadLine();
                        }
                    }
                    
                    break;
                case 4:
                    Console.Write("Enter the position you want to modify: ");
                    int position = Convert.ToInt32(Console.ReadLine()) - 1;
                    string aux;
                    
                    Console.WriteLine();
                    Console.WriteLine("Book: {0}", b[position].title);
                    Console.Write("Enter the title: ");
                    aux = Console.ReadLine();
                    if(aux != "")
                    {
                        b[position].title = aux;
                    }
                    
                    Console.Write("Enter the author: ");
                    aux = Console.ReadLine();
                    if(aux != "")
                    {
                        b[position].author = aux;
                    }
                    
                    Console.Write("Enter the year of your edition: ");
                    aux = Console.ReadLine();
                    if(aux != "")
                    {
                        b[position].year = Convert.ToInt32(aux);
                    }
                    
                    Console.Write("Is electronic?(y/n): ");
                    aux = Console.ReadLine();
                    if(aux != "")
                    {
                        b[count].isElectronic = aux.ToLower() == "y";
                    }
                    
                    break;
                case 5:
                    Console.WriteLine("Enter index to delete: ");
                    int posDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posDelete < 0 || posDelete > count)
                        Console.WriteLine("Error, wrong number!");
                    else
                    {
                        for (int i = posDelete; i < count; i++)
                        {
                            b[i] = b[i + 1];
                        }
                        count--;
                    }
                    break;
            }
        } while(option != 0);
    }
}
