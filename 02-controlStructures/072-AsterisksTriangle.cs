// Triangle made of asterisks
// Adrián Navarro Gabino

using System;

public class AsterisksTriangle
{
    public static void Main()
    {
        Console.Write("Size? ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= size; i++)
        {
            for(int asterisks = 1; asterisks <= i; asterisks++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
