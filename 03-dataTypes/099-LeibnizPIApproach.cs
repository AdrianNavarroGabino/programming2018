// Leibniz (in)finite sum
// Adrián Navarro Gabino

using System;

public class LeibnizPIApproach
{
	public static void Main()
	{
        Console.Write("Terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        
		
		double serie = 0;
		
		for(int i = 0; i < terms; i++)
		{
				if(i % 2 == 1)
				{
					serie -= 1.0/(2*i+1);
				}
				else
				{
					serie += 1.0/(2*i+1);
				}
		}
		serie *= 4;
		
		Console.Write("Pi is aproximately ");
		Console.WriteLine(serie);
		 
	}
}
