// Adrián Navarro Gabino

using System;

public class Compliment
{
	public static void Main()
	{
		int age;
		
		Console.Write("How old are you? ");
		age = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("It seems you are ");
		Console.Write(age-1);
		Console.WriteLine(" or less.");
	}
}
