// Adrián Navarro Gabino

using System;

public class LeapYear
{

    public static bool EsAnyoBisiesto(int year)
    {
        if(year % 4 == 0)
        {
            if(year % 100 != 0)
                return true;
            else
                if(year % 400 == 0)
                    return true;
        }
        
        return false;
    }
    public static void Main()
    {
        int year = 1984;
        
        if(EsAnyoBisiesto(year))
            Console.WriteLine(year + " fue bisiesto");
    }
}
