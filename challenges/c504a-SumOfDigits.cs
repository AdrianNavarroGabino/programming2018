// Adrián Navarro Gabino

using System;

public class SumOfDigits
{
    public static void Main()
    {
        string number;
        int digit;
        
        do
        {
            int sum = 0;
            
            number = Console.ReadLine();
            
            if(number[0] != '-')
            {
                for(int i = 0; i < number.Length - 1; i++)
                {
                    digit = Convert.ToInt32("" + number[i]);
                    
                    sum += digit;
                    
                    Console.Write(digit + " + ");
                }
                
                digit = Convert.ToInt32("" + number[number.Length - 1]);
                    
                sum += digit;
                
                Console.WriteLine(digit + " = " + sum);
            }
        } while(number[0] != '-');
    }
}
