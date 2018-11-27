// Is a number multiple of 10?
// Adrián Navarro Gabino

using System;

public class MultipleOf10
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		if(num1 % 10 == 0)
			Console.WriteLine("It's a multiple of 10");
		else
			Console.WriteLine("It isn't a multiple of 10");
		
	}
}
