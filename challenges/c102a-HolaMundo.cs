/*
Reto 1.02: Hola mundo (Acepta 116)
Entrada de ejemplo
3
Salida de ejemplo
Hola mundo.
Hola mundo.
Hola mundo.
*/

// Adrián Navarro Gabino

using System;

public class HolaMundo
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < n; i++)
            Console.WriteLine("Hola mundo.");
    }
}
