// Is the name of a month valid?
// Adrián Navarro Gabino

using System;

class Months2
{
    public static void Main(string[] args)
    {
        bool isReal = false;
        
        string[] months = { 
            "January", "February", "March", 
            "April", "May", "June", 
            "July", "August", "September", 
            "October", "November","December"};
            
        Console.Write("Enter a month: ");
        string userMonth = Console.ReadLine();
        
        foreach(string m in months)
            if(userMonth == m)
                isReal = true;
        
        if(isReal)
            Console.WriteLine("{0} is a real month", userMonth);
        else
            Console.WriteLine("{0} is NOT a real month", userMonth);
    }
}
