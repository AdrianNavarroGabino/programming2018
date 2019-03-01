// Adrián Navarro Gabino

using System;

public class IdentityMatrix
{
    public static void Main()
    {
        const int SIZE = 3;
        int[,] matrix = new int[SIZE,SIZE];
        
        bool iden = true;
        
        for(int row = 0; row < SIZE; row++)
        {
            for(int col = 0; col < SIZE; col++)
            {
                Console.Write("Row {0}, column {1}: ", row+1, col+1);
                matrix[row,col] = Convert.ToInt32(Console.ReadLine());
                if((row == col && matrix[row,col] != 1) ||
                        (row != col && matrix[row,col] != 0))
                {
                    iden = false;
                }
            }
        }
        
        if(iden)
            Console.WriteLine("It's an identity matrix.");
        else
            Console.WriteLine("It's NOT an identity matrix.");
    }
}
