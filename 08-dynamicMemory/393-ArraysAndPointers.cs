// Adrián Navarro Gabino

using System;

public class ArraysAndPointers
{

    public unsafe static void Main()
    {
        const int SIZE = 5;
        int* data = stackalloc int[SIZE];

        for (int i = 0; i < SIZE; i++)
            data[i] = i * 10;

        for (int i = 0; i < SIZE; i++)
            Console.Write(data[i]+ " ");
        Console.WriteLine();

        int* start = data;
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write(*start + " ");
            start++;
        }
        Console.WriteLine();
    }
}
