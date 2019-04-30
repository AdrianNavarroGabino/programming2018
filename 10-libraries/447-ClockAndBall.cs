// Adrián Navarro Gabino

using System;
using System.Threading;

class Date6
{
    static void Main()
    {
		
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.Cyan;
		
		int i = 0;
		int j = 0;
		int k = 0;
		
        while(true)
        {
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.SetCursorPosition(90,0);
			Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" +
				DateTime.Now.Minute.ToString("00") + ":" +
				DateTime.Now.Second.ToString("00"));
			
			Console.SetCursorPosition(i, j);
			Console.Write("o");
			
			i = (i + 3 * (int)Math.Pow(-1,k)) % 80;
			j = (j + 1* (int)Math.Pow(-1,k)) % 24;
			
			if(i == 0 || j == 0)
				k++;
			
			Thread.Sleep(200);
			
			if(Console.KeyAvailable)
			{
				ConsoleKeyInfo key = Console.ReadKey(true);
				if(key.Key == ConsoleKey.S)
					break;
			}
		}
    }
}
