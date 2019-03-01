// Adrián Navarro Gabino

using System;

public class TicTacToe03
{
    public static bool CheckWinner(char x, char[,] table)
    {
        for(int row = 0; row < 3; row++)
        {
            if(table[row, 0] == x)
            {
                if(table[row + 1, 0] == x)
                {
                    if(table[row + 2, 0] == x)
                    {
                        return true;
                    }
                }
                if(table[row, 1] == x)
                {
                    if(table[row, 2] == x)
                    {
                        return true;
                    }
                }
                if(table[row + 1, 1] == x)
                {
                    if(table[row + 2, 2] == x)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public static void Main()
    {
        bool finished = false;
        int winner = 0;
        
        int userRow, userColumn;
        char[,] table = {
                        {'-','-','-'},
                        {'-','-','-'},
                        {'-','-','-'}
                        };
        int turn = 1;
        while(turn < 10 && !finished)
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
            
            if(userRow > 2 || userColumn > 2)
            {
                Console.WriteLine("The board is NOT so big");
            }
            else if(table[userRow,userColumn] == '-')
            {
                table[userRow,userColumn] = turn % 2 == 0 ? 'X' : 'O';
                turn++;
            }
            else if(table[userRow,userColumn] == 'X' ||
                    table[userRow,userColumn] == 'O')
            {
                Console.WriteLine("You can't place your token here. Try again");
            }
            
            
            if(CheckWinner('O', table))
            {
                finished = true;
                winner = 1;
            }
            else if(CheckWinner('X', table))
            {
                finished = true;
                winner = 2;
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
        
        if(winner == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Player 1 has won");
        }
        else if(winner == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Player 2 has won");
        }
    }
}
