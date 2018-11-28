/*
To calculate how many marbles form a pyramid with triangular base knowing
the height of the pyramid.
Type 1
This type uses a loop and several variables to calculate the number of marbles.
*/

/*
Example of input
6
1
2
3
4
5
6
Example of output
1
4
10
20
35
56
*/

// Adrián Navarro Gabino

#include <stdio.h>

int Sumar(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else
        return n + Sumar(n-1);
}

int Piramide(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else
    {
        return Sumar(n) + Piramide(n-1);
    }
}

int main(void)
{
    int casos;
    int i;
    int n;
    int resultado=
    scanf("%d", &casos);
    
    for(i = 0; i < casos; i++)
    {
        scanf("%d", &n);
        resultado = Piramide(n);
        printf("%d", resultado);
    }
    return 0;
}
