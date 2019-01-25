// Adrián Navarro Gabino

using System;

class Point3D
{
    protected int x;
    protected int y;
    protected int z;
    
    public void SetX(int x) { this.x = x; }
    public void SetY(int y) { this.y = y; }
    public void SetZ(int z) { this.z = z; }
    
    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetZ() { return z; }
    
    public Point3D(int x, int y, int z)
    {
        MoveTo(x, y, z);
    }
    
    public void MoveTo(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public double DistanceTo(Point3D p2)
    {
        return Math.Sqrt(Math.Pow(this.x - p2.GetX(),2) +
            Math.Pow(this.y - p2.GetY(),2) +
            Math.Pow(this.z - p2.GetZ(),2));
    }
    
    public override string ToString()
    {
        return "(" + this.x + "," + this.y + "," + this.z + ")";
    }
}

class DogTest
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
