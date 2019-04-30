// Adrián Navarro Gabino

using System;
using System.Text.RegularExpressions;

class RegexTest4
{
    static bool IsAValidMail(string s)
    {
        Regex r = new Regex(@"\A[a-z]+\@[a-z]+\.[a-z]{2,4}\z");
        
        return r.IsMatch(s);
    }
    
    static void Main()
    {
        Console.Write("Enter an email: ");
        string id = Console.ReadLine();
        
        if(IsAValidMail(id))
            Console.WriteLine("It seems valid");
        else
            Console.WriteLine("It is NOT valid");
    }
}
