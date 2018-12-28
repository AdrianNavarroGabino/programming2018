/*
Create a "TitleUnderlined" class, which inherits from "Title" and which will 
show hyphens below the title.
Your source file will contain now three classes: Title, TitleUnderlined and 
TitleTest.
Test it in "Main". You might get compilation errors ...
The attributes will be "protected".
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

public class TitleTest3
{
	public static void Main()
	{
		Title t1 = new Title();
		t1.SetX(5);
		t1.SetY(7);
		t1.SetText("Hello");
		t1.Show();
		
		TitleUnderline t2 = new TitleUnderline();
		t2.SetX(10);
		t2.SetY(12);
		t2.SetText("Bye");
		t2.Show();
	}
}
