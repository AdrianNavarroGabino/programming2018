// Adrián Navarro Gabino

using System;

public class FunctionDibujarParalelogramo
{
	public static void DibujarParalelogramo(int w, int h, char s)
	{
		string row1 = new string(s, w);
		string spaces = new string(' ', w - 2);
		
		Console.WriteLine(row1);
		for(int i = 1; i < h - 1; i++)
		{
			for(int j = 0; j < i; j++)
			{
				Console.Write(" ");
			}
			Console.Write(s);
			Console.Write(spaces);
			Console.WriteLine(s);
		}
		for(int i = 0; i < h - 1; i++)
		{
			Console.Write(" ");
		}
		Console.WriteLine(row1);
	}
	
	
	public static void Main()
	{
		DibujarParalelogramo(10, 5, '*');
	}
}
