// Adrián Navarro Gabino

using System;

public class PrimeAndPalindrome
{
    public static bool IsPrime(long number)
    {
        if(number == 1)
            return false;
        
        for(int i = 2; i < number / 2; i++)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static bool IsPalindrome(long number)
    {
        string auxNumber = number.ToString();
        for(int i = 0; i < auxNumber.Length; i++)
        {
            if(auxNumber[i] != auxNumber[auxNumber.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    
    public static bool IsPrimePalindrome(long number)
    {
        if(IsPalindrome(number) && IsPrime(number))
        {
            return true;
        }
        return false;
    }
    
    
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        long num1 = Convert.ToInt64(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        long num2 = Convert.ToInt64(Console.ReadLine());
        
        DateTime start = DateTime.Now;
        
        bool found = false;
        for(long i = num1; i <= num2; i++)
        {
            if(IsPrimePalindrome(i))
            {
                found = true;
                Console.WriteLine(i + " is palindrome and prime");
            }
        }
        
        if(!found)
        {
            Console.WriteLine("There is NO palindrome and prime numbers");
        }
        
        Console.WriteLine(DateTime.Now - start);
    }
}
