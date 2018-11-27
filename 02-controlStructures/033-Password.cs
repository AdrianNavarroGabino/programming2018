// Check a password
// Adrián Navarro Gabino

using System;

public class Password
{
	public static void Main()
	{
		int password = 1234;
		
		Console.Write("Enter the password: ");
		int passwordTry = Convert.ToInt32(Console.ReadLine());
		if(passwordTry == password)
			Console.WriteLine("Correct!");
		else	
			Console.WriteLine("You shall not pass!");
	}
}
