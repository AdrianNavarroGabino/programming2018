// Conversion from degrees Celsius to Fahrenheit
// Adrián Navarro Gabino

using System;

public class CelsToFahr
{
	public static void Main()
	{
		int celsius, celsToFahr;
		
		Console.Write("Degrees Celsius: ");
		celsius = Convert.ToInt32(Console.ReadLine());
		
		celsToFahr = 32 + celsius * 18 / 10;
		
		Console.Write("Fahrenheit degrees: ");
		Console.WriteLine(celsToFahr);
	}
}
