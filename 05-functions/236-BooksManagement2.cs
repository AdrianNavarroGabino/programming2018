// Adrián Navarro Gabino

using System;

public class BooksManagement2
{
    public struct books
    {
        public string title;
        public string author;
        public ushort year;
        public bool isElectronic;
    }

    const int SIZE = 1000;
    static books[] b;
    static int count = 0;
    static string search = "";

    public static void Init()
    {
        b = new books[SIZE];
    }

    public static void Add(int count, books[] b)
    {
        if (count < SIZE)
        {
            do
            {
                Console.Write("Enter the title: ");
                b[count].title = Console.ReadLine();
                if (b[count].title == "")
                    Console.WriteLine("The title cannot be empty");
            } while (b[count].title == "");

            Console.Write("Enter the author: ");
            b[count].author = Console.ReadLine();
            Console.Write(
                "Enter the year of your edition: ");
            b[count].year =
                Convert.ToUInt16(Console.ReadLine());
            Console.Write("Is electronic (y/n): ");
            b[count].isElectronic =
                Console.ReadLine() == "y";

            count++;
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Database full");
        }
    }

    public static void ShowAll(int count, books[] b)
    {
        if (count == 0)
        {
            Console.WriteLine("Database is empty.");
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Book {0}", i + 1);
                Console.WriteLine("Title: " + b[i].title);
                Console.WriteLine("Author: " + b[i].author);
                Console.WriteLine("Year: " + b[i].year);
                Console.WriteLine("Format: {0}",
                    b[i].isElectronic ? "Electronic" : "Paper");

                Console.WriteLine();

                if (i % 20 == 21)  // Pause after 22 lines
                    Console.ReadLine();
            }
        }
    }

    public static void Search(int count, books[] b, string search)
    {
        Console.Write("Enter data to search: ");
        search = Console.ReadLine().ToUpper();

        Console.WriteLine();

        for (int i = 0; i < count; i++)
        {
            if (b[i].title.ToUpper().Contains(search) ||
                b[i].author.ToUpper().Contains(search))
            {
                Console.WriteLine("Book number " + (i + 1));
                Console.WriteLine("Title: " + b[i].title);
                Console.WriteLine("Author: " + b[i].author);
                Console.WriteLine("Year: " + b[i].year);
                Console.WriteLine(
                    b[i].isElectronic ? "Electronic" : "Paper");

                Console.WriteLine();
            }
        }
    }

    public static void Edit(int count, books[] b)
    {
        Console.WriteLine("Enter index to edit: ");
        int posEdit = Convert.ToInt32(Console.ReadLine()) - 1;
        if (posEdit < 0 || posEdit > count - 1)
            Console.WriteLine("Error, wrong number!");
        else
        {
            Console.WriteLine("New title (it was {0}): ",
                b[posEdit].title);
            string newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].title = newData;

            Console.WriteLine("New author (it was {0}): ",
                b[posEdit].author);
            newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].author = newData;

            Console.WriteLine("New year (it was {0}): ",
                b[posEdit].year);
            newData = Console.ReadLine();
            if (newData != "")
                b[posEdit].year = Convert.ToUInt16(newData);
        }
    }

    public static void Delete(int count, books[] b)
    {
        Console.WriteLine("Enter index to delete: ");
        int posDelete = Convert.ToInt32(Console.ReadLine()) - 1;
        if (posDelete < 0 || posDelete > count - 1)
            Console.WriteLine("Error, wrong number!");
        else
        {
            for (int i = posDelete; i < count; i++)
            {
                b[i] = b[i + 1];
            }
            count--;
        }
    }



    public static void Main()
    {
        Init();
        string option;

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

            switch (option)
            {
                case "1": // Add new book
                    Add(count, b);
                    break;

                case "2": // Show all books
                    ShowAll(count, b);
                    break;

                case "3": // Search book by title or author
                    Search(count, b, search);
                    break;

                case "4": // Edit a book
                    Edit(count, b);
                    break;

                case "5": // Delete a book
                    Delete(count, b);
                    break;
            }
        } while (option != "0");
    }
}

