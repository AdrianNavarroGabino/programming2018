// Adrián Navarro Gabino

using System;

public class Counting
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        // FOR
        if(num1 <= num2)
            for(int i = num1; i <= num2; i++)
                Console.Write("{0} ", i);
        else
            for(int i = num1; i >= num2; i--)
                Console.Write("{0} ", i);
        
        Console.WriteLine();
        
        
        // WHILE
        int count;
        
        if(num1 <= num2)
        {
            count = num1;
            while(count <= num2)
                Console.Write("{0} ", count++);
        }
        else
        {
            count = num2;
            while(count >= num1)
                Console.Write("{0} ", count--);
        }
        
        Console.WriteLine();
        
        
        // DO WHILE
        if(num1 <= num2)
        {
            count = num1;
            do
            {
                Console.Write("{0} ", count++);
            } while(count <= num2);
        }
        else
        {
            count = num2;
            do
            {
                Console.Write("{0} ", count--);
            } while(count >= num1);
        }
        
        Console.WriteLine();
    }
}
