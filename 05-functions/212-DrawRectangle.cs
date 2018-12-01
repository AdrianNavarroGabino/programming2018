// Adrián Navarro Gabino

using System;

public class DrawRectangle
{
    public static void ShowRectangle(int height, int width, char character)
    {
        for(int row = 0; row < height; row++)
        {
            for(int col = 0; col < width; col++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
    
    public static void Main()
    {
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Character? ");
        char character = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine();
        
        ShowRectangle(height, width, character);
    }
}
