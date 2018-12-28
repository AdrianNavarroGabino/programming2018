/*
Create a new version of the class "Title".
Its attributes will be private and it will include getters and setters.
Change the program and "Main" as necessary.
*/

// Adrián Navarro Gabino

using System;

public class Title
{
	private string text;
	private int x, y;
	
	public void Show()
	{
		Console.SetCursorPosition(x, y);
		Console.WriteLine(text);
	}
	
	public void SetX(int a)
	{
		x = a;
	}
	
	public void SetY(int a)
	{
		y = a;
	}
	
	public void SetText(string a)
	{
		text = a;
	}
}

public class TitleTest2
{
	public static void Main()
	{
		Title t = new Title();
		
		t.SetX(5);
		t.SetY(7);
		t.SetText("Hello");
		
		t.Show();
	}
}
