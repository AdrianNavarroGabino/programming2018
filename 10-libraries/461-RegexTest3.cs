// Adrián Navarro Gabino

using System;
using System.Text.RegularExpressions;

class RegexTest3
{
    static bool IsAValidHexa(string s)
    {
        Regex r = new Regex(@"\A[0-9A-Fa-f]{1,4}\z");
        
        return r.IsMatch(s);
    }
    
    static void Main()
    {
        Console.Write("Enter an hexadecimal number: ");
        string num = Console.ReadLine();
        
        if(IsAValidHexa(num))
            Console.WriteLine("It seems valid");
        else
            Console.WriteLine("It is NOT valid");
    }
}
