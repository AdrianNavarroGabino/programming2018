// Adrián Navarro Gabino

using System;

public class DigitalClockChallenge
{
    public static void Main()
    {
        int initialSeconds = Convert.ToInt32(Console.ReadLine());
        
        int hoursUnits, hoursTens, minutesUnits, minutesTens, secondsUnits,
            secondsTens;
        
        int hours, minutes, seconds;
        
        int amount = 0;
        
        for(int i = 0; i <= initialSeconds; i++)
        {
            hours = i / 3600;
            minutes = (i - hours * 3600) / 60;
            seconds = i - hours * 3600 - minutes * 60;
            
            hoursUnits = hours % 10;
            hoursTens = hours / 10;
            
            minutesUnits = minutes % 10;
            minutesTens = minutes / 10;
            
            secondsUnits = seconds % 10;
            secondsTens = seconds / 10;
            
            switch(hoursUnits)
            {
                case 0: hoursUnits = 6; break;
                case 1: hoursUnits = 2; break;
                case 2: hoursUnits = 5; break;
                case 3: hoursUnits = 5; break;
                case 4: hoursUnits = 4; break;
                case 5: hoursUnits = 5; break;
                case 6: hoursUnits = 6; break;
                case 7: hoursUnits = 3; break;
                case 8: hoursUnits = 7; break;
                case 9: hoursUnits = 6; break;
                default: break;
            }
            
            switch(hoursTens)
            {
                case 0: hoursTens = 6; break;
                case 1: hoursTens = 2; break;
                case 2: hoursTens = 5; break;
                case 3: hoursTens = 5; break;
                case 4: hoursTens = 4; break;
                case 5: hoursTens = 5; break;
                case 6: hoursTens = 6; break;
                case 7: hoursTens = 3; break;
                case 8: hoursTens = 7; break;
                case 9: hoursTens = 6; break;
                default: break;
            }
            
            switch(minutesUnits)
            {
                case 0: minutesUnits = 6; break;
                case 1: minutesUnits = 2; break;
                case 2: minutesUnits = 5; break;
                case 3: minutesUnits = 5; break;
                case 4: minutesUnits = 4; break;
                case 5: minutesUnits = 5; break;
                case 6: minutesUnits = 6; break;
                case 7: minutesUnits = 3; break;
                case 8: minutesUnits = 7; break;
                case 9: minutesUnits = 6; break;
                default: break;
            }
            
            switch(minutesTens)
            {
                case 0: minutesTens = 6; break;
                case 1: minutesTens = 2; break;
                case 2: minutesTens = 5; break;
                case 3: minutesTens = 5; break;
                case 4: minutesTens = 4; break;
                case 5: minutesTens = 5; break;
                case 6: minutesTens = 6; break;
                case 7: minutesTens = 3; break;
                case 8: minutesTens = 7; break;
                case 9: minutesTens = 6; break;
                default: break;
            }
            
            switch(secondsUnits)
            {
                case 0: secondsUnits = 6; break;
                case 1: secondsUnits = 2; break;
                case 2: secondsUnits = 5; break;
                case 3: secondsUnits = 5; break;
                case 4: secondsUnits = 4; break;
                case 5: secondsUnits = 5; break;
                case 6: secondsUnits = 6; break;
                case 7: secondsUnits = 3; break;
                case 8: secondsUnits = 7; break;
                case 9: secondsUnits = 6; break;
                default: break;
            }
            
            switch(secondsTens)
            {
                case 0: secondsTens = 6; break;
                case 1: secondsTens = 2; break;
                case 2: secondsTens = 5; break;
                case 3: secondsTens = 5; break;
                case 4: secondsTens = 4; break;
                case 5: secondsTens = 5; break;
                case 6: secondsTens = 6; break;
                case 7: secondsTens = 3; break;
                case 8: secondsTens = 7; break;
                case 9: secondsTens = 6; break;
                default: break;
            }
            
            amount += hoursUnits + hoursTens + minutesUnits + minutesTens +
                    secondsUnits + secondsTens;
        }
        
        Console.WriteLine(amount);
    }
}
