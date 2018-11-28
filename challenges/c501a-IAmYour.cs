/*
Entrada de ejemplo
4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre
Salida de ejemplo
C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre
*/

// Adrián Navarro Gabino

using System;

public class IAmYour
{
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            string name = Console.ReadLine();
            string relationship = Console.ReadLine();
            
            if(name != "Luke" || relationship != "padre")
            {
                Console.WriteLine(name + ", yo soy tu " + relationship);
            }
            else
            {
                Console.WriteLine("TOP SECRET");
            }
        }
    }
}
