// Conversion from seconds to hours, minutes and seconds
// Adrián Navarro Gabino

using System;

public class SecondConversorFormat
{
	public static void Main()
	{
		int initialSeconds, seconds, minutes, hours;
		
		Console.Write("Enter seconds: ");
		initialSeconds = Convert.ToInt32(Console.ReadLine());
		
		hours = initialSeconds / 3600;
        
        if(hours < 10)
            Console.Write("0{0}:",hours);
        else
            Console.Write("{0}:",hours);
        
		minutes = (initialSeconds - hours * 3600) / 60;
        
        if(minutes < 10)
            Console.Write("0{0}:",minutes);
        else
            Console.Write("{0}:",minutes);
            
		seconds = initialSeconds - hours * 3600 - minutes * 60;
        
        if(seconds < 10)
            Console.WriteLine("0{0}",seconds);
        else
            Console.WriteLine("{0}",seconds);
		
		
		
	}
}
