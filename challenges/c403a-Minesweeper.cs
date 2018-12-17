// Adrián Navarro Gabino

using System;

public class Minesweeper
{
    public static void Main()
    {
        string[] tableSize;
        int columns;
        int rows;
        
        do
        {
            int count = 0;
            
            tableSize = Console.ReadLine().Split();
            
            columns = Convert.ToInt32(tableSize[0]);
            rows = Convert.ToInt32(tableSize[1]);
            
            if(columns != 0 || rows != 0)
            {
                string[] table = new string[rows];
                
                for(int i = 0; i < rows; i++)
                {
                    table[i] = Console.ReadLine();
                }
                
                for(int i = 1; i < rows - 1; i++)
                {
                    for(int j = 1; j < columns - 1; j++)
                    {
                        int notMine = 0;
                    
                        if(table[i][j] == '-')
                        {
                            for(int k = -1; k <= 1; k++)
                            {
                                for(int l = -1; l <= 1; l++)
                                {
                                    notMine = table[i - k][j - l] == '-' ?
                                        notMine + 1 : notMine;
                                }
                            }
                            
                            if(notMine < 4)
                            {
                                count++;
                            }
                        }
                    }
                }
                
                Console.WriteLine(count);
            }
        } while(columns != 0 || rows != 0);
    }
}
