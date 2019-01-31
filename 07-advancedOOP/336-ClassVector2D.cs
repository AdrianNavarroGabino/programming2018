// Adrián Navarro Gabino

using System;

class Vector2D
{
    protected double x;
    protected double y;
    
    public void SetX(double x) { this.x = x; }
    public void SetY(double y) { this.y = y; }
    
    public double GetX() { return x; }
    public double GetY() { return y; }
    
    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    public override string ToString()
    {
        return "<" + this.x + ", " + this.y + ">";
    }
    
    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
    }
    
    public void Add(Vector2D v)
    {
        this.x += v.x;
        this.y += v.y;
    }
}

class VectorTest
{
    static void Main()
    {
        Vector2D v1 = new Vector2D(3.4, 6.7);
        Console.WriteLine("v1 = " + v1);
        Console.WriteLine("|v1| = " + v1.GetLength());
        
        Vector2D v2 = new Vector2D(10, 4.78);
        Console.WriteLine("v2 = " + v2);
        Console.WriteLine("|v2| = " + v2.GetLength());
        
        v1.Add(v2);
        Console.WriteLine("v1 + v2 = " + v1);
    }
}
