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

using System;

public class PiramideDeCanicas
{
    public static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < casos; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Piramide(n));
        }
    }
    
    static int Piramide(int n)
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
    
    static int Sumar(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        else
            return n + Sumar(n-1);
    }
}
