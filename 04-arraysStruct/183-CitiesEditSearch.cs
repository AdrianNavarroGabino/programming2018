// Adrián Navarro Gabino

using System;

public class Cities2
{
    struct city
    {
        public string name;
        public long population;
    }
        
    public static void Main()
    {
        const int SIZE = 1000;
        
        city[] c = new city[SIZE];
        
        int option;
        int count = 0;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a city");
            Console.WriteLine("2. See all cities");
            Console.WriteLine("3. Modify a city");
            Console.WriteLine("4. Search a city");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if(option == 1)
            {
                if(count < SIZE)
                {
                    Console.Write("Enter the name: ");
                    c[count].name = Console.ReadLine();
                    Console.Write("Enter the population: ");
                    c[count].population = Convert.ToInt64(Console.ReadLine());
                    
                    count++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Database full");
                }
            }
            
            else if(option == 2)
            {
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine("City number " + (i+1) + ":");
                    Console.WriteLine("Name: " + c[i].name);
                    Console.WriteLine("Population: " + c[i].population);
                    
                    Console.WriteLine();
                }
            }
            
            else if(option == 3)
            {
                Console.Write("Enter the city number: ");
                int cityNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                
                Console.Write("Enter the name (it was {0}): ",
                    c[cityNumber].name);
                string newName = Console.ReadLine();
                if(newName != "")
                {
                    c[cityNumber].name = newName;
                }
                
                Console.Write("Enter the population (it was {0}): ",
                    c[cityNumber].population);
                string newPopulation = Console.ReadLine();
                if(newPopulation != "")
                {
                    c[cityNumber].population = Convert.ToInt32(newPopulation);
                }
            }
            
            else if(option == 4)
            {
                Console.WriteLine("Enter the words you want to search:");
                string wordsToSearch = Console.ReadLine().ToUpper();
                
                Console.WriteLine();
                
                for(int i = 0; i < count; i++)
                {
                    if(c[i].name.ToUpper().Contains(wordsToSearch))
                    {
                        Console.WriteLine("City number " + (i+1) + ":");
                        Console.WriteLine("Name: " + c[i].name);
                        Console.WriteLine("Population: " + c[i].population);
                        
                        Console.WriteLine();
                    }
                }
                
            }
        } while(option != 0);
    }
}
