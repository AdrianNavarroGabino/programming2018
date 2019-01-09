// Adrián Navarro Gabino

using System;

public class FunctionObtenerDigitos
{
    public static void ObtenerDigitos(
                                double n, ref int cEnt, ref int CMS)
    {
        CMS = 0;
        
        int num = (int)n;
        int count = 0;
        
        while(num != 0)
        {
            if(num < 10 && num > 0)
                CMS = num;
            num /= 10;
            count++;
        }
        
        cEnt = count;
    }
    
    public static void Main()
    {
        int cEnt = 0;
        int CMS = 0;
        
        ObtenerDigitos(236.78, ref cEnt, ref CMS);
        
        Console.WriteLine(cEnt);
        Console.WriteLine(CMS);
    }
}
