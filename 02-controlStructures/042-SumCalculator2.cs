// Calculator (do-while)
// Adrián Navarro Gabino

using System;

public class SumCalculator2
{
    public static void Main()
    {
		int number;
		int sum = 0;
		
        do
        {
			Console.WriteLine("Enter a number (type 0 to stop):");
            number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }while(number != 0);
        
        Console.WriteLine(sum);
    }
}
