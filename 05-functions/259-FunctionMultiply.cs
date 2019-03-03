// Adrián Navarro Gabino

using System;

public class FunctionMultiply
{
    public static int Multiplicar(int num1, int num2)
    {
        int product = 0;
        
        if(num2 != 0)
        {
            for(int i = 1; i <= num1; i++)
            {
                product += num2;
            }
        }
        
        return product;
    }
    
    public static int MultiplicarR(int num1, int num2)
    {
        if(num1 == 0 || num2 == 0)
            return 0;
        if(num1 == 1)
            return num2;
            
        return num2 + MultiplicarR(num1 - 1, num2);
    }
    
    
    public static void Main()
    {
        int num1 = 4;
        int num2 = 8;
        
        Console.WriteLine(Multiplicar(num1, num2));
        Console.WriteLine(MultiplicarR(num1, num2));
    }
}
