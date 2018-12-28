/*
Create a class called "Title."
Its (public) attributes will be the text and the x and y coordinates.
It must have a method called "Show", which will display the text on the 
screen, at the coordinates indicated by the attributes.
Create a class "TitleTest" with a "Main" to test it.
*/

// Adrián Navarro Gabino

using System;

public class Title
{
	public string text;
	public int x, y;
	
	public void Show()
	{
		Console.SetCursorPosition(x, y);
		Console.WriteLine(text);
	}
}

public class TitleTest
{
	public static void Main()
	{
		Title t = new Title();
		
		t.x = 5;
		t.y = 7;
		
		t.text = "Hello";
		
		t.Show();
	}
}
