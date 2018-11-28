/*
    Calculates basic operations
*/

/*
Example of input
5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13
Example of output
-8
5
21
ERROR
-8
*/

// Adrián Navarro Gabino

#include <stdio.h>

int main()
{
    int i;
    
    int casosPrueba;
    scanf("%d", &casosPrueba);
    
    int dato1;
    int dato2;
    char operacion;
    
    int resultado;
    
    for(i = 0; i < casosPrueba; i++)
    {
        scanf("%d", &dato1);
        scanf("%c", &operacion);
        scanf("%d", &dato2);
        
        switch(operacion)
        {
            case '+':
                resultado = dato1 + dato2;
                printf("%d\n", resultado);
                break;
            case '-':
                resultado = dato1 - dato2;
                printf("%d\n", resultado);
                break;
            case '*':
                resultado = dato1 * dato2;
                printf("%d\n", resultado);
                break;
            case '/':
                if(dato2 != 0)
                {
                    resultado = dato1 / dato2;
                    printf("%d\n", resultado);
                }
                else
                {
                    printf("ERROR");
                }
                break;
            default:
                break;
        }
    }
    
    return 0;
}
