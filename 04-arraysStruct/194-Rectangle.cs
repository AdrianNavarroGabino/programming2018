// Adrián Navarro Gabino

using System;

public class Rectangle
{
    public static void Main()
    {
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        string asterisks = new string('#', width);
        string spaces = new string(' ', width - 2);
        
        Console.WriteLine(asterisks);
        for(int row = 1; row <= height - 2; row++)
        {
            Console.Write("#");
            Console.Write(spaces);
            Console.WriteLine("#");
        }
        Console.WriteLine(asterisks);
    }
}
