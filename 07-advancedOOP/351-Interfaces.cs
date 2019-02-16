// Adrián Navarro Gabino

using System;

interface IDrawable
{
    void Draw();
}

interface IMeasurable
{
    double GetSize();
}

class ScreenRectangle : IDrawable, IMeasurable
{
    protected int x1;
    protected int x2;
    protected int y1;
    protected int y2;
    
    public ScreenRectangle(int x1, int x2, int y1, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }
    
    public void Draw()
    {
        Console.SetCursorPosition(x1,y1);
        Console.WriteLine(new string('-', x2 - x1));
        
        for(int i = 1; i < y2 - y1; i++)
        {
            Console.SetCursorPosition(x1,y1 + i);
            Console.WriteLine("|" + new string(' ', x2 - x1 - 2) + "|");
        }
        
        Console.SetCursorPosition(x1,y2);
        Console.WriteLine(new string('-', x2 - x1));
    }
    
    public double GetSize()
    {
        return (x2 - x1) * (y2 - y1);
    }
}

class RectangleTest
{
    static void Main()
    {
        ScreenRectangle r = new ScreenRectangle(3,7,2,6);
        
        r.Draw();
    }
}
