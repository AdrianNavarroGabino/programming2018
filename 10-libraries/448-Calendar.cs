// Adrián Navarro Gabino

using System;

class Calendar
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        
        string[] monthName = {"January", "February", "March",
                        "April", "May", "June",
                        "July", "August", "September",
                        "October", "November", "December"};
        int spaces = (27 - monthName.Length - 5) / 2;
        
        DateTime date = new DateTime(year, month, 1);
        
        int firstDay = (int)date.DayOfWeek - 1;
        
        DateTime nextMonth = new DateTime(year, month + 1, 1);
        TimeSpan dif = nextMonth.Subtract(date);
        int numberOfDays = dif.Days;
        
        for(int i = 0; i < spaces; i++)
            Console.Write(" ");
        Console.WriteLine(monthName[date.Month - 1] + " " + year);
        
        Console.WriteLine("Mon  Tue  Wed  Thu  Fri  Sat  Sun");
        
        for(int i = 0; i < firstDay; i++)
            Console.Write("     ");
        
        int currentDay = 1;
        
        int count = firstDay;
        
        while(currentDay <= numberOfDays)
        {
            Console.Write(" " + currentDay.ToString("00") + "  ");
            currentDay++;
            count++;
            if(count % 7 == 0)
                Console.WriteLine();
        }
    }
}
