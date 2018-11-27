// Days of the week
// Adrián Navarro Gabino

using System;

public class DayOfTheWeek
{
    public static void Main()
    {
        Console.Write("Enter a day number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());
        
        if (day == 1)
            Console.WriteLine("Monday");
        else if (day == 2)
            Console.WriteLine("Tuesday");
        else if (day == 3)
            Console.WriteLine("Wednesday");
        else if (day == 4)
            Console.WriteLine("Thursday");
        else if (day == 5)
            Console.WriteLine("Friday");
        else if (day == 6)
            Console.WriteLine("Saturday");
        else if (day == 7)
            Console.WriteLine("Sunday");
        else
            Console.WriteLine("Wrong day");
    }
}
