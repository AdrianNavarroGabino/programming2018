// Adrián Navarro Gabino

using System;

public class BufferChallenge
{
    public static void Main()
    {
        int cases, urinals, numberOfMen;
        cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            urinals = Convert.ToInt32(Console.ReadLine());
            numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
            Console.WriteLine(numberOfMen);
        }
    }
}
