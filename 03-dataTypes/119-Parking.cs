// Adrián Navarro Gabino

using System;

public class Parking
{
    public static void Main()
    {
        Console.Write("Entry hour: ");
        int entryTime = Convert.ToInt32(Console.ReadLine());
        Console.Write("Exit hour: ");
        int exitTime = Convert.ToInt32(Console.ReadLine());
        
        int entryHour = entryTime / 100;
        int entryMinute = entryTime % 100;
        int exitHour = exitTime / 100;
        int exitMinute = exitTime % 100;
        
        double euros = 2.20;
        
        if(exitMinute - entryMinute > 0 && exitMinute - entryMinute < 59)
            euros = euros * (exitHour - entryHour + 1);
        else if (exitMinute - entryMinute == 59 || exitMinute - entryMinute == 0)
            euros = euros * (exitHour - entryHour) + 2.20;
        else
            euros = euros * (exitHour - entryHour);
            
        Console.WriteLine("To pay: {0}", euros);
    }
}
