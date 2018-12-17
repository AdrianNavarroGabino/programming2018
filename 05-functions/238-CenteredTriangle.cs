// Adrián Navarro Gabino

using System;

public class CenteredTriangle
{
    public static void WriteCenteredTriangle(char c, int width)
    {
        int initialSize = 40 - width / 2;
        
        for(int i = 0; i < (width + 1) / 2; i++)
        {
            string spaces = new string(' ', initialSize + i);
            string symbols = new string(c, width - i * 2);
            
            Console.WriteLine(spaces + symbols);
        }
    }
    
    public static void Main()
    {
        WriteCenteredTriangle('#', 20);
    }
}
