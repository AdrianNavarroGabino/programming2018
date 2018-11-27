// Difference of two numbers
// Adrián Navarro Gabino

using System;

public class Difference
{
	public static void Main()
	{
		int firstNumber, secondNumber, difference;
        
		Console.Write("Type the first number: ");
		firstNumber = Convert.ToInt32(Console.ReadLine());
        
		Console.Write("Type the second one: ");
		secondNumber = Convert.ToInt32(Console.ReadLine());
        
        difference = firstNumber - secondNumber;
        
        Console.Write("The difference is ");
		Console.WriteLine(difference);
	}
}
