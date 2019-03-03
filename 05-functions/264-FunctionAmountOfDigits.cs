// Adrián Navarro Gabino

using System;

public class FunctionAmountOfDigits
{
    public static int AmountOfDigits(uint num)
    {
        int digits = 1;
        
        while(num / 10 != 0)
        {
            num /= 10;
            digits++;
        }
        
        return digits;
    }

    public static int AmountOfDigitsR(uint num)
    {
        if(num < 10)
        {
            return 1;
        }
        return 1 + AmountOfDigitsR(num / 10);
    }
    
    
    public static void Main()
    {
        Console.WriteLine(AmountOfDigits(987));
        
        if (AmountOfDigitsR(1005) != 4)
            Console.WriteLine("It fails...");
        else
            Console.WriteLine("It works!!");
    }
}
