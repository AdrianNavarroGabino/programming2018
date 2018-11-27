// Conversion from euros to yens
// Adrián Navarro Gabino

using System;

public class EurosToYens
{
	public static void Main()
	{
		int euros, yenes;
		
		Console.Write("How many euros? ");
		euros = Convert.ToInt32(Console.ReadLine());
		
		yenes = euros * 13105 / 100;
		
		Console.Write("{0} euros are {1} yens", euros, yenes);
	}
}
