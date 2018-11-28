/*
Sample input
4
1584
1600
1699
1700
Sample output
29
29
28
28
*/

// Adrián Navarro Gabino

using System;

public class RetoBisiesto
{
    public static void Main()
    {
        int anyo;
        int febrero = 28;
        int casos = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < casos; i++)
        {
            anyo = Convert.ToInt32(Console.ReadLine());
            if(anyo % 4 == 0)
            {
                if(anyo % 100 != 0)
                    febrero = 29;
                else
                    if(anyo % 400 == 0)
                        febrero = 29;
            }
            Console.WriteLine(febrero);
        }
    }
}
