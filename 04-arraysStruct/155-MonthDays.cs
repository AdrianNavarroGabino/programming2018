// Days in a month
// Adrián Navarro Gabino

using System;

class MonthDays
{
    public static void Main(string[] args)
    {
        byte[] monthDays = {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31};
            
        Console.Write("Enter a month number: ");
        byte userMonth = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("Month number {0} has {1} days",
            userMonth, monthDays[userMonth - 1]);
    }
}
