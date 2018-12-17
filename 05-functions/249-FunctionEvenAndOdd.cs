// Adrián Navarro Gabino

using System;

public class FunctionEvenAndOdd
{
	public static void CountOddEven(string number, ref int even, ref int odd)
	{
		char[] aux = new char[number.Length];
		
		for(int i = 0; i < number.Length; i++)
		{
			aux[i] = number[i];
		}
		
		for(int i = 0; i < aux.Length; i++)
		{
			if(Convert.ToInt32("" + aux[i]) % 2 == 0)
			{
				even++;
			}
			else
			{
				odd++;
			}
		}
	}
	
	public static void Main()
	{
		int even = 0;
		int odd = 0;
		string number = Console.ReadLine();
		
		CountOddEven(number, ref even, ref odd);
		
		Console.WriteLine("Even: " + even);
		Console.WriteLine("Odd: " + odd);
	}
}
