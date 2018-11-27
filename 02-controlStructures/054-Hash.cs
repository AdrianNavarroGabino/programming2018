// Rectangle
// Adrián Navarro Gabino

using System;

public class Hash
{
    public static void Main()
    {
        int width, height;
        
        Console.Write("Width? ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height? ");
        height = Convert.ToInt32(Console.ReadLine());
        
        for ( int row = 0; row < height ; row++)
        {
            for ( int column = 0 ; column < width ; column++)
                Console.Write("#");
            Console.WriteLine();
        }
        
    }
}
