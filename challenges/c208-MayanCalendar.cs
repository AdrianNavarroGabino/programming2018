// Adrián Navarro Gabino

using System;
using System.Linq;

class MayanCalendar
{
    static void Main()
    {
        int firstDay = 18*20*20*20*13 + 18*20*20*20 + 18*20*7 + 20*16 + 3;
        DateTime firstDate = new DateTime(2000, 1, 1);
        
        string[] inputDate = Console.ReadLine().Split();
        
        int[] currentDayAux = new int[inputDate.Length];
        for(int i = 0; i < inputDate.Length; i++)
        {
            currentDayAux[i] = Convert.ToInt32(inputDate[i]);
        }
        
        int currentDay = 18*20*20*20*currentDayAux[0] +
            18*20*20*currentDayAux[1] + 18*20*currentDayAux[2] +
            20*currentDayAux[3] + currentDayAux[4];
            
        DateTime currentDate = firstDate.AddDays(currentDay - firstDay);
        
        Console.WriteLine(
            currentDate.Day + " " + currentDate.Month + " " + currentDate.Year);
    }
}
