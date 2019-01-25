// Adrián Navarro Gabino

using System;

class Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    
    public Point3D(int x, int y, int z)
    {
        MoveTo(x, y, z);
    }
    
    public void MoveTo(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public double DistanceTo(Point3D p2)
    {
        return Math.Sqrt(Math.Pow(X - p2.X,2) +
            Math.Pow(Y - p2.Y,2) +
            Math.Pow(Z - p2.Z,2));
    }
    
    public override string ToString()
    {
        return "(" + X + "," + Y + "," + Z + ")";
    }
}

class Point3DTest
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter z: ");
        int z = Convert.ToInt32(Console.ReadLine());
        
        Point3D p = new Point3D(x, y, z);
        
        Console.WriteLine("P = " + p);
        Console.WriteLine(p.DistanceTo(new Point3D(1,0,-1)));
    }
}
