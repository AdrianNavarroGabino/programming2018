// Adrián Navarro Gabino

using System;

public class AverageFunction
{
    public static double Average(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }
    
    public static void Main()
    {
        Console.Write("Number 1? ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Number 2? ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Number 3? ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine( Average(n1, n2, n3) );
    }
}
