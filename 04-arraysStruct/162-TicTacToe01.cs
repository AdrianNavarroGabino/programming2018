// Adrián Navarro Gabino

using System;

public class TicTacToe01
{
    public static void Main()
    {
        int userRow, userColumn;
        char[,] table = new char[3,3];
        
        Console.Write("Row? ");
        userRow = Convert.ToInt32(Console.ReadLine());
        Console.Write("Column? ");
        userColumn = Convert.ToInt32(Console.ReadLine());
        
        for(int row = 0; row < 3; row++)
        {
            for(int column = 0; column < 3; column++)
            {
                if(row == userRow - 1 && column == userColumn - 1)
                    table[row,column] = 'O';
                else
                    table[row,column] = '.';
                    
                Console.Write(table[row,column]);
            }
            Console.WriteLine();
        }
    }
}
