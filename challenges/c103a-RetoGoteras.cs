/*
Sample input
3
70
3600
3661
Sample output
00:01:10
01:00:00
01:01:01
*/

// Adrián Navarro Gabino

using System;

public class RetoGoteras
{
	public static void Main()
	{
		int segundosIniciales, segundos, minutos, horas;
		
		int n = Convert.ToInt32(Console.ReadLine());
        
		for(int i = 0; i < n; i++)
        {
            segundosIniciales = Convert.ToInt32(Console.ReadLine());
            
            horas = segundosIniciales / 3600;
            
            if(horas < 10)
                Console.Write("0{0}:",horas);
            else
                Console.Write("{0}:",horas);
            
            minutos = (segundosIniciales - horas * 3600) / 60;
            
            if(minutos < 10)
                Console.Write("0{0}:",minutos);
            else
                Console.Write("{0}:",minutos);
                
            segundos = segundosIniciales - horas * 3600 - minutos * 60;
            
            if(segundos < 10)
                Console.WriteLine("0{0}",segundos);
            else
                Console.WriteLine("{0}",segundos);
        }
		
		
		
	}
}
