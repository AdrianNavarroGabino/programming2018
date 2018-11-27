// Adrián Navarro Gabino

using System;

public class MilesToMeters
{
	public static void Main()
	{
		int miles;
		Console.Write("How many miles would you like to convert to meters? ");
		miles = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(miles * 1609);
	}
}
