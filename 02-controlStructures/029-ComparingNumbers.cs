// Comparing numbers
// Adrián Navarro Gabino

using System;

public class ComparingNumbers
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter another one: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		if(num1 < num2)
			Console.WriteLine("The second one is greater");
		else 
			if (num1 == num2)
				Console.WriteLine("Both are equal");
			else
				Console.WriteLine("The first one is greater");
	}
}
