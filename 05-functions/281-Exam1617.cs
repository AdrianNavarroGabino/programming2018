// Adrián Navarro Gabino

using System;

public class Exam1617
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
    
    public static void ObtenerDigitos(
        double n, ref int cEnt, ref int CMS)
    {
        CMS = 0;
        
        int num = (int)n;
        int count = 0;
        
        while(num != 0)
        {
            num /= 10;
            if(num < 10 && num > 0)
                CMS = num;
            count++;
        }
        
        cEnt = count;
    }
    
    public static void MostrarRecuadroRedondeado(int w, int h)
    {
        Console.WriteLine("/" + new string('-', w - 2) + "\\");
        
        for(int i = 0; i < h - 2; i++)
            Console.WriteLine("|" + new string(' ', w - 2) + "|");
        
        Console.WriteLine("\\" + new string('-', w - 2) + "/");
    }
    
    public static bool Contains(string s, char c)
    {
        foreach(char l in s.ToLower())
        {
            if (l == c)
                return true;
        }
        return false;
    }
    
    
    
    public static int Main(string[] args)
    {
        if(args.Length == 0 ||
            (args[0].ToLower().CompareTo("max") != 0 &&
            args[0].ToLower().CompareTo("digitos") != 0 &&
            args[0].ToLower().CompareTo("cuadro") != 0 &&
            args[0].ToLower().CompareTo("contiene") != 0))
        {
            Console.WriteLine("Uso: max / dígitos / cuadro / contiene");
            return 1;
        }
        else
        {
            if(args[0].ToLower().CompareTo("max") == 0)
            {
                if(args.Length < 2)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    Console.WriteLine(
                        ObtenerMayorDigito(Convert.ToInt64(args[1])));
                }
            }
            else if(args[0].ToLower().CompareTo("digitos") == 0)
            {
                if(args.Length < 2)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    int cEnt = 0;
                    int CMS = 0;
                    
                    ObtenerDigitos(Convert.ToDouble(args[1]),
                        ref cEnt, ref CMS);
                        
                    Console.WriteLine(cEnt);
                }
                
            }
            else if(args[0].ToLower().CompareTo("cuadro") == 0)
            {
                if(args.Length < 2)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    MostrarRecuadroRedondeado(
                        Convert.ToInt32(args[1]), 5);
                }
            }
            else if(args[0].ToLower().CompareTo("contiene") == 0)
            {
                if(args.Length < 3)
                {
                    Console.WriteLine("Faltan parámetros");
                    return 2;
                }
                else
                {
                    if(Contains(args[1], Convert.ToChar(args[2])))
                        Console.WriteLine(
                            "La letra es parte de la cadena");
                    else
                        Console.WriteLine(
                            "La letra no es parte de la cadena");
                }
            }
            
            return 0;
        }
    }
}
