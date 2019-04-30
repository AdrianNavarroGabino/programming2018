// Adrián Navarro Gabino

using System;
using System.Threading;

class Date4
{
    static void Main()
    {
        while(true)
        {
			Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" +
				DateTime.Now.Minute.ToString("00") + ":" +
				DateTime.Now.Second.ToString("00"));
			Thread.Sleep(1000);
		}
    }
}
