// Adrián Navarro Gabino

using System;

public class PositivesTernary
{
    public static void Main()
    {
        int amountOfPositives;
        
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if(num1 > 0 || num2 > 0)
        {
            amountOfPositives = 1;
            if(num1 > 0 && num2 > 0)
                amountOfPositives++;
        }
        else
            amountOfPositives = 0;
        
        Console.WriteLine(amountOfPositives);
        
        amountOfPositives = (num1 <= 0 && num2 <= 0) ? 0 : 
            ((num1 > 0 && num2 > 0) ? 2 : 1);
        
        Console.WriteLine(amountOfPositives);
        
        
        
    }
}
