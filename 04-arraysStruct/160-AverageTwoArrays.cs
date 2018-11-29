/*
Create a program to ask the user for 20 real numbers, store them in two 
arrays of 10 numbers each (named "data1" and "data2"), and then display 
the average of the values which are stored in the first array and then 
the average of the values in the second array.
*/

// Adrián Navarro Gabino

using System;

public class AverageTwoArrays
{
    public static void Main()
    {
        const int SIZE = 10;
        
        double[] data1 = new double[10];
        double[] data2 = new double[10];
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the number {0} of data1: ", (i+1));
            data1[i] = Convert.ToDouble(Console.ReadLine());
        }
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the number {0} of data2: ", (i+1));
            data2[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        double sum1,sum2;
        sum1 = sum2 = 0;
        double average1, average2, totalAverage;
        
        foreach(double d in data1)
        {
            sum1 += d;
        }
        foreach(double d in data2)
        {
            sum1 += d;
        }
        
        average1 = sum1 / SIZE;
        average2 = sum2 / SIZE;
        
        totalAverage = (average1 + average2) / 2;
        
        Console.WriteLine("Average of data1: " + average1);
        Console.WriteLine("Average of data2: " + average2);
        Console.WriteLine("Total average: " + totalAverage);
    }
}
