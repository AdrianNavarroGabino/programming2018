// Adrián Navarro Gabino

using System;

public class DirectSelectionSort
{
    public static void Main()
    {
        const int SIZE = 5;
        int[] data = new int[SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int aux;
        int lower;
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            lower = i;
            
            for(int j = i + 1; j < SIZE; j++)
            {
                if(data[lower] > data[j])
                {
                    lower = j;
                }
            }
            if(lower != data[i])
            {
                aux = data[i];
                data[i] = data[lower];
                data[lower] = aux;
            }
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("{0} ", data[i]);
        }
        Console.WriteLine();
    }
}
