// Adrián Navarro Gabino

using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(args[0]);
        char operation = Convert.ToChar(args[1]);
        int num2 = Convert.ToInt32(args[2]);
        
        switch(operation)
        {
            case '+': Console.WriteLine(num1 + num2); break;
            case '-': Console.WriteLine(num1 - num2); break;
            case 'x':
            case 'X':
            case '*': Console.WriteLine(num1 * num2); break;
            case '/': Console.WriteLine(num1 / num2); break;
            default: Console.WriteLine("Wrong operator"); break;
        }
    }
}
