// Name of a month
// Adrián Navarro Gabino

using System;

public class Months
{
    public static void Main()
    {
        string[] months = { 
            "January", "February", "March", 
            "April", "May", "June", 
            "July", "August", "September", 
            "October", "November","December"};
        
        Console.Write("Choose a month number: ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("{0} is {1}", monthNumber,
            months[monthNumber - 1]);
    }
}
