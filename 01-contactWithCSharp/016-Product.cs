// Adrián Navarro Gabino

using System;

public class Product
{
	public static void Main()
	{
		int n1,n2,n3;
		
		Console.Write("Enter the first number: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the third number: ");
		n3 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("The product of {0}, {1} and {2} is {3}", n1,n2,n3,n1*n2*n3);
	}
}
