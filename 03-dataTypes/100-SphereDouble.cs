// Area and volume of a sphere (double)
// Adrián Navarro Gabino

using System;

public class SphereDouble
{
    public static void Main()
    {
        double pi = 3.1415926535;
        
        Console.Write("Radius? ");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double s = 4*pi*r*r;
        double v = 4*pi*r*r*r/3;
        
        Console.WriteLine("Area = "+s);
        Console.WriteLine("Volume = "+v);
    }
}
