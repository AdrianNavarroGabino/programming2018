/*
Example of input
4
3
3
3
4
5
3
9
9
Example of output
Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

// Adrián Navarro Gabino

using System;

public class Snake
{
    public static void Main()
    {
        int casos;
        int m;
        byte n;
        
        casos = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= casos; i++)
        {
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("Caso {0}", i);
            
            for(int linea = 1; linea <= m; linea++)
            {
                if(linea % 2 == 1)
                {
                    for(int sostenido = 1; sostenido <= n; sostenido++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                
                else
                {
                    if(linea % 4 == 0)
                    {
                        Console.Write("#");
                    }
                    
                    for(int punto = 1; punto < n; punto++)
                    {
                        Console.Write(".");
                    }
                        
                    
                    if(linea % 4 != 0)
                    {
                        Console.Write("#");
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
