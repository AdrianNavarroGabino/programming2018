// Adrián Navarro Gabino

using System;

public class TicTacToe02
{
    public static void Main()
    {
        int userRow, userColumn;
        char[,] table = {
                        {'-','-','-'},
                        {'-','-','-'},
                        {'-','-','-'}
                        };
        int turn = 1;
        while(turn < 10)
        {
            for(int row = 0; row < 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    Console.Write(table[row,column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.Write("Row? ");
            userRow = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Column? ");
            userColumn = Convert.ToInt32(Console.ReadLine()) - 1;
            
            if(table[userRow,userColumn] == '-')
            {
                table[userRow,userColumn] = turn % 2 == 0 ? 'X' : 'O';
                turn++;
            }
            else
            {
                Console.WriteLine("You can't place your token here. Try again");
            }
        
            Console.WriteLine();
        }
        
        for(int row = 0; row < 3; row++)
        {
            for(int column = 0; column < 3; column++)
            {
                Console.Write(table[row,column]);
            }
            Console.WriteLine();
        }
    }
}
