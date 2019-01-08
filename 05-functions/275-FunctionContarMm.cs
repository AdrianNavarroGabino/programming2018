// Adrián Navarro Gabino

using System;

public class FunctionContarMm
{
	public static void ContarMm(string text, ref int upper,
		ref int lower)
	{
		upper = lower = 0;
		
		foreach(char c in text)
		{
			if(c != ' ')
			{
				string aux = c + "";
				if(aux.ToLower() == aux)
					lower++;
				else
					upper++;
			}
		}
	}
	
	
	public static void Main()
	{
		int upper = 0;
		int lower = 0;
		string text = "Este es un Texto";
		
		ContarMm(text, ref upper, ref lower);
		
		Console.WriteLine("Mayúsculas: " + upper + ", minúsculas: " +
			lower);
	}
}
