// Adrián Navarro Gabino

using System;

public class ArrayOfArrays
{
    public static void Main()
    {
        const int SIZE = 3;
        
        int[][] data = new int[SIZE][];
        
        data[0] = new int[6];
        data[1] = new int[5];
        data[2] = new int[4];

        for(int row = 0; row < SIZE; row++)
        {
            for(int column = 0; column < data[row].Length; column++)
            {
                Console.Write("Row {0}, column {1}: ", row+1,column+1);
                data[row][column] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine();
        
        for(int row = 0; row < SIZE; row++)
        {
            for(int column = 0; column < data[row].Length; column++)
            {
                Console.Write(data[row][column] + " ");
            }
            Console.WriteLine();
        }
        
    }
}
