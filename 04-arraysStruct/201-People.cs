// Adrián Navarro Gabino

using System;

public class People
{
    struct person
    {
        public string name;
        public string mail;
        public string address;
        public short birthYear;
    }

    public static void Main()
    {
        const int SIZE = 500;
        int count = 0;
        person[] p = new person[SIZE];
        string option = "";

        do
        {
            Console.WriteLine("Programs:");
            Console.WriteLine();
            Console.WriteLine("1- Add a new person");
            Console.WriteLine("2- Show all people");
            Console.WriteLine("3- Search a person by name");
            Console.WriteLine("4- Search a person by a year interval");
            Console.WriteLine("5- Show the oldest people");
            Console.WriteLine("6- Search a person by address");
            Console.WriteLine("7- Sort people by name");
            Console.WriteLine("T- Terminate application");
            Console.WriteLine();
            Console.WriteLine("Menu...");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1": // Add
                    if (count <= SIZE)
                    {
                        do
                        {
                            Console.Write("Enter the name: ");
                            p[count].name = Console.ReadLine();
                        }
                        while (p[count].name == "" &&
                            p[count].name.Length > 40);

                        Console.Write("Enter the e-mail: ");
                        p[count].mail = Console.ReadLine();

                        Console.Write("Enter the address: ");
                        p[count].address = Console.ReadLine();

                        Console.Write("Enter the year of birth: ");
                        p[count].birthYear = Convert.ToInt16(Console.ReadLine());

                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }

                    break;

                case "2": // Show all
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty.");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if(p[i].name.Length <= 30)
                            {
                                Console.WriteLine(i + ": " + p[i].name);
                            }
                            else
                            {
                                Console.WriteLine(i + ": " +
                                    p[i].name.Substring(0,30));
                            }
                            
                            if (i % 20 == 19)  // Pause after 20 lines
                                Console.ReadLine();
                        }
                    }
                    break;

                case "3": // Search
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(
                            "Which person do you want to find? ");
                        string search = Console.ReadLine();
                        Console.WriteLine();

                        int amountFound = 0;

                        for (int i = 0; i < count; i++)
                        {
                            if (p[i].name.ToUpper().Contains(search.ToUpper()))
                            {
                                Console.WriteLine("PERSON Nº{0}", i + 1);
                                Console.WriteLine("Name: {0}", p[i].name);
                                Console.WriteLine("E-mail: {0}", 
                                    p[i].mail);
                                Console.WriteLine("Address: {0}", 
                                    p[i].address);
                                Console.WriteLine("Year of birth: {0}", 
                                    p[i].birthYear);

                                amountFound++;
                            }
                        }

                        if (amountFound == 0)
                            Console.WriteLine(
                                "Can't find any person containing \"{0}\".",
                                search);

                        Console.WriteLine();
                    }
                    break;

                case "4": // Edit an entry
                    string nameByYear = "";
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(
                            "Enter the initial year you want to search: ");
                        short initialYear = Convert.ToInt16(Console.ReadLine());
                        Console.Write(
                            "Enter the final year you want to search: ");
                        short finalYear = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine();

                        int amountFound2 = 0;

                        for (int i = 0; i < count; i++)
                        {
                            if (p[i].birthYear >= initialYear &&
                                p[i].birthYear <= finalYear)
                            {
                                nameByYear += p[i].name;
                                nameByYear += "-";
                                
                                amountFound2++;
                            }
                        }
                        nameByYear = nameByYear.Remove(nameByYear.Length - 1,1);

                        if (amountFound2 == 0)
                            Console.WriteLine(
                                "Can't find any person born between \"{0}\""
                                + " and \"{1}\".", initialYear, finalYear);
                        else
                            Console.WriteLine(nameByYear);

                        Console.WriteLine();
                    }
                    break;

                case "5": // Delete
                    short lastYear = p[0].birthYear;
                    for(int i = 1; i < count; i++)
                    {
                        if(p[i].birthYear < lastYear)
                            lastYear = p[i].birthYear;
                    }
                    
                    Console.WriteLine("Oldest people:");
                    for(int i = 0; i < count; i++)
                    {
                        if(p[i].birthYear == lastYear)
                        {
                            Console.WriteLine(p[i].name);
                        }
                    }
                    Console.WriteLine();
                    break;

                case "6": // Sort
                    string goOn = "";
                    
                    if (count == 0)
                    {
                        Console.WriteLine("Database is empty");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(
                            "Which address do you want to find? ");
                        string searchAddress = Console.ReadLine();
                        Console.WriteLine();

                        int amountFound3 = 0;

                        int i = 0;
                        while (i < count || goOn != "fin")
                        {
                            if(p[i].name.ToUpper().Contains(searchAddress.ToUpper()))
                            {
                                Console.WriteLine("PERSON Nº{0}", i + 1);
                                Console.WriteLine("Name: {0}", p[i].name);
                                Console.WriteLine("E-mail: {0}", 
                                    p[i].mail);
                                Console.WriteLine("Address: {0}", 
                                    p[i].address);
                                Console.WriteLine("Year of birth: {0}", 
                                    p[i].birthYear);

                                amountFound3++;
                                
                                goOn = Console.ReadLine();
                                i++;
                            }
                        }

                        if (amountFound3 == 0)
                            Console.WriteLine(
                                "Can't find any person containing \"{0}\".",
                                searchAddress);

                        Console.WriteLine();
                    }
                    break;

                case "7":
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            if (p[i].name.CompareTo(p[j].name) > 0)
                            {
                                person aux = p[i];
                                p[i] = p[j];
                                p[j] = aux;
                            }
                        }
                    }
                    break;

                case "T": // Quit
                case "Q":
                    Console.WriteLine("Bye!!!");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;
            }

        }
        while ((option != "T") && (option != "Q"));
    }
}
