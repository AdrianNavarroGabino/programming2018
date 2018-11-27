// Repetitions descending
// Adrián Navarro Gabino

using System;

public class Printing8642
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
        {
            for(int j = 8; j >= 2; j -= 2)
                Console.Write(j);
            Console.WriteLine();
        }
    }
}
