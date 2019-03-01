// Adrián Navarro Gabino

using System;

public class InsercionDirecta
{
    public static void Main()
    {
        const int SIZE = 10;
        
        int[] numbers = new int[SIZE];
        int aux;
        int j;
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int i = 1; i < SIZE; i++)
        {
            j = i - 1;
            
            while(j >= 0 && numbers[j] > numbers[j+1])
            {
                aux = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1] = aux;
                
                j--;
            }
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
