// Adrián Navarro Gabino

using System;

public class RepeatedRows
{
    public static void Main()
    {
        const int SIZE = 3;
        bool repeated1 = true;
        bool repeated2 = true;
        bool repeated3 = true;
        
        float[,] data = new float[SIZE,SIZE];
        
        for(int row = 0; row < SIZE; row++)
        {
            for(int col = 0; col < SIZE; col++)
            {
                Console.Write("Row {0}, column {1}: ", row+1, col+1);
                data[row,col] = Convert.ToSingle(Console.ReadLine());
            }
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            if(data[0,i] != data[1,i])
                repeated1 = false;
            if(data[0,i] != data[2,i])
                repeated2 = false;
            if(data[1,i] != data[2,i])
                repeated3 = false;
        }
        
        if(repeated1 || repeated2 || repeated3)
            Console.WriteLine("There's (at least) a repeated row");
        else
            Console.WriteLine("There aren't repeated rows");
    }
}
