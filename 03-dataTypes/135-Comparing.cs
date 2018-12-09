// Adrián Navarro Gabino

using System;

public class Comparing
{
    public static void Main()
    {
        int compare;
        
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        
        if(num1 != num2 && num1 != num3 && num2 != num3)
            compare = 1;
        else if(num1 == num2 && num2 == num3)
            compare = 3;
        else
            compare = 2;
        
        Console.WriteLine(compare);
        
        compare = num1 != num2 && num1 != num3 && num2 != num3 ? 1 :
            (num1 == num2 && num2 == num3 ? 3 : 2);
            
        Console.WriteLine(compare);
    }
}
