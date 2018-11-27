// Calculator (version 1)
// Adrián Navarro Gabino

using System;

public class Calculator
{
    public static void Main()
    {
        Console.Write("Number? ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Operator? ");
        char operador = Convert.ToChar(Console.ReadLine());
        Console.Write("Number? ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        switch(operador)
        {
            case '+': Console.WriteLine(num1 + num2); break;
            case '-': Console.WriteLine(num1 - num2); break;
            case 'x':
            case '*':
            case '·': Console.WriteLine(num1 * num2); break;
            case '/': Console.WriteLine(num1 / num2); break;
            default: Console.WriteLine("Wrong operator"); break;
        }
    }
    
}
