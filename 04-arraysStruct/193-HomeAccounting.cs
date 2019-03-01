// Adrián Navarro Gabino

using System;

public class HomeAccounting
{
    struct transaction
    {
        public string date;
        public string description;
        public string category;
        public int import;
    }

    public static void Main()
    {
        const int SIZE = 1000;
        transaction[] o = new transaction[SIZE];
        int currentPosition = 0;
        string option;

        do
        {
            Console.WriteLine("Enter option (type \"T\" to exit):");
            Console.WriteLine();
            Console.WriteLine("1- Add new transaction");
            Console.WriteLine("2- Show all transactions");
            Console.WriteLine("3- Search transactions");
            Console.WriteLine("4- Modify transaction");
            Console.WriteLine("5- Delete transaction");
            Console.WriteLine();
            Console.Write("Option? ");
            option = Console.ReadLine();
            Console.WriteLine();
            switch (option)
            {
                case "1":
                    if (currentPosition < SIZE)
                    {
                        Console.Write("Enter date (YYYYMMDD): ");
                        o[currentPosition].date = Console.ReadLine();
                        Console.Write("Enter description: ");
                        // Description cannot be empty
                        string description = Console.ReadLine();
                        while (description == "")
                        {
                            Console.Write("Please enter description again: ");
                            description = Console.ReadLine();
                        }
                        o[currentPosition].description = description;
                        Console.Write("Enter category: ");
                        o[currentPosition].category = Console.ReadLine();
                        Console.Write("Enter import: ");
                        o[currentPosition].import = 
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        currentPosition++;
                    }
                    else
                    {
                        Console.WriteLine("DB full.");
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    Console.WriteLine("Which category? ");
                    string category = Console.ReadLine();
                    // TO DO: Filter by dates
                    for (int i = 0; i < currentPosition; i++)
                    {
                        if (category == o[i].category)
                        {
                            Console.WriteLine("OPERATION Nº{0}", i + 1);
                            Console.WriteLine("Date: " + o[i].date);
                            Console.WriteLine("Description: " + o[i].description);
                            Console.WriteLine("Category: " + o[i].category);
                            Console.WriteLine("Import: " + o[i].import);
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    Console.Write("Enter search term: ");
                    string search = Console.ReadLine().ToUpper();
                    bool found = false;
                    for (int i = 0; i < currentPosition; i++)
                    {
                        if (o[i].description.ToUpper().Contains(search.ToUpper())
                           || o[i].category.ToUpper().Contains(search.ToUpper()))
                        {
                            Console.WriteLine("OPERATION Nº{0}", i + 1);
                            Console.WriteLine("Description: " + o[i].description);
                            Console.WriteLine("Category: " + o[i].category);
                            Console.WriteLine("Import: " + o[i].import);
                            Console.WriteLine("Date: " + o[i].date);
                            Console.WriteLine();
                            found = true;
                        }
                    }
                    if (! found)
                        Console.WriteLine("Not found.");
                    break;
                case "4":
                    Console.Write("Enter record number: ");
                    int pos = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (pos >= 0 && pos < currentPosition)
                    {
                        string user;

                        Console.WriteLine("Description: " + o[pos].description);
                        Console.Write("New description: ");
                        user = Console.ReadLine();
                        if (user == "")
                        {
                            o[pos].description = user;
                        }

                        Console.WriteLine("Date: " + o[pos].date);
                        Console.Write("New date: ");
                        user = Console.ReadLine();

                        if (user != "")
                        {
                            o[pos].date = user;
                        }

                        Console.WriteLine("Category: " + o[pos].category);
                        Console.Write("New category: ");
                        user = Console.ReadLine();

                        if (user != "")
                        {
                            o[pos].category = user;
                        }

                        Console.WriteLine("Import: " + o[pos].import);
                        Console.Write("New import: ");
                        user = Console.ReadLine();

                        if (user != "")
                        {
                            o[pos].import = Convert.ToInt32(user);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid record number!");
                        Console.WriteLine();
                    }

                    break;
                case "5":
                    Console.Write("Enter position to delete: ");
                    Console.WriteLine();
                    int positionDelete = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (positionDelete <= currentPosition
                            && positionDelete > 0)
                    {

                        for (int i = positionDelete; i < currentPosition; i++)
                        {
                            o[i] = o[i+1];
                        }
                        currentPosition--;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number");
                        Console.WriteLine();
                    }

                    break;
                case "6":
                    Console.Write("Sorting not implemented yet");
                    break;
                default:
                    Console.Write("Wrong option");
                    break;
            }
        } while (option != "T");
    }
}
