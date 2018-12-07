// Adrián Navarro Gabino

using System;

public class AbbreviatedOperations
{
    public static void Main()
    {
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        a++;
        b /= 3;
        c -= 5;
        
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        
        double d1, e1, d2, e2;
        
        d1 = e1 = 8;
        
        d2 = ++d1;
        
        e2 = e1++;
        
        Console.WriteLine("d1 = {0}", d1);
        
        Console.WriteLine("e1 = {0}", e1);
        
        Console.WriteLine("d2 = {0}", d2);
        
        Console.WriteLine("e2 = {0}", e2);
    }
    
}
