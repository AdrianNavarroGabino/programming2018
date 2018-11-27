// Hollow Rectangle
// Adrián Navarro Gabino

using System;

public class Figure
{
    public static void Main()
    {
        Console.WriteLine("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < width; i++)
            Console.Write("*");
        Console.WriteLine();
        
        for(int i = 0; i < (height - 2); i++)
        {
            Console.Write("*");
            for(int j = 0; j < (width - 2); j++)
                Console.Write(" ");
            Console.WriteLine("*");
        }
        
        for(int i = 0; i < width; i++)
            Console.Write("*");
        Console.WriteLine();
    }
}
