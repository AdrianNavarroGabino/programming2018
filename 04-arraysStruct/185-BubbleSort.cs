// Adrián Navarro Gabino

using System;

public class BubbleSort
{
    public static void Main()
    {
        const int SIZE = 10;
        
        short[] numbers = new short[SIZE];
        short aux;
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            numbers[i] = Convert.ToInt16(Console.ReadLine());
        }
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i + 1; j < SIZE; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    aux = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = aux;
                }
            }
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
