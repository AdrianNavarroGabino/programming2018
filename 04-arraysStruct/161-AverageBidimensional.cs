/*
Create a program to ask the user for 20 real numbers, store them in a 
2x10 bidimensional array (named "data"), and then display the average 
of the values which are stored in the first half array and then the 
average of the values in the second half array.
*/

// Adrián Navarro Gabino

using System;

public class AverageBidimensional
{
    public static void Main()
    {
        const int SIZE = 10;
        double[,] data = new double[2,SIZE];

        for (int group = 0; group < 2; group++)
            for (int mark = 0; mark < SIZE; mark++)
            {
                Console.WriteLine(
                    "Enter data for pos {0} in block {1}: ", 
                    mark + 1, group + 1);
                data[group,mark] = Convert.ToDouble(Console.ReadLine());
            }

        double sum = 0;
        foreach (double d in data)
            sum += d;
        double average = sum / (SIZE*2);

        Console.WriteLine("The global average is: "+average);
        
        sum = 0;
        for (int i = 0; i < SIZE; i++)
            sum += data[0,i];
        average = sum / SIZE;
        Console.WriteLine("The average of block 1 is: "+average);
    }
}
