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

import java.util.*;

public class BunchesOfGrapes
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int grapes;
        
        do
        {
            grapes = sc.nextInt();
            
            if(grapes != 0)
            {
                double level = (-1 + Math.sqrt(1 + 8 * grapes)) / 2;
                
                System.out.println((int)Math.ceil(level));
            }
        }while(grapes != 0);
    }
}
