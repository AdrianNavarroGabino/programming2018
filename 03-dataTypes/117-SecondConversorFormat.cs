// Conversion from seconds to hours, minutes and seconds
// Adrián Navarro Gabino

using System;

public class SecondConversorFormat
{
	public static void Main()
	{
        Console.Write("Seconds? ");
        string answer = Console.ReadLine();
		int initialSeconds, seconds, minutes, hours;
        
		while(answer != "")
        {
            initialSeconds = Convert.ToInt32(answer);
            
            hours = initialSeconds / 3600;
            
            minutes = (initialSeconds - hours * 3600) / 60;
            
            seconds = initialSeconds - hours * 3600 - minutes * 60;
            
            Console.WriteLine("{0}:{1}:{2}", hours.ToString("00"), 
                    minutes.ToString("00"), seconds.ToString("00"));
            
            Console.Write("Seconds? ");
            answer = Console.ReadLine();
        }
        
        Console.Write("See you!");
	}
}
