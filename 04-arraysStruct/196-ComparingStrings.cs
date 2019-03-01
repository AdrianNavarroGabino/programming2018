// Adrián Navarro Gabino

using System;

public class ComparingStrings
{
    public static void Main()
    {
        const int SIZE = 5;
        string[] names = new string[SIZE];
        string aux;
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the name number {0}: ", i+1);
            names[i] = Console.ReadLine();
        }
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i + 1; j < SIZE; j++)
            {
                if(names[i].CompareTo(names[j]) > 0)
                {
                    aux = names[i];
                    names[i] = names[j];
                    names[j] = aux;
                }
            }
        }
        
        foreach(string n in names)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
