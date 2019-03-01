// Adrián Navarro Gabino

using System;

public class NumerosRepetidos
{
    public static void Main()
    {
        const int FILAS = 2;
        const int COLS = 5;
        
        int[,] numeros = new int[FILAS, COLS];
        
        for(int fila = 0; fila < FILAS; fila++)
        {
            for(int col = 0; col < COLS; col++)
            {
                Console.Write("Fila {0}, columna {1}: ", fila+1, col+1);
                numeros[fila,col] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("Repetidos:");
        for(int i = 0; i < COLS; i++)
        {
            for(int j = 0; j < COLS; j++)
            {
                if(numeros[0,i] == numeros[1,j])
                {
                    Console.WriteLine(numeros[0,i]);
                }
            }
        }
    }
}
