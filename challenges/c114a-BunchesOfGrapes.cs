/*
https://www.aceptaelreto.com/problem/statement.php?id=433
Racimos de uvas
Entrada de ejemplo
10
40
400
4000
40000
400000
0
Salida de ejemplo
4
9
28
89
283
894
*/


// Adrián Navarro Gabino

using System;

public class BunchesOfGrapes
{
    public static void Main()
    {
        int grapes;
        
        do
        {
            grapes = Convert.ToInt32(Console.ReadLine());
            
            if(grapes != 0)
            {
                double level = (-1 + Math.Sqrt(1 + 8 * grapes)) / 2;
                
                Console.WriteLine(Convert.ToInt32(Math.Ceiling(level)));
            }
        }while(grapes != 0);
    }
}
