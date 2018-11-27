// Display many asterisks (for)
// Adrián Navarro Gabino

using System;

public class AsterisksFor
{
    public static void Main()
    {
        Console.Write("How many asterisks? ");
        int amount = Convert.ToInt32(Console.ReadLine());
        
        for (int count = 1; count <= amount; count = count + 1)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
