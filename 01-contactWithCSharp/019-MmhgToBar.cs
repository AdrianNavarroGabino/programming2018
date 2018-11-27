// Conversion from mmHg to bar
// Adrián Navarro Gabino

using System;

public class MmhgToBar
{
	public static void Main()
	{
		int mmhg, bar;
		
		Console.Write("mmHg: ");
		mmhg = Convert.ToInt32(Console.ReadLine());
		
		bar = mmhg/750;
		
		Console.Write("Bar: {0}", bar);
	}
}
