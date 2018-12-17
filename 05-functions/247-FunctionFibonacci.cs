// Adrián Navarro Gabino

using System;

public class FunctionFibonacci
{
	public static int Fibonacci(int position)
	{
		if(position == 0 || position == 1)
			return position;
		
		return Fibonacci(position - 1) + Fibonacci(position - 2);
	}
	
	public static void Main()
	{
		int number = 0;
		Console.WriteLine(Fibonacci(number));
		
		number = 1;
		Console.WriteLine(Fibonacci(number));
		
		number = 10;
		Console.WriteLine(Fibonacci(number));
	}
}
