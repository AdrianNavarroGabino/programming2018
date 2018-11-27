// Centered Triangle
// Adrián Navarro Gabino

using System;

public class CenteredTriangle
{
    public static void Main()
    {
        int size;

        Console.Write("Enter the size of the base: ");
        size = Convert.ToInt32(Console.ReadLine());

        int spaces = size / 2;
        int asterisks = size % 2 == 0 ? 2 : 1;
        int maxRow = size % 2 == 0 ? size / 2 : size / 2 + 1;

        for (int row = 1; row <= maxRow; row++)
        {
            for (int space = 1; space <= spaces; space++)
                Console.Write(" ");

            for (int asterisk = 1; asterisk <= asterisks; asterisk++)
                Console.Write("*");

            Console.WriteLine();
            
            spaces--;
            asterisks = asterisks + 2;
        }
    }
}
