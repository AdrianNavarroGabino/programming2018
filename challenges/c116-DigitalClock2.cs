// Adrián Navarro Gabino

using System;

class DigitalClock
{
    static int addLeds(int num, int code)
    {
        switch(num)
        {
            case 0:
                if(code == 9 || code == 6)
                {
                    return 1;
                }
                else if(code == 2)
                {
                    return 2;
                }
                else if(code == 4)
                {
                    return 3;
                }
                break;
            case 1: return 0;
            case 2: return 4;
            case 3: return 1;
            case 4: return 1;
            case 5: return 2;
            case 6: return 1;
            case 7: return 1;
            case 8: return 4;
            case 9: return 0;
        }
        return 0;
    }
    
    
    static void Main()
    {
        int hourTens = 0;
        int hourUnits = 0;
        int minutesTens = 0;
        int minutesUnits = 0;
        int secondsTens = 0;
        int secondsUnits = 0;
        
        int leds = 36;
        
        int seconds = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= seconds; i++)
        {
            secondsUnits = (secondsUnits + 1) % 10;
            leds += addLeds(secondsUnits, 9);
            
            if(secondsUnits == 0)
            {
                secondsTens = (secondsTens + 1) % 7;
                leds += addLeds(secondsTens, 6);
                
                if(secondsTens == 0)
                {
                    minutesUnits = (minutesUnits + 1) % 10;
                    leds += addLeds(minutesUnits, 9);
                    
                    if(minutesUnits == 0)
                    {
                        minutesTens = (minutesTens + 1) % 7;
                        leds += addLeds(minutesTens, 6);
                        
                        if(minutesTens == 0)
                        {
                            hourUnits++;
                            
                            if(hourTens == 2 && hourUnits == 5)
                            {
                                hourUnits = 0;
                                hourTens = 0;
                                leds += addLeds(hourUnits, 4);
                                leds += addLeds(hourTens, 2);
                            }
                            else if(hourUnits == 10)
                            {
                                hourUnits = 0;
                                hourTens++;
                                leds += addLeds(hourUnits, 9);
                                leds += addLeds(hourTens, 2);
                            }
                        }
                    }
                }
            }
        }
        
        Console.WriteLine(leds);
    }
}
