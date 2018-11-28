/*
Entrada de ejemplo
7
90
91
359
2
0
359
91
90
0
180
180
0
90
270
Salida de ejemplo
ASCENDENTE
ASCENDENTE
DESCENDENTE
DESCENDENTE
DA IGUAL
DA IGUAL
DA IGUAL
*/

// Adrián Navarro Gabino

using System;

public class Prick
{
    public static void Main()
    {
        ushort start, prick;
        ulong cases = Convert.ToUInt64(Console.ReadLine());
        
        for(ulong i = 0; i < cases; i++)
        {
            start = Convert.ToUInt16(Console.ReadLine());
            prick = Convert.ToUInt16(Console.ReadLine());

            int prickAux = prick - start;
            
            if(prickAux == 0 || prickAux == 180 || prickAux == -180)
                Console.WriteLine("DA IGUAL");
            else if((prickAux > 0 && prickAux < 180) || 
                    (prickAux < -180 && prickAux > -360))
                Console.WriteLine("ASCENDENTE");
            else
                Console.WriteLine("DESCENDENTE");
        }
    }
}
