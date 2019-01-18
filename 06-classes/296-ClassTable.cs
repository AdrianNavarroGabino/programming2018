// Adrián Navarro Gabino

using System;

class Table
{
    protected string color;
    protected int length;
    protected int width;
    protected Leg myLeg;
    
    public Table(string newColor, int newlength, int newWidth,
        string legColor, int legHeight)
    {
        SetColor(newColor);
        Setlength(newlength);
        SetWidth(newWidth);
        myLeg = new Leg(legHeight, legColor);
    }
    
    public Table()
    {
    }
    
    public void SetColor(string newColor) { color = newColor; }
    public void Setlength(int newlength) { length = newlength; }
    public void SetWidth(int newWidth) { width = newWidth; }
    public void SetLeg(Leg l)
    {
        myLeg = l;
    }
    
    public string GetColor() { return color; }
    public int Getlength() { return length; }
    public int GetWidth() { return width; }
    public Leg GetLeg() { return myLeg; }
}

class Leg
{
    protected string color;
    protected int height;
    
    public Leg(int newHeight, string newColor)
    {
        SetColor(newColor);
        SetHeight(newHeight);
    }
    
    public void SetColor(string newColor) { color = newColor; }
    public void SetHeight(int newHeight) { height = newHeight; }
    
    public string GetColor() { return color; }
    public int GetHeight() { return height; }
}

class LittleTable : Table
{
    public LittleTable()
    {
        width = 40;
        length = 60;
    }
}

class TableTest
{
    static void Main()
    {
        Table myTable = new Table("red", 180, 120, "white", 20);
        Leg myLeg = new Leg(78, "silver");
        myTable.SetLeg(myLeg);
        
        LittleTable lt = new LittleTable();
        lt.SetColor("dark brown");
    }
}
    
