// Adrián Navarro Gabino

import java.util.*;

public class Minesweeper
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int columns;
        int rows;
        
        do
        {
            int count = 0;
            
            columns = sc.nextInt();
            rows = sc.nextInt();
            sc.nextLine();
            
            if(columns != 0 || rows != 0)
            {
                String[] table = new String[rows];
                
                for(int i = 0; i < rows; i++)
                {
                    table[i] = sc.nextLine();
                }
                
                for(int i = 1; i < rows - 1; i++)
                {
                    for(int j = 1; j < columns - 1; j++)
                    {
                        int notMine = 0;
                    
                        if(table[i].charAt(j) == '-')
                        {
                            for(int k = -1; k <= 1; k++)
                            {
                                for(int l = -1; l <= 1; l++)
                                {
                                    notMine = table[i - k].charAt(j - l) == '-'
                                        ? notMine + 1 : notMine;
                                }
                            }
                            
                            if(notMine < 4)
                            {
                                count++;
                            }
                        }
                    }
                }
                
                System.out.println(count);
            }
        } while(columns != 0 || rows != 0);
    }
}
