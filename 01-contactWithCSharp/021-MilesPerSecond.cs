// Conversion from miles/second to km/h
// 1609 meters, 1 mile
// Adrián Navarro Gabino

using System;

public class MilesPerSecond
{
	public static void Main()
	{
		int miles, seconds, milesPerSecond, kilometersPerHour, milesPerHour;
		
		Console.Write("How many miles? ");
		miles = Convert.ToInt32(Console.ReadLine());
		Console.Write("How many seconds? ");
		seconds = Convert.ToInt32(Console.ReadLine());
		
		milesPerSecond = miles /seconds;
		kilometersPerHour = miles * 3600 * 1609 / seconds / 1000;
		milesPerHour = milesPerSecond * 3600;
		
		Console.Write(
            "{0} miles/second are {1} kilometers/hour and {2} miles/hour",
            milesPerSecond, kilometersPerHour, milesPerHour);
	}
}
