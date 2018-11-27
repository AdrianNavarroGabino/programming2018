// Multiple of 2 and 3? (switch)
// Adrián Navarro Gabino

using System;

public class MultiplesOf2Or3
{
    public static void Main()
    {
        Console.Write("Enter a number (1 to 10): ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        switch(n)
        {
            case 1:
                goto case 7;
            case 2:
                goto case 10;
            case 3:
                goto case 9;
            case 4:
                goto case 10;
            case 5:
                goto case 7;
            case 6:
                Console.WriteLine("Multiple of 2 and 3");
                break;
            case 7:
                Console.WriteLine("NOT a multiple of 2 nor 3");
                break;
            case 8:
                goto case 10;
            case 9:
                Console.WriteLine("Multiple of 3");
                break;
            case 10:
                Console.WriteLine("Multiple of 2");
                break;
            default:
                Console.WriteLine("Incorrect number");
                break;
        }
    }
}
