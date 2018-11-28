/*
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50
Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
*/

// Adrián Navarro Gabino

using System;

public class FinDeMes
{
    public static void Main()
    {
        int casosPrueba = Convert.ToInt32(Console.ReadLine());
        string[] cuentaCorriente;
        short[] dinero = new short[2];
        
        for(int i = 0; i < casosPrueba; i++)
        {
            cuentaCorriente = Console.ReadLine().Split();
            dinero[0] = Convert.ToInt16(cuentaCorriente[0]);
            dinero[1] = Convert.ToInt16(cuentaCorriente[1]);
            
            Console.WriteLine("{0}", dinero[0] + dinero[1] >= 0 ? "SI" : "NO");
        }
    }
}
