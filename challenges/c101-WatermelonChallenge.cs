/*
Challenge 1.01: The watermelon
Can the watermelon be split in two pieces, weighting an even
number of kilos each? (Codeforces 4A)
Sample input 1
4
Sample output 1
YES
Sample input 2
3
Sample output 2
NO
*/

// Adrián Navarro Gabino

using System;

public class WatermelonChallenge
{
    public static void Main()
    {
        int W = Convert.ToInt32(Console.ReadLine());
         
        if((W % 2 == 0) && (W != 2))
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
