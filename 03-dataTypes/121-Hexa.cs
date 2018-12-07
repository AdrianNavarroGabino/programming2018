// Adrián Navarro Gabino

using System;

public class Hexa
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        byte number = Convert.ToByte(Console.ReadLine());
        int result1;
        int result2;
        
        result2 = number % 16;
        result1 = number / 16;
        
        switch(result1)
        {
            case 10: Console.Write("A"); break;
            case 11: Console.Write("B"); break;
            case 12: Console.Write("C"); break;
            case 13: Console.Write("D"); break;
            case 14: Console.Write("E"); break;
            case 15: Console.Write("F"); break;
            default: Console.Write(result1); break;
        }
        switch(result2)
        {
            case 10: Console.Write("A"); break;
            case 11: Console.Write("B"); break;
            case 12: Console.Write("C"); break;
            case 13: Console.Write("D"); break;
            case 14: Console.Write("E"); break;
            case 15: Console.Write("F"); break;
            default: Console.Write(result2); break;
        }
    }
}
