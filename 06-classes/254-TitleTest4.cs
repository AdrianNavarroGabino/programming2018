/*
Create an Init method for the "Title" class, which will set the following 
starting values: text = "Hello", x = 40, y = 10

Test it from "Main"
*/

// Adrián Navarro Gabino

using System;

public class Title
{
	protected string text;
	protected int x, y;
    
    public void SetX(int a) { x = a; }
    public void SetY(int a) { y = a; }
    public void SetText(string a) { text = a; }
    
    public void Init()
	{
		x = 40;
		y = 10;
		text = "Hello";
	}
	
	public void Show()
	{
		Console.SetCursorPosition(x, y);
		Console.WriteLine(text);
	}
}

public class TitleUnderline: Title
{	
	public void Show()
	{
		Console.SetCursorPosition(x, y);
		Console.WriteLine(text);
		Console.SetCursorPosition(x, y + 1);
		string underline = new string('-', text.Length);
		Console.WriteLine(underline);
	}
}

public class TitleTest4
{
	public static void Main()
	{
		Title t = new Title();
		t.Init();
		
		t.Show();
	}
}
