// Adrián Navarro Gabino

using System;

public class FestivolandiaChallenge
{
    public static void Main()
    {
        int cases, day, month;
        
        cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            day = Convert.ToInt32(Console.ReadLine());  
            month = Convert.ToInt32(Console.ReadLine());
            
            if( (day % 2 == month % 2) || (day == 25 && month == 12) )
                Console.WriteLine("FESTIVO");
            else
                Console.WriteLine("LABORABLE");
        }
    }
}
