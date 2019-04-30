// Adrián Navarro Gabino

using System;
using System.Threading;

class Date5
{
    static void Main()
    {
		Console.BackgroundColor = ConsoleColor.DarkRed;
		Console.Clear();
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.Cyan;
		
        while(true)
        {
			Console.SetCursorPosition(90,0);
			Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" +
				DateTime.Now.Minute.ToString("00") + ":" +
				DateTime.Now.Second.ToString("00"));
			Thread.Sleep(1000);
		}
    }
}
