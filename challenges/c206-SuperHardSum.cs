// Adrián Navarro Gabino

using System;

public class SuperHardSum
{
    public static void Main()
    {
        decimal sum = 0;
        
        string data = Console.ReadLine();
        while(data.Contains("  "))
            data = data.Replace("  ", " ");

        string[] data2 = data.Split();
        
        decimal numbers;
        
        for(int i = 0; i < data2.Length; i++)
        {
            numbers = Convert.ToDecimal(data2[i]);
            sum += numbers;
        }
        
        Console.WriteLine(sum);
    }
}
