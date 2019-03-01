// Adrián Navarro Gabino

using System;

public class Computers
{
    struct computer
    {
        public string brand;
        public string model;
        public int year;
        public ram capacity;
        public string comment;
    }

    struct ram
    {
        public string units;
        public int size;
    }
    public static void Main()
    {
        const int SIZE = 600;
        int count = 0;
        string option;
        string textToSearch;
        bool found;
        int positionModify;
        string modifyAux;
        int positionDelete;
        int positionInsert;
        computer sortAux;

        computer[] c = new computer[SIZE];

        const string ADD_COMPUTER = "1";
        const string SHOW_ALL = "2";
        const string SEARCH = "3";
        const string MODIFY = "4";
        const string DELETE = "5";
        const string INSERT = "6";
        const string SORT = "7";
        const string DELETE_SPACES = "8";
        const string QUIT = "Q";

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a computer");
            Console.WriteLine("2. Show all");
            Console.WriteLine("3. Search a computer");
            Console.WriteLine("4. Modify a computer");
            Console.WriteLine("5. Delete a computer");
            Console.WriteLine("6. Insert a computer in a position");
            Console.WriteLine("7. Sort by brand + model");
            Console.WriteLine("8. Delete additional spaces");
            Console.WriteLine("Q. Quit");
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case ADD_COMPUTER:
                    if (count < SIZE)
                    {
                        Console.WriteLine("Computer number {0}", count + 1);

                        do
                        {
                            Console.Write("Enter the computer brand: ");
                            c[count].brand = Console.ReadLine();

                            if (c[count].brand == "")
                            {
                                Console.WriteLine("Brand can't be empty");
                            }
                        } while (c[count].brand == "");

                        do
                        {
                            Console.Write("Enter the model (+50 characters): ");
                            c[count].model = Console.ReadLine();

                            if (c[count].model.Length < 50)
                            {
                                Console.WriteLine(
                                    "Model must have more than 50 characters");
                            }
                        } while (c[count].model.Length < 50);

                        Console.Write("Enter the year: ");
                        c[count].year = Convert.ToInt32(Console.ReadLine());
                        if (c[count].year < 1900)
                            c[count].year = 0;

                        Console.Write("Enter the memory unit (mB, gB...): ");
                        c[count].capacity.units = Console.ReadLine();
                        Console.Write("Enter the amount of {0}: ",
                            c[count].capacity.units);
                        c[count].capacity.size = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter comments: ");
                        c[count].comment = Console.ReadLine();
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }

                    Console.WriteLine();
                    break;

                case SHOW_ALL:
                    if (count == 0)
                    {
                        Console.WriteLine("Not stored computers");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Computer #{0}: {1} - {2}",
                                i + 1, c[i].brand, c[i].model);

                            if (i % 24 == 23)
                            {
                                Console.Write("Press Intro to continue ");
                            }
                        }
                    }
                    Console.WriteLine();
                    break;

                case SEARCH:
                    Console.Write("Which computer do you want to search? ");
                    textToSearch = Console.ReadLine();

                    found = false;

                    for (int i = 0; i < count; i++)
                    {
                        if (c[i].brand.ToUpper().Contains(textToSearch.ToUpper())
                           || c[i].model.ToUpper().Contains(textToSearch.ToUpper())
                           || c[i].comment.ToUpper().Contains(textToSearch.ToUpper()))
                        {
                            found = true;

                            Console.WriteLine("Brand: " + c[i].brand);
                            Console.WriteLine("Model: " + c[i].model);
                            if (c[i].year != 0)
                                Console.WriteLine("Year: Unknown year");
                            else
                            {
                                Console.WriteLine("Year: " + c[i].year);
                            }
                            Console.WriteLine("RAM: " + c[i].capacity.size +
                                c[i].capacity.units);
                            Console.WriteLine("Comments: " + c[i].comment);
                            Console.WriteLine();
                        }
                    }

                        if (!found)
                        {
                            Console.WriteLine("Computer not found");
                            Console.WriteLine();
                        }
                        break;
                case MODIFY:
                    Console.Write("Enter the position to modify: ");
                    positionModify = Convert.ToInt32(Console.ReadLine()) - 1;
                    if(positionModify >= count)
                    {
                        Console.WriteLine("Wrong position");
                    }
                    else
                    {
                        Console.WriteLine("Computer #{0}", positionModify+1);
                        Console.WriteLine("Brand: " + c[positionModify].brand);
                        Console.Write("New brand: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            c[positionModify].brand = modifyAux;
                        }

                        Console.WriteLine("Model: " + c[positionModify].model);
                        if (c[positionModify].year != 0)
                            Console.WriteLine("Year: Unknown year");
                        else
                        {
                            Console.WriteLine("Year: " + c[positionModify].year);
                        }
                        Console.Write("New model: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            c[positionModify].model = modifyAux;
                        }

                        Console.WriteLine("RAM: " + c[positionModify].capacity.size +
                            c[positionModify].capacity.units);
                        Console.Write("New RAM units: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            c[positionModify].capacity.units = modifyAux;
                        }
                        Console.Write("New RAM size: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            c[positionModify].capacity.size = Convert.ToInt32(modifyAux);
                        }

                        Console.WriteLine("Comments: " + c[positionModify].comment);
                        Console.WriteLine("New comments: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            c[positionModify].comment = modifyAux;
                        }

                        Console.WriteLine();
                    }
                    break;
                case DELETE:
                    Console.Write("Enter position to delete: ");
                    positionDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                    if(positionDelete >= count)
                    {
                        Console.WriteLine("Wrong position");
                    }
                    else
                    {
                        for(int i = positionDelete; i < count; i++)
                        {
                            Console.WriteLine(c[i].brand + " - " + c[i].model + " deleted");
                            
                            c[i] = c[i + 1];
                        }
                        count--;
                    }

                    Console.WriteLine();
                    break;
                case INSERT:
                    Console.Write("Enter position to insert a computer: ");
                    positionInsert = Convert.ToInt32(Console.ReadLine()) - 1;

                    if(positionInsert >= count)
                    {
                        Console.WriteLine("Wrong position");
                    }
                    else
                    {
                        for(int i = count - 1; i >= positionInsert; i--)
                        {
                            c[i] = c[i + 1];
                        }

                        Console.WriteLine("Brand: " + c[positionInsert].brand);
                        Console.WriteLine("Model: " + c[positionInsert].model);
                        if (c[positionInsert].year != 0)
                            Console.WriteLine("Year: Unknown year");
                        else
                        {
                            Console.WriteLine("Year: " + c[positionInsert].year);
                        }
                        Console.WriteLine("RAM: " + c[positionInsert].capacity.size +
                            c[positionInsert].capacity.units);
                        Console.WriteLine("Comments: " + c[positionInsert].comment);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case SORT:
                    for(int i = 0; i < count - 1; i++)
                    {
                        for(int j = i + 1; j < count; j++)
                        {
                            if(c[i].brand.ToUpper().CompareTo(c[j].brand.ToUpper()) > 0)
                            {
                                sortAux = c[i];
                                c[i] = c[j];
                                c[j] = sortAux;
                            }
                            else if(c[i].brand.ToUpper().CompareTo(c[j].brand.ToUpper()) == 0)
                            {
                                if (c[i].model.ToUpper().CompareTo(c[j].model.ToUpper()) > 0)
                                {
                                    sortAux = c[i];
                                    c[i] = c[j];
                                    c[j] = sortAux;
                                }
                            }
                        }
                    }

                    Console.WriteLine("Computers sorted by brand+model");
                    Console.WriteLine();
                    break;
                case DELETE_SPACES:
                    for(int i = 0; i < count; i++)
                    {
                        while(c[i].brand.Contains("  "))
                        {
                            c[i].brand.Replace("  ", " ");
                        }

                        while (c[i].model.Contains("  "))
                        {
                            c[i].model.Replace("  ", " ");
                        }

                        while (c[i].comment.Contains("  "))
                        {
                            c[i].comment.Replace("  ", " ");
                        }

                        c[i].brand.TrimEnd();
                        c[i].brand.TrimStart();
                        c[i].model.TrimEnd();
                        c[i].model.TrimStart();
                        c[i].comment.TrimEnd();
                        c[i].comment.TrimStart();
                    }

                    Console.WriteLine("Additional spaces deleted");
                    Console.WriteLine();
                    break;
                case QUIT:
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        } while (option != QUIT);

    }
}

