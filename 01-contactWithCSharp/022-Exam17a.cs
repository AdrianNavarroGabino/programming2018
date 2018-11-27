// Adrián Navarro Gabino

public class Exam17a
{
	public static void Main()
	{
	int num1, num2;
	int division, module;
	
	System.Console.Write("Enter a number: ");
	num1 = System.Convert.ToInt32(System.Console.ReadLine());
	System.Console.Write("Enter another one: ");
	num2 = System.Convert.ToInt32(System.Console.ReadLine());
	
	division = num1 / num2;
	module = num1 % num2;
	
	System.Console.Write("Its division is: ");
	System.Console.WriteLine(division);
	
	System.Console.Write("The module of its division is: ");
	System.Console.WriteLine(module);
	}
}
