// Days in the week (version 1)
// Adrián Navarro Gabino

using System;

public class DaysWeek
{
    public static void Main()
    {
        string[] daysWeek = new string [7];
        
        daysWeek[0] = "Monday";
        daysWeek[1] = "Tuesday";
        daysWeek[2] = "Wednesday";
        daysWeek[3] = "Thursday";
        daysWeek[4] = "Friday";
        daysWeek[5] = "Saturday";
        daysWeek[6] = "Sunday";
        
        Console.Write("Enter a day (1-7): ");
        int i = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The day you have chosen is " + daysWeek[i - 1]);
        
        for(int j = 6; j >= 0; j--)
            Console.Write(daysWeek[j] + " ");
        Console.WriteLine();
    }
}
