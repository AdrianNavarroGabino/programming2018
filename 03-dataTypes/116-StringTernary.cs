// Ternary operator & strings
// Adrián Navarro Gabino

using System;

public class StringTernary
{
    public static void Main()
    {
        string textAsMark;
        
        Console.Write("Mark: ");
        double mark = Convert.ToDouble(Console.ReadLine());
        
        if(mark >= 60)
            textAsMark = "pass";
        else
            textAsMark = "fail";
            
        Console.WriteLine(textAsMark);
            
        textAsMark = mark >= 60 ? "pass" : "fail";
        
        Console.WriteLine(textAsMark);
    }
    
}
