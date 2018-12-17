// Adrián Navarro Gabino

using System;

public class FunctionNameTriangle
{
	public static void WriteTriangleOfNameR(string name, int maxChar)
	{
		int limit = name.Length < maxChar ? name.Length : maxChar;
		
		for(int i = 1; i <= limit; i++)
		{
			string spaces = new string(' ', limit - i);
			
			Console.WriteLine(spaces + name.Substring(name.Length - i, i));
		}
	}
	
	public static void Main()
	{
		WriteTriangleOfNameR("Adrián", 3);
		
		WriteTriangleOfNameR("Adrián", 20);
	}
}
