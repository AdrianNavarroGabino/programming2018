// Adrián Navarro Gabino

using System;

public class MinMaxMed
{
    public static void Main()
    {
        const int SIZE = 5;
        
        short[] numbers = new short[SIZE];
        short aux;
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Introduce el número {0}: ", i+1);
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
        
        Console.WriteLine("Mínimo: {0}", numbers[0]);
        Console.WriteLine("Máximo: {0}", numbers[SIZE - 1]);
        Console.WriteLine("Mediana: {0}", numbers[SIZE / 2]);
    }
}
