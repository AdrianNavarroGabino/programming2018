// Adrián Navarro Gabino

using System;

public class Square
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        
        string row = new string('*', columns);
        
        for(int i = 0; i < columns; i++)
        {
            Console.WriteLine(row);
        }
    }
}
