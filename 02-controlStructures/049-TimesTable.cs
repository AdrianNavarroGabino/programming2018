// Times table
// Adrián Navarro Gabino

using System;

public class TimesTable
{
    public static void Main()
    {
        Console.Write("Table of... ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i <= 10; i++)
            Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
    }
}
