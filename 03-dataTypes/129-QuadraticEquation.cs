// Adrián Navarro Gabino

using System;

public class QuadraticEquation
{
    public static void Main()
    {
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        double disc = b*b - 4 * a * c;
        
        if(disc < 0)
            Console.WriteLine("No real solutions");
        else if(disc == 0)
        {
            double solution = -b / (2 * a);
            Console.WriteLine("Solution: " + solution);
        }
        else
        {
            double solution1 = (-b + Math.Sqrt(disc)) / (2 * a);
            double solution2 = (-b - Math.Sqrt(disc)) / (2 * a);
            Console.WriteLine("Solutions: " + solution1 +
                " and " + solution2);
        }
    }
}
