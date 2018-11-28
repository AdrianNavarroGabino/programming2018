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

#include <stdio.h>

int main()
{
    short int i, j;
    
    int cases;
    scanf("%d", &cases);
    
    int row1[6];
    int row2[6];
    
    int sum;
    int yes;
    
    for(i = 0; i < cases; i++)
    {
        yes = 0;
        
        for(j = 0; j < 6; j++)
        {
            scanf("%d", &row1[j]);
        }
        for(j = 0; j < 6; j++)
        {
            scanf("%d", &row2[j]);
        }
        
        sum = row1[0] + row2[0];
        
        for(j = 0; j < 6; j++)
        {
            if(row1[j] + row2[j] != sum)
            {
                yes = 1;
            }
        }
        
        if(yes == 0)
        {
            printf("SI\n");
        }
        else
        {
            printf("NO\n");
        }
    }
}
