// Adrián Navarro Gabino

using System;
using System.IO;

class Date2
{
    static void Main()
    {
		string[] mes = {"enero", "febrero", "marzo",
                        "abril", "mayo", "junio",
                        "julio", "agosto", "septiembre",
                        "octubre", "noviembre", "diciembre"};
        DateTime now = DateTime.Now;
        
        DateTime nextDay = now;
        
        string tasks;
        
        StreamWriter file = new StreamWriter("tasks.txt");
        
        do
        {
			nextDay = nextDay.AddDays(7);
			
			if(nextDay.Year == now.Year)
			{
				tasks = nextDay.Day + "-" +
					mes[nextDay.Month - 1].Substring(0,3) + "-" +
					nextDay.Year.ToString().Substring(2) + ":";
				file.WriteLine(tasks);
			}
			
		} while(nextDay.Year == now.Year);
		
		file.Close();
    }
}
