// Adrián Navarro Gabino

using System;

public class Symbols
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            
            switch(symbol)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': Console.WriteLine("Number"); break;
                case '(':
                case ')': Console.WriteLine("Parenthesis"); break;
                case '[':
                case ']': Console.WriteLine("Square bracket"); break;
                case '{':
                case '}': Console.WriteLine("Key"); break;
                default: Console.WriteLine("Unknown character"); break;
            }
            
            if(simbolo >= '0' && simbolo <= '9')
                Console.WriteLine("Number");
            else if(simbolo == '(' || simbolo == ')')
                Console.WriteLine("Parenthesis");
            else if(simbolo == '[' || simbolo == ']')
                Console.WriteLine("Square bracket");
            else if(simbolo == '{' || simbolo == '}')
                Console.WriteLine("Key");
            else
                Console.WriteLine("Unknown character");
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
