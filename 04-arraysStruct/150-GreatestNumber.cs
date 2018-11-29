// Max of an Array
// Adrián Navarro Gabino

using System;

public class GreatestNumber
{
    public static void Main()
    {
        const int SIZE = 5;
        byte[] data = new byte[SIZE];
        byte greatest, position;

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter data {0}: ", i+1);
            data[i] = Convert.ToByte(Console.ReadLine());
        }

        greatest = data[0];
        position = 0;
        
        for(byte i = 1; i < SIZE; i++)
        {
            greatest = data[i] > greatest ? data[i] : greatest;
            position = greatest == data[i] ? i : position;
        }
        
        Console.WriteLine("Greatest: " + greatest);
        Console.WriteLine("Position: " + (position + 1));
    }
}
