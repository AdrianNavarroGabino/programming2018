/*
Sample input
6
4
6
5
3
26073
59794
Sample output
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
Case #5: 13036
Case #6: 29896
*/

// Adrián Navarro Gabino

using System;

public class RetoComida
{
    public static void Main()
    {
        int mesas, personas;
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            personas = Convert.ToInt32(Console.ReadLine());
            mesas = personas <= 4 ? 1 : (personas - 3) / 2 + 1;
            Console.WriteLine("Case #{0}: {1}", i, mesas);
        }
    }
}
