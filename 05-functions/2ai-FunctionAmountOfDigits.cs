// Adrián Navarro Gabino

using System;

public class FunctionAmountOfDigits
{
	public static int CantidadDeDigitos(int num)
	{
		int digits = 1;
		
		while(num / 10 != 0)
		{
			num /= 10;
			digits++;
		}
		
		return digits;
	}
	public static int CantidadDeDigitosR(int num)
	{
		if(num < 10)
		{
			return 1;
		}
		return 1 + CantidadDeDigitosR(num / 10);
	}
	
	
	public static void Main()
	{
		Console.WriteLine(CantidadDeDigitos(987));
		
		if (CantidadDeDigitosR(1005) != 4)
			Console.WriteLine("It fails...");
		else
			Console.WriteLine("It works!!");
	}
}
