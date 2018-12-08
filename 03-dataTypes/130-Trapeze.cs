// Adrián Navarro Gabino

using System;

public class Trapeze
{
    public static void Main()
    {
        Console.Write("Width: ");
        byte width = Convert.ToByte(Console.ReadLine());
        Console.Write("Height: ");
        byte height = Convert.ToByte(Console.ReadLine());
        
        
        for(int row = 1; row <= height; row++)
        {
            for(int space = 1; space <= height - row; space++)
                Console.Write(" ");
            for(int asterisk = 1; asterisk <= width; asterisk++)
                Console.Write("*");
            width += 2;
            Console.WriteLine();
        }
    }
}
