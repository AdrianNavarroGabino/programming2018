// Right-aligned Triangle
// Adrián Navarro Gabino

using System;

public class AsterisksTriangle2
{
    public static void Main()
    {
        Console.Write("Size? ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= size; i++)
        {
            for(int asterisks = 1; asterisks <= size - i; asterisks++)
                Console.Write(" ");
            for(int asterisks = 1; asterisks <= i; asterisks++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
