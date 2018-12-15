/*
Sample inputs
9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9
Outputs for those inputs
0
4
247
0
101
*/

// Adrián Navarro Gabino

using System;

public class LookingForTheTen
{
    public static void Main()
    {
        string[] marks = Console.ReadLine().Split(',');
        
        int denominator = marks.Length;
        
        int sum = 0;
        
        for(int i = 0; i < denominator; i++)
        {
            sum += Convert.ToInt32(marks[i]);
        }
        
        double currentAverage = (double)sum / denominator;
        
        if(currentAverage >= 9.5)
        {
            Console.WriteLine(0);
        }
        else
        {
            int tasks = 19 * denominator - 2 * sum;
                
            Console.WriteLine(tasks);
        }
    }
}
