/*
Entrada
La entrada estará formada por distintos casos de prueba, cada uno representando 
la configuración de dientes de un día en la vida de la abuela María. El número 
total de casos aparece en la primera línea de la entrada.
Los casos siguen a continuación, cada uno formado por dos líneas. La primera 
contiene el alto de los seis dientes superiores responsables de la sonrisa 
(incisivos y caninos) de izquierda a derecha. De forma equivalente, la segunda 
línea contiene la información de los seis inferiores. Todos ellos son números 
enteros entre 0 y 2.000.
Salida
Para cada caso de prueba se escribirá SI si los dientes de arriba encajan 
perfectamente con los de abajo y no quedan huecos entre ninguno de ellos, o NO 
en caso contrario.
Entrada de ejemplo
2
1 3 1 3 1 3
3 1 3 1 3 1
1 1 1 1 1 1
1 2 1 1 1 1
Salida de ejemplo
SI
NO
*/

// Adrián Navarro Gabino

import java.util.*;

public class AbuelaMaria
{
    public static void main(String[] args)
    {
        final int SIZE = 6;
        
        Scanner sc = new Scanner(System.in);
        
        int cases;
        cases = sc.nextInt();
        
        int row1[] = new int[SIZE];
        int row2[] = new int[SIZE];
        
        boolean yes;
        int sum;
        
        for(int i = 0; i < cases; i++)
        {
            yes = true;
            
            for(int j = 0; j < SIZE; j++)
            {
                row1[j] = sc.nextInt();
            }
            for(int j = 0; j < SIZE; j++)
            {
                row2[j] = sc.nextInt();
            }
            
            sum = row1[0] + row2[0];
            
            for(int j = 1; j < SIZE; j++)
            {
                if(row1[j] + row2[j] != sum)
                {
                    yes = false;
                }
            }
            
            if(yes)
            {
                System.out.println("SI");
            }
            else
            {
                System.out.println("NO");
            }
        }
    }
}
