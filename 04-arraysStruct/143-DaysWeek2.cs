// Days in the week (version 2)
// Adrián Navarro Gabino

using System;

public class DaysWeek2
{
    public static void Main()
    {
        string[] daysWeek = {"Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday"};
        
        for(int j = 6; j >= 0; j--)
            Console.Write(daysWeek[j] + " ");
        Console.WriteLine();
    }
}
