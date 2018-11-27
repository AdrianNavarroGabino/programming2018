// Check a password (while)
// Adrián Navarro Gabino

using System;

public class Password2
{
	public static void Main()
	{
        int passwordTry;
		
		do
		{
            Console.Write("Enter the password: ");
			passwordTry = Convert.ToInt32(Console.ReadLine());
            if(passwordTry != 1234)
                Console.WriteLine("Access denied!");
		} while(passwordTry != 1234);
		Console.WriteLine("Access granted!");
	}
}
