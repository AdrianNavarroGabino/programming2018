using System;

public class Cities
{
    struct city
    {
        public string name;
        public long population;
    }

    public static void Main()
    {
        int option;
        const int SIZE = 1000;
        city[] c = new city[SIZE];
        int countCities = 0;
        int deletePosition;
        int insertPosition;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add a city");
            Console.WriteLine("2. View all cities");
            Console.WriteLine("3. Edit a city");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Delete a city");
            Console.WriteLine("6. Insert a city in a position");
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: // Add a new city
                    if (countCities < SIZE)
                    {
                        Console.Write("Enter name of city: ");
                        c[countCities].name = Console.ReadLine();

                        Console.Write("Enter population of city: ");
                        c[countCities].population = Convert.ToInt32(
                            Console.ReadLine());
                        countCities++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;

                case 2: // View all the cities
                    for (int i = 0; i < countCities; i++)
                    {
                        Console.WriteLine("City {0}:", i + 1);
                        Console.WriteLine("Name: {0}", c[i].name);
                        Console.WriteLine("Population: {0}",
                            c[i].population);
                    }
                    break;

                case 3: // Edit a city
                    Console.Write("Which city do you want to edit? ");
                    int cityToEdit = Convert.ToInt32(Console.ReadLine())-1;

                    Console.Write("Enter name of city (it was {0}): ",
                        c[cityToEdit].name);
                    string newName = Console.ReadLine();
                    if (newName != "")
                        c[cityToEdit].name = newName;

                    Console.Write("Enter population of city (it was {0}): ",
                        c[cityToEdit].population);
                    string newPopulationAsString = Console.ReadLine();
                    if (newPopulationAsString != "")
                        c[cityToEdit].population = Convert.ToInt32(
                            newPopulationAsString);

                    break;

                case 4: // Search in cities
                    Console.Write("Which text do you want to find? ");
                    string search = Console.ReadLine().ToUpper();
                    for (int i = 0; i < countCities; i++)
                    {
                        if (c[i].name.ToUpper().Contains(search))
                        {
                            Console.WriteLine("City {0}:", i + 1);
                            Console.WriteLine("Name: {0}", c[i].name);
                            Console.WriteLine("Population: {0}",
                                c[i].population);
                        }
                    }
                    break;
                
                case 5:
                    Console.Write("Which city do you want to delete?"
                        + " (position): ");
                    deletePosition = Convert.ToInt32(Console.ReadLine()) - 1;
                    if(deletePosition < countCities)
                    {
                        for(int i = deletePosition; i < countCities; i++)
                        {
                            c[i].name = c[i+1].name;
                            c[i].population = c[i+1].population;
                        }
                        countCities--;
                    }
                    else
                    {
                        Console.WriteLine("Wrong position");
                    }
                    break;
                
                case 6:
                    Console.Write("Enter the position: ");
                    insertPosition = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    for(int i = countCities - 1; i >= insertPosition; i--)
                    {
                        c[i].name = c[i + 1].name;
                        c[i].population = c[i+1].population;
                    }
                    countCities++;
                    
                    Console.Write("Enter name of city: ");
                    c[insertPosition].name = Console.ReadLine();
                    
                    Console.Write("Enter population of city: ");
                    c[insertPosition].population = Convert.ToInt32(
                        Console.ReadLine());
                    break;
            }
        }
        while (option != 0);
    }
}
