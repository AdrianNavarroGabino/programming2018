// Display many asterisks
// Adrián Navarro Gabino

using System;

public class Asterisks
{
    public static void Main()
    {
        Console.Write("How many asterisks? ");
        int numberOfAsterisks = Convert.ToInt32(Console.ReadLine());
        
        int count = 0;
        
        while(count < numberOfAsterisks)
        {
            count++;
            Console.Write("*");
        }
        
        Console.WriteLine();
    }
}
