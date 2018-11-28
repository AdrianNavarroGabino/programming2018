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

using System;

public class AbuelaMaria
{
    public static void Main()
    {
        const int SIZE = 6;
        
        int cases = Convert.ToInt32(Console.ReadLine());
        
        ushort[,] data = new ushort[2,SIZE];
        string[][] rows = new string[2][];
        
        bool yes;
        ushort sum;
        
        for(int i = 0; i < cases; i++)
        {
            yes = true;
            
            rows[0] = Console.ReadLine().Split();
            rows[1] = Console.ReadLine().Split();
            
            for(int j = 0; j < SIZE; j++)
            {
                data[0,j] = Convert.ToUInt16(rows[0][j]);
                data[1,j] = Convert.ToUInt16(rows[1][j]);
            }
            
            sum = (ushort)(data[0,0] + data[1,0]);
            
            for(int j = 1; j < SIZE; j++)
            {
                if(data[0,j] + data[1,j] != sum)
                {
                    yes = false;
                }
            }
            
            if(yes)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
