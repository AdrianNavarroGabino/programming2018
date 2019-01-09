// Adrián Navarro Gabino

using System;

public class FunctionObtenerMayorDigito
{
    public static int ObtenerMayorDigito(long n)
    {
        string aux = "" + n;
        string[] aux2 = new string[aux.Length];
        
        for(int i = 0; i < aux.Length; i++)
        {
            aux2[i] = "" + aux[i];
        }
        
        
        int max = Convert.ToInt32(aux2[0]);
        
        for(int i = 1; i < aux2.Length; i++)
        {
            if(Convert.ToInt32(aux2[i]) > max)
                max = Convert.ToInt32(aux2[i]);
        }
        
        return max;
    }
    
    public static void Main()
    {
        if(ObtenerMayorDigito(276) != 7)
            Console.WriteLine("Algo no va bien!");
    }
}
