// Multiply two numbers if the first one is'nt zero
// Adrián Navarro Gabino

using System;

public class MultiplyIfNotZero
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		if(num1 == 0)
			Console.WriteLine("You can't multiply by zero");
		else	
		{
			Console.Write("Enter another number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("The product is ");
			Console.WriteLine(num1*num2);
		}
	}
}
