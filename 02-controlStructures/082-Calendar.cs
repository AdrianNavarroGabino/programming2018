// Calendar
// Adrián Navarro Gabino

using System;

public class Calendar
{
    public static void Main()
    {     
        Console.Write("How many days in the month? ");   
        int days = Convert.ToInt32(Console.ReadLine());
        Console.Write("Day of the week the month starts: ");  
        int start = Convert.ToInt32(Console.ReadLine());
        
        int dayNumber = 1;
        
        Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
        
        for(int i = 1; i < start; i++)
            Console.Write("    ");
        while(dayNumber <= days)
        {
            for(int i = start; i <= 7; i++)
            {
                if(dayNumber <= days)
                {
                    if(dayNumber / 10 == 0)
                        Console.Write(" ");
                    Console.Write("{0}  ", dayNumber);
                    
                    dayNumber++;
                }
            }
            Console.WriteLine();
            start = 1;
        }
    }
}
