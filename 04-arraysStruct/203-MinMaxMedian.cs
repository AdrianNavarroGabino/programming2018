// Adrián Navarro Gabino

using System;

public class MinMaxMedian
{
    public static void Main()
    {
        const int SIZE = 8;
        int[] data = new int[SIZE];
        int sum = 0;
        int aux;

        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
            sum += data[i];
        }

        for (int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i+1 ; j < SIZE; j++)
            {
                if(data[i] > data[j])
                {
                    aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        Console.WriteLine("Max: {0}", data[SIZE-1]);
        Console.WriteLine("Min: {0}", data[0]);
        Console.WriteLine("Average: {0}", ((double) sum ) / SIZE );
        int middleLeft = SIZE/2 - 1;
        int middleRight = SIZE/2;
        Console.WriteLine("Median: {0}", 
            (data[middleLeft] + data[middleRight]) / 2.0 );
        
        
    }
}
