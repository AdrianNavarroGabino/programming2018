// Adrián Navarro Gabino

using System;

class Sprite
{
    protected short x;
    protected short y;
    
    public void SetX(int posX) { x = (short)posX; }
    public void SetY(int posY) { y = (short)posY; }
    
    public short GetX() { return x; }
    public short GetY() { return y; }
    
    public Sprite()
    {
        MoveTo(0, 0);
    }
    
    public Sprite(int newX, int newY)
    {
        MoveTo(newX, newY);
    }
    
    public void Draw()
    {
        // TO DO
    }
    
    public void MoveTo(int newX, int newY)
    {
        x = (short)newX;
        y = (short)newY;
    }
}

class ConsoleSprite : Sprite
{
    protected char image;
    
    public void SetImage(char newImage) { image = newImage; }
    
    public char GetImage() { return image; }
    
    public ConsoleSprite()
    {
        MoveTo(0, 0);
        image = '*';
    }
    
    public ConsoleSprite(int newX, int newY, char newImage)
    {
        MoveTo(newX, newY);
        image = newImage;
    }
    
    public new void Draw()
    {
        Console.SetCursorPosition(x / 15, y / 30);
        Console.Write(image);
    }
}


class SpriteTest
{
    static void Main()
    {
        ConsoleSprite mySprite = new ConsoleSprite();
        mySprite.MoveTo(100, 150);
        mySprite.SetY(160);
        Console.WriteLine(mySprite.GetX());
        mySprite.SetImage('X');
        mySprite.Draw();
    }
}
