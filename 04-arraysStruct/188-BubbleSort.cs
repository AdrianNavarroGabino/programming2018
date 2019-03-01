// Adrián Navarro Gabino

using System;

public class BubbleSort
{
    public static void Main()
    {
        const int SIZE = 5;
        ushort[] data = new ushort[SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            data[i] = Convert.ToUInt16(Console.ReadLine());
        }
        
        ushort aux;
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i + 1; j < SIZE; j++)
            {
                if(data[i] > data[j])
                {
                    aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("{0} ", data[i]);
        }
        Console.WriteLine();
    }
}
