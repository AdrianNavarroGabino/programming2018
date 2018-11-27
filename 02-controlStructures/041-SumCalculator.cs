// Calculator (while)
// Adrián Navarro Gabino

using System;

public class SumCalculator
{
    public static void Main()
    {
		int number;
		int sum = 0;
        
        Console.WriteLine("Enter a number (type 0 to stop):");
        number = Convert.ToInt32(Console.ReadLine());
		
        while(number != 0)
        {
            sum += number;
			Console.WriteLine("Enter a number (type 0 to stop):");
            number = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine(sum);
    }
}
