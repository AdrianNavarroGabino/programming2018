// Leibniz (in)finite sum
// Adrián Navarro Gabino

using System;

public class LeibnizPIApproach
{
	public static void Main()
	{
		Console.Write("Pi is aproximately ");
		Console.WriteLine((1-1/3.0+1/5.0-1/7.0+1/9.0)*4);
		/*
		 * double serie = 0;
		 * 
		 * for(int i = 0; i < 1000000; i++)
		 * {
		 * 		if(i % 2 == 1)
		 * 		{
		 * 			serie -= 1.0/(2*i+1);
		 * 		}
		 * 		else
		 * 		{
		 * 			serie += 1.0/(2*i+1);
		 * 		}
		 * }
		 * serie *= 4;
		 * 
		 * Console.Write("Pi is aproximately ");
		 * Console.WriteLine(serie);
		 */ 
	}
}
