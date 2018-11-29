// Day of the year
// Adrián Navarro Gabino

using System;

class YearDay
{
    public static void Main(string[] args)
    {
        byte[] monthDays = {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31};
            
        Console.Write("Enter a day number: ");
        byte userDay = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter a month number: ");
        byte userMonth = Convert.ToByte(Console.ReadLine());
        
        short yearDay = userDay;
        
        for(int i = 0; i < userMonth - 1; i++)
            yearDay += monthDays[i];
        
        Console.WriteLine("Day number: {0}", yearDay);
    }
}
