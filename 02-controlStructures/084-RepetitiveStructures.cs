// Repetitive structures: for, while, do-while
// Adrián Navarro Gabino

using System;

public class RepetitiveStructures
{
    public static void Main()
    {
        int i, num1, num2;
        
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        for(i = num1; i <= num2; i++)
            if(i % 2 == 0)
                Console.Write("{0} ",i);
        Console.WriteLine();
        
        for(i = num1; i <= num2; i = i + 2)
            Console.Write("{0} ",i);
        Console.WriteLine();
        
        i = num1;
        while(i <= num2)
        {
            Console.Write("{0} ",i);
            i = i + 2;
        }
        Console.WriteLine();
        
        i = num1;
        do
        {
            Console.Write("{0} ",i);
            i = i + 2;
        }while(i <= num2);
        Console.WriteLine();
    }
}
