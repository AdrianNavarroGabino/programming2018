// Adrián Navarro Gabino

using System;

public class FunctionMcd
{
	public static long McdR(long a, long b)
	{
		long greatest;
		long lowest;
		
		if(a >= b)
		{
			greatest = a;
			lowest = b;
		}
		else
		{
			greatest = b;
			lowest = a;
		}
		
		if(lowest == 0)
		{
			return greatest;
		}
		
		return McdR(lowest, greatest % lowest);
		
	}
	
	public static long Mcd(long a, long b)
	{
		long greatest;
		long lowest;
		
		if(a >= b)
		{
			greatest = a;
			lowest = b;
		}
		else
		{
			greatest = b;
			lowest = a;
		}
		
		long mcd = 1;
		
		for(int i = 1; i <= lowest; i++)
		{
			if(lowest % i == 0 && greatest % i == 0)
				mcd = i;
		}
		
		return mcd;
	}
	
	
	public static void Main()
	{
		Console.WriteLine(McdR(18,12));
		Console.WriteLine(Mcd(18,12));
	}
}
