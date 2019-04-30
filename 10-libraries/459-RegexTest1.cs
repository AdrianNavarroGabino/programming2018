// Adrián Navarro Gabino

using System;
using System.Text.RegularExpressions;

class RegexTest
{
    static bool IsAValidIdentifier(string s)
    {
        Regex r = new Regex(@"\A[A-Za-z][A-Za-z0-9]*\z");
        
        return r.IsMatch(s);
    }
    
    static void Main()
    {
        Console.Write("Enter an identifier: ");
        string id = Console.ReadLine();
        
        if(IsAValidIdentifier(id))
            Console.WriteLine("It seems valid");
        else
            Console.WriteLine("It is NOT valid");
    }
}
