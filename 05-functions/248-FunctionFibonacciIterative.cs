// Adrián Navarro Gabino

using System;

public class FunctionFibonacciIterative
{
	public static int Fibonacci(int position)
	{
		int sum1 = 0;
		int sum2 = 1;
		int count = 0;
		
		if(position == 1 || position == 0)
			return position;
		
		for(int i = 2; i <= position; i++)
		{
			if(count % 2 == 0)
				sum1 += sum2;
			else
				sum2 += sum1;
			
			count++;
		}
		
		if(count % 2 == 0)
			return sum2;
		return sum1;
	}
	
	public static void Main()
	{
		int number = 0;
		Console.WriteLine(Fibonacci(number));
		
		number = 1;
		Console.WriteLine(Fibonacci(number));
		
		number = 5;
		Console.WriteLine(Fibonacci(number));
	}
}
