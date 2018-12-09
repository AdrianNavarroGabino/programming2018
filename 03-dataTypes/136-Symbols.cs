// Adrián Navarro Gabino

using System;

public class Symbols
{
    public static void Main()
    {
        Console.Write("Enter a symbol: ");
        string symbol = Console.ReadLine();
        
        switch(symbol)
        {
            case "<":
            case ">":
            case "<=":
            case ">=":
            case "==":
            case "!=": Console.WriteLine("Comparator"); break;
            case "+":
            case "-":
            case "*":
            case "/":
            case "%": Console.WriteLine("Arithmetic operator"); break;
            case "\"":
            case "'": Console.WriteLine("Text delimiter"); break;
            default: Console.WriteLine("Unknown symbol"); break;
        }
        
        if(symbol == "<" || symbol == ">" || symbol == "<=" ||
                symbol == ">=" || symbol == "==" || symbol == "!=")
            Console.WriteLine("Comparator");
        else if(symbol == "+" || symbol == "-" || symbol == "*" ||
                symbol == "/" || symbol == "%")
            Console.WriteLine("Arithmetic operator");
        else if(symbol == "\"" || symbol == "'")
            Console.WriteLine("Text delimiter");
        else
            Console.WriteLine("Unknown symbol");
    }
}
